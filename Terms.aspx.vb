Imports System.Data
Imports System.Data.SqlClient

Partial Class Terms
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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

   
    Protected Sub signupBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles signupBtn.Click

    End Sub

    Protected Sub loginBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        If emlText.Text = "" Or passTxt.Text = "" Then
            MsgBox("Insufficient Input")
        Else
            Dim t1, x, y As String
            Dim t2 As String
            t1 = emlText.Text
            t2 = passTxt.Text

            sql1 = "select email from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"
            sql1 = "select password from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"



            cmd = New SqlCommand(sql, con)
            cmd1 = New SqlCommand(sql1, con)
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "select email from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"
            cmd1.CommandText = "select password from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"
            x = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar
            con.Close()

            If x = t1 And y = t2 Then
                MsgBox("Found")
            Else
                MsgBox("Account Not Found")
            End If
        End If
    End Sub
End Class
