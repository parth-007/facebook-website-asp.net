Imports System.Data
Imports System.Data.SqlClient

Partial Class Main_Profile
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd1, cmd2 As New SqlCommand
    Dim ds As New DataSet
    Dim adp As New SqlDataAdapter
    Dim x As Integer
    Dim i As Integer
    Dim sql1, sql2 As String
    Dim sql3, sql4 As String
    Dim cmd3, cmd4 As New SqlCommand

    Dim cmd5 As New SqlCommand
    Dim sql5 As String

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session("flag") = "" Then
            Response.Redirect("hpage.aspx")

        End If
        sql1 = "select userid from Users where email='" & Session("email") & "'"
        sql2 = "select userid from Users where email='" & Session("xyz") & "'"
        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)

        con.Open()
        x = cmd1.ExecuteScalar
        Dim xp As Integer

        xp = cmd1.ExecuteScalar

        Dim y As Integer = cmd2.ExecuteScalar
        Dim yp As Integer
        yp = cmd2.ExecuteScalar

        'select count(*) from Friends where id1=47 and id2=48 or id1=48 and id2=47
        con.Close()
        sql3 = "select count(*) from Friends where id1=" & x & " and id2=" & y & " or id1=" & x & " and id2=" & y & ""

        cmd3 = New SqlCommand(sql3, con)
        con.Open()
        x = cmd3.ExecuteScalar

        con.Close()
        Dim x1 As Integer
        x1 = x
        If x1 <> 0 Then
            Button1.Text = "Friends"
        End If

        sql4 = "select response from FriendReq where senduserid1=" & xp & " and acceptuserid2=" & yp & ""
        cmd4 = New SqlCommand(sql4, con)
        con.Open()
        If IsDBNull(cmd4.ExecuteScalar) Then
            Button1.Text = "Add Friend"
        Else
            Dim yy1 As String
            yy1 = cmd4.ExecuteScalar
            If yy1 = "no" Then


                Button1.Text = "Friend Requst Sent"
            End If
        End If
        con.Close()

        Dim ch1 As String
        ch1 = Session("xyz")
        sql1 = "select pic from Users where email='" & ch1 & "'"
        sql2 = "select coverpic from Users where email='" & ch1 & "'"
        sql5 = "select year from Users where email='" & ch1 & "'"

        sql3 = "select fname from Users where email='" & ch1 & "'"
        sql4 = "select surname from Users where email='" & ch1 & "'"

        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)
        cmd3 = New SqlCommand(sql3, con)
        cmd4 = New SqlCommand(sql4, con)
        cmd5 = New SqlCommand(sql5, con)

        con.Open()
        Dim q As String
        Dim q1 As String
        Dim t1 As String
        Dim t2 As String
        Dim l1 As Integer

        t1 = cmd3.ExecuteScalar
        t2 = cmd4.ExecuteScalar
        l1 = cmd5.ExecuteScalar

        If IsDBNull(cmd1.ExecuteScalar) Then
            Image3.ImageUrl = "profilepics/blank-profile-hi.png"
        Else
            q = cmd1.ExecuteScalar
            Image3.ImageUrl = q
        End If

        If IsDBNull(cmd2.ExecuteScalar) Then
            Image2.ImageUrl = "coverpics/111.jpg"
        Else
            q1 = cmd2.ExecuteScalar
            Image2.ImageUrl = q1
        End If

        con.Close()
        Label1.Text = t1 & " " & t2
        Label2.Text = DateTime.Now.Year - l1

    End Sub

    Protected Sub ImageButton7_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton7.Click

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Friends" Then
            Response.Write("You Already are Friends With This Person")
        Else

            sql1 = "select userid from Users where email='" & Session("email") & "'"
            sql2 = "select userid from Users where email='" & Session("xyz") & "'"
            cmd1 = New SqlCommand(sql1, con)
            cmd2 = New SqlCommand(sql2, con)
            con.Open()
            Dim x As Integer = cmd1.ExecuteScalar
            Dim y As Integer = cmd2.ExecuteScalar

            con.Close()




            sql1 = "insert into FriendReq(senduserid1,acceptuserid2,date_add) values(" & x & "," & y & ",'" & DateTime.Now & "')"
            cmd1 = New SqlCommand(sql1, con)
            con.Open()
            x = cmd1.ExecuteNonQuery

            con.Close()
            If x > 0 Then
                Button1.Text = "Friend Request Sent"
                Session("reqstatus") = Button1.Text
                Session("detectemail") = Session("email")
            End If

        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Follow" Then


            Button2.Text = "Following"
        Else
            Button2.Text = "Follow"
        End If

    End Sub
End Class
