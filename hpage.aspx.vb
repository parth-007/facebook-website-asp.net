Imports System.Data
Imports System.Data.SqlClient

Partial Class hpage
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
    Dim sql4 As String
    Dim cmd4 As New SqlCommand

    Dim sql2, sql3 As String
    Dim cmd2, cmd3 As New SqlCommand
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
    Public Sub fillthat()

        sql = "select fname +' '+ surname as Maxname from Users"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        '  DropDownList1.DataTextFormatString = "{0} - {1}"
        DropDownList1.DataTextField = "Maxname"




        DropDownList1.DataSource = ds.Tables(0)
        DropDownList1.DataBind()

    End Sub
   
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim lbl1 As Label

        'lbl1 = (Label)(Me.Page.Master.FindControl("lblMaster"))
        Dim ssss As String
        If Session("flag") = "" Then
            Response.Redirect("Default.aspx")

        End If

       
        Dim s1 As String

        s1 = Session("email")
        sql = "select fname from Users where email='" & s1 & "'"
        sql1 = "select surname from Users where email='" & s1 & "'"
        sql2 = "select status from Users where email='" & s1 & "'"
        sql4 = "select gender from Users where email='" & s1 & "'"
        cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
        cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)
        cmd2 = New SqlCommand(sql2, con)
        cmd4 = New SqlCommand(sql4, con)

        con.Open()
        LinkButton8.Text = cmd.ExecuteScalar & " " & cmd1.ExecuteScalar
        If IsDBNull(cmd2.ExecuteScalar) Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            Label6.Text = cmd2.ExecuteScalar
        End If

        If cmd4.ExecuteScalar = "Male" Then
            Label5.Text = "His"
        Else
            Label5.Text = "Her"
        End If
        Label5.Text = cmd4.ExecuteScalar

        con.Close()

        Dim id As Integer
        Dim res As String = "no"
        sql = "select userid from Users where email='" & Session("email") & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        id = cmd.ExecuteScalar

        con.Close()

        Dim r1 As Integer
        sql = "select count(*) from FriendReq where acceptuserid2=" & id & " and response='" & res & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        r1 = cmd.ExecuteScalar
        Session("r1") = r1

        con.Close()
        Label4.Text = Session("r1")


        If Not IsPostBack Then
            LinkButton6.Visible = False
            LinkButton7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            lbl5.Visible = False

            If Session("dmail") = Session("email") Then
                LinkButton6.Visible = True
                LinkButton7.Visible = True
                Button8.Visible = True
                Button9.Visible = True
                lbl5.Visible = True

                sql = "select fname from Users where email='" & Session("detectemail") & "'"
                sql1 = "select surname from Users where email='" & Session("detectemail") & "'"

                cmd = New SqlCommand(sql, con)
                cmd1 = New SqlCommand(sql1, con)
                con.Open()
                Dim x, y As String
                x = cmd.ExecuteScalar
                y = cmd1.ExecuteScalar

                con.Close()

                LinkButton6.Text = x & "" & y

            End If
            fillthat()

            Panel1.Visible = False
            Panel2.Visible = False


            sql = "select stateid from Users where email='" & Session("email") & "'"
            cmd = New SqlCommand(sql, con)
            con.Open()
            If IsDBNull(cmd.ExecuteScalar) Then
                Button4.Text = "Your Profile looks Uncompleted.Let's Make it Complete"
            Else
                Button4.Text = "Your Profile looks good"
            End If
            con.Close()

            Dim ssck As String
            ssck = Session("email")
            sql = "select pic from Users where email='" & ssck & "'"
            cmd = New SqlCommand(sql, con)
            con.Open()


            If IsDBNull(cmd.ExecuteScalar) Then
                Image2.ImageUrl = "profilepics/blank-profile-hi.png"
            Else
                Image2.ImageUrl = cmd.ExecuteScalar
            End If
            con.Close()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True

        Dim s1 As String = Session("email")
        ''        sql = "alter table Users add status" & flag & " varchar(300)"
        sql = "update Users set status='" & TextBox1.Text & "' where email='" & s1 & "'"

        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery()
        con.Close()
        If x > 0 Then
            Response.Write("<script>alert('Status Updated')</script>")
            Panel1.Visible = True
            Dim x, y As String
            Dim z As String

            s1 = Session("email")
            sql = "select fname from Users where email='" & s1 & "'"
            sql1 = "select surname from Users where email='" & s1 & "'"
            sql2 = "select status from Users where email='" & s1 & "'"
            sql4 = "select gender from Users where email='" & s1 & "'"
            cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
            cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)
            cmd2 = New SqlCommand(sql2, con)
            cmd4 = New SqlCommand(sql4, con)

            con.Open()
            x = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar

            z = cmd2.ExecuteScalar
            Dim op As String
            op = cmd4.ExecuteScalar

            con.Close()
            If op = "Male" Then
                Label1.Text = "His"
                '   Label5.Text = "His"
            Else
                Label1.Text = "Her"
                'Label5.Text = "Her"
            End If

            LinkButton2.Text = x & " " & y
            'LinkButton8.Text = x & " " & y

            Label2.Text = z


        End If
    End Sub

    Protected Sub likeBtn0_Click(sender As Object, e As EventArgs) Handles likeBtn0.Click
        If likeBtn0.Text = "Liked" Then
            Label3.Text = "0"
            likeBtn0.Text = "Like"
        Else
            Label3.Text = "1"
            likeBtn0.Text = "Liked"
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = True

    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "Liked" Then
            likecnt.Text = "0"
            Button6.Text = "Like"
        Else

            likecnt.Text = "1"
            Button6.Text = "Liked"
        End If
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim s1 As String

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
                Image3.ImageUrl = tkk
                sql = "select fname from Users where email='" & s1 & "'"
                sql1 = "select surname from Users where email='" & s1 & "'"

                cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
                cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)


                con.Open()
                Dim x As String = cmd.ExecuteScalar
                Dim y = cmd1.ExecuteScalar


                con.Close()

                LinkButton3.Text = x & "" & y

            End If
        Else
            Response.Write("<script>alert('No Image Selected')</script>")
        End If
    End Sub

    Protected Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim temp1 As String
        temp1 = TextBox2.Text

        '  sql = "select fname from Users where fname like '" & temp1 & "' %"
        sql = "select fname from Users where fname like '" & temp1 & "%'"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        nameCombo.DataTextField = "fname"
        nameCombo.DataSource = ds.Tables(0)
        nameCombo.DataBind()
        nameCombo.Items.Insert(0, "Select Name")


    End Sub

    Protected Sub searchBtn0_Click(sender As Object, e As EventArgs) Handles searchBtn0.Click
        Dim temp2 As String

        temp2 = TextBox2.Text
        Dim t1 As String
        t1 = nameCombo.SelectedValue.ToString

        '    MsgBox(t1)
        '  sql = "select fname from Users where fname like '" & temp1 & "' %"
        sql = "select surname from Users where fname='" & t1 & "'"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        nameCombo0.DataTextField = "surname"
        nameCombo0.DataSource = ds.Tables(0)
        nameCombo0.DataBind()
        nameCombo0.Items.Insert(0, "Select Surname")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim t1 As String
        Dim t2 As String
        t1 = nameCombo.SelectedValue.ToString
        t2 = nameCombo0.SelectedValue.ToString

        sql = "select email from Users where fname='" & t1 & "' and surname='" & t2 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim xyz As String
        xyz = cmd.ExecuteScalar

        con.Close()
        Session("xyz") = xyz
        Session("dmail") = Session("email")
        Response.Redirect("OtherProfile.aspx")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

   
    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Session("cntme") = Label4.Text
        If Session("cntme") = 0 Then
        Else
            Response.Redirect("Requests.aspx")
        End If

    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Response.Redirect("Main_Profile.aspx")

    End Sub

    Protected Sub LinkButton8_Click(sender As Object, e As EventArgs) Handles LinkButton8.Click
        Response.Redirect("Main_Profile.aspx")

    End Sub
End Class
