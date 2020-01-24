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


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("flag") = "" Then
            Response.Redirect("Default.aspx")

        End If
        Dim ch1 As String
        ch1 = Session("email")
        sql1 = "select pic from Users where email='" & ch1 & "'"
        sql2 = "select coverpic from Users where email='" & ch1 & "'"


        sql3 = "select fname from Users where email='" & ch1 & "'"
        sql4 = "select surname from Users where email='" & ch1 & "'"

        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)
        cmd3 = New SqlCommand(sql3, con)
        cmd4 = New SqlCommand(sql4, con)

        con.Open()
        Dim q As String
        Dim q1 As String
        Dim t1 As String
        Dim t2 As String

        t1 = cmd3.ExecuteScalar
        t2 = cmd4.ExecuteScalar

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

    End Sub

    Protected Sub ImageButton8_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton8.Click

    End Sub
End Class
