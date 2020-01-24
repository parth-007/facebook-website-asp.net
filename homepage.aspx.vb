Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient

Partial Class homepage
    Inherits System.Web.UI.Page
    Dim sql As String
    Dim ds As New DataSet
    Dim adp As New SqlDataAdapter
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim x As Integer
    Dim sql1 As String
    Dim cmd1 As New SqlCommand
    Dim x1 As String
    Dim y1 As String

    Dim sql2, sql3 As String
    Dim cmd2, cmd3 As New SqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "select stateid from Users where email='" & Session("email") & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        If IsDBNull(cmd.ExecuteScalar) Then
            Button4.Text = "Your Profile looks Uncompleted.Let's Make it Complete"
        Else
            Button4.Text = "Your Profile looks good"
        End If
        con.Close()

        Dim s1 As String
        s1 = Session("email")
        sql = "select pic from Users where email='" & s1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()


        If IsDBNull(cmd.ExecuteScalar) Then
            Image2.ImageUrl = "profilepics/blank-profile-hi.png"
        Else
            Image2.ImageUrl = cmd.ExecuteScalar
        End If
        con.Close()

        'Image2.ImageUrl = x

        'Dim s1 As String = Session("email")
        'sql = "select cityid from Users where email='" & s1 & "'"
        'cmd = New SqlCommand(sql, con)
        'con.Open()
        'If IsDBNull(cmd.ExecuteScalar) Then
        '    profilebtn.Text = "Your Profile Looks Uncompleted .. Let's make it Perfect."
        'Else
        '    profilebtn.Text = "Profile looks good."
        'End If
        'con.Close()

        ''Session("rr") = "Your Profile Looks Uncompleted .. Let's make it Perfect."
        'profilebtn.Text = Session("rr")
        ''Dim selectem As String
        'selectem = Session("email")

        'sql = "select fname from Users where email='" & selectem & "'"
        'sql1 = "select surname from Users where email='" & selectem & "'"

        'cmd = New SqlCommand(sql, con)
        'cmd1 = New SqlCommand(sql1, con)

        'con.Open()
        'x1 = cmd.ExecuteScalar
        'y1 = cmd1.ExecuteScalar

        'con.Close()

        'MsgBox(x1)
        'MsgBox(y1)
        'Dim btn As New Button
        'btn.Text = x1 & y1

        '     DirectCast(Master.FindControl("mymain"), LinkButton).Text = btn.Text


    End Sub
    'Public Shared Function GetAutoCompleteData(ByVal username As String) As List(Of String)
    '    Dim result As New List(Of String)()
    '    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    '    Dim cmd As New SqlCommand("select fname,surname from Users where fname LIKE '%'+@SearchText+'%'", con)
    '    con.Open()
    '    cmd.Parameters.AddWithValue("@SearchText", username)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    While dr.Read()
    '        result.Add(String.Format("{0}/{1}", dr("fname"), dr("surname")))
    '    End While
    '    Return result

    'End Function
    ''Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
    '    Page.MasterPageFile = "Facebook.master"

    'End Sub

  
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        

        Dim s1 As String = Session("email")
        ''        sql = "alter table Users add status" & flag & " varchar(300)"
        sql = "update Users set status='" & TextBox1.Text & "' where email='" & s1 & "'"

        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery()
        con.Close()
        If x > 0 Then
            Response.Write("<script>alert('Status Updated')</script>")
            Pnl2.Visible = True
            Dim x, y As String
            Dim z As String

            s1 = Session("email")
            sql = "select fname from Users where email='" & s1 & "'"
            sql1 = "select surname from Users where email='" & s1 & "'"
            sql2 = "select status from Users where email='" & s1 & "'"
            cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
            cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)
            cmd2 = New SqlCommand(sql2, con)

            con.Open()
            x = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar
           
            z = cmd2.ExecuteScalar
            con.Close()

            Label1.Text = z
            LinkButton2.Text = x & " " & y


        End If
        'cmd1 = New SqlCommand(sql1, con)
        ''con.Open()
        ''cmd1.ExecuteNonQuery()
        ''flag = flag + 1
        ''con.Close()

    End Sub

    Protected Sub likeBtn_Click(sender As Object, e As EventArgs) Handles likeBtn.Click
        If likeBtn.Text = "Liked" Then
            likeBtn.Text = "Like"
            lblcnt.Text = 0
        Else
            likeBtn.Text = "Liked"
            lblcnt.Text = 1
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = True

    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim s1, x, y, z As String
        s1 = Session("email")
        If FileUpload1.HasFile Then
            Dim m = FileUpload1.FileName
            Dim str As String
            str = Server.MapPath("~/latestpics/") + m
            Session("tk") = FileUpload1.FileName
            FileUpload1.SaveAs(str)
            FileUpload1.Visible = False
            Dim tkk As String
            tkk = "latestpics/" + m

            sql3 = "update Users set lpic='" & str & "' where email='" & s1 & "'"
            cmd3 = New SqlCommand(sql3, con)
            con.Open()
            x = cmd3.ExecuteNonQuery()

            con.Close()
            If x > 0 Then
                Image1.ImageUrl = tkk
                sql = "select fname from Users where email='" & s1 & "'"
                sql1 = "select surname from Users where email='" & s1 & "'"

                cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
                cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)


                con.Open()
                x = cmd.ExecuteScalar
                y = cmd1.ExecuteScalar


                con.Close()

                LinkButton3.Text = x & "" & y

            End If
        Else
            Response.Write("<script>alert('No Image Selected')</script>")
        End If
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fna As String = Request.Form(TextBox2.UniqueID)
        Dim id As String = Request.Form(HiddenField1.UniqueID)

    End Sub

    Protected Sub likeBtn0_Click(sender As Object, e As EventArgs) Handles likeBtn0.Click
        If likeBtn0.Text = "Liked" Then


            likeBtn0.Text = "Like"
            lblcnt0.Text = "0"

        Else
            likeBtn0.Text = "Liked"
            lblcnt0.Text = "1"
        End If
    End Sub
End Class
