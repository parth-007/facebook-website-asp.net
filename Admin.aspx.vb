Imports System.Data
Imports System.Data.SqlClient

Partial Class Admin
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
    Protected Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        txtPass.Text = ""
        txtUser.Text = ""

    End Sub

    Protected Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If txtUser.Text = "admin" And txtPass.Text = "admin" Then
            Response.Write("<script>alert('Login Granted')</script>")
            Response.Redirect("data.aspx")
        Else
            Response.Write("<script>alert('Access Denied')</script>")
        End If
    End Sub
End Class