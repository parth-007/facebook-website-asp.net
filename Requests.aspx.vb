Imports System.Data.SqlClient
Imports System.Data

Partial Class requests
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
        Dim str1 As String
        Dim x, y As String

        If Not IsPostBack Then
            str1 = Session("detectemail")
            sql1 = "select fname from Users where email='" & str1 & "'"
            sql2 = "select surname from Users where email='" & str1 & "'"

            cmd1 = New SqlCommand(sql1, con)
            cmd2 = New SqlCommand(sql2, con)
            cmd2 = New SqlCommand(sql2, con)

            con.Open()
            x = cmd1.ExecuteScalar
            y = cmd2.ExecuteScalar
           

           
            con.Close()

            LinkButton6.Text = x & " " & y

        End If
        If Session("cntme") = 0 Then
            Response.Write("You Have No Friend Requests")
        Else
            Response.Write("Yes")

        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rchange As String = "yes"
        sql1 = "select userid from Users where email='" & Session("email") & "'"
        sql2 = "select userid from Users where email='" & Session("detectemail") & "'"
        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)
        con.Open()
        Dim x As Integer = cmd1.ExecuteScalar
        Dim y As Integer = cmd2.ExecuteScalar

        con.Close()
        Button1.Text = ChrW(&H221A).ToString() & "Friends"
        Label1.Text = "You are Friends with this Person"
        Button2.Visible = False
        sql1 = "update FriendReq set response='" & rchange & "' where acceptuserid2=" & x & " and senduserid1=" & y & ""
        sql4 = "insert into Friends values(" & x & "," & y & ",'" & DateTime.Now & "')"
        cmd1 = New SqlCommand(sql1, con)
        cmd4 = New SqlCommand(sql4, con)
        con.Open()
        x = cmd1.ExecuteNonQuery
        Dim d As Integer
        d = cmd4.ExecuteNonQuery

        con.Close()




    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Write("Request Rejected")
        pnl1.Visible = False
        sql1 = "select userid from Users where email='" & Session("email") & "'"
        sql2 = "select userid from Users where email='" & Session("xyz") & "'"
        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)
        con.Open()
        Dim x As Integer = cmd1.ExecuteScalar
        Dim y As Integer = cmd2.ExecuteScalar

        con.Close()

        sql1 = "delete * from FriendReq where acceptuserid2=" & x & " and senduserid1=" & y & ""
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        Dim xp As Integer
        xp = cmd1.ExecuteNonQuery

        con.Close()


    End Sub

    Protected Sub LinkButton6_Click(sender As Object, e As EventArgs) Handles LinkButton6.Click
        Session("xyz") = Session("detectemail")
        Response.Redirect("OtherProfile.aspx")
    End Sub
End Class
