Imports System.Data
Imports System.Data.SqlClient
Partial Class gmail
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
    Protected Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim gen As String
        If rb1.Checked = True Then
            gen = rb1.Text
        Else
            gen = rb2.Text

        End If
        sql = "insert into Gmail(name,surname,email,password,phone,country,gender) values('" & nametxt.Text & "','" & surnametxt.Text & "',' " & emltxt.Text & "','" & passtxt2.Text & "', " & phone.Text & ",' " & country.SelectedItem.Text & "',' " & gen & "' )"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim x As Integer
        x = cmd.ExecuteNonQuery

        con.Close()

        If x > 0 Then
            Response.Write("<script>alert('Record inserted')</script>")
            Response.Write("<script>alert('signup to Facebook Account')</script>")
            Panel2.Visible = True



        End If
    End Sub
End Class
