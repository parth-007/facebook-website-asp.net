Imports System.Data
Imports System.Data.SqlClient

Partial Class Friends
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

        If Not IsPostBack Then
            sql1 = "select userid from Users where email='" & Session("email") & "'"
            sql2 = "select userid from Users where email='" & Session("xyz") & "'"
            cmd1 = New SqlCommand(sql1, con)
            cmd2 = New SqlCommand(sql2, con)
            con.Open()
            Dim x As Integer = cmd1.ExecuteScalar
            Dim y As Integer = cmd2.ExecuteScalar

            con.Close()

            sql1 = "select count(*) from Friends where id1=" & x & " or id2=" & x & ""
            cmd1 = New SqlCommand(sql1, con)
            con.Open()
            If IsDBNull(cmd1.ExecuteScalar) Then
                Label1.Text = 0

            Else
                Label1.Text = cmd1.ExecuteScalar
            End If

            con.Close()

        End If
    End Sub
End Class
