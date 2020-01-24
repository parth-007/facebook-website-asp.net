Imports System.Data
Imports System.Data.SqlClient

Partial Class aboutde
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand


    Dim ds As New DataSet
    Dim x As Integer
    Dim i As Integer
    Dim sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12, sql13 As String
    Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmd10, cmd11, cmd12, cmd13 As New SqlCommand

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then


            sql1 = "select userid from Users where email='" & Session("email") & "'"
            sql2 = "select fname from Users where email='" & Session("email") & "'"
            sql3 = "select surname from Users where email='" & Session("email") & "'"
            sql4 = "select phone from Users where email='" & Session("email") & "'"
            sql5 = "select email from Users where email='" & Session("email") & "'"
            sql6 = "select day from Users where email='" & Session("email") & "'"
            sql7 = "select name from Months where Id in(select month from Users where email='" & Session("email") & "')"
            sql8 = "select year from Users where email='" & Session("email") & "'"
            sql9 = "select gender from Users where email='" & Session("email") & "'"
            sql10 = "select sname from State where stateid in(select stateid from Users where email='" & Session("email") & "')"
            sql11 = "select cname from City where cityid in (select cityid from Users where email='" & Session("email") & "')"
            sql12 = "select scname from School where schoolid in(select schoolid from Users where email='" & Session("email") & "')"
            sql13 = "select colname from College where colid in(select colid from Users where email='" & Session("email") & "')"

            cmd1 = New SqlCommand(sql1, con)
            cmd2 = New SqlCommand(sql2, con)
            cmd3 = New SqlCommand(sql3, con)
            cmd4 = New SqlCommand(sql4, con)
            cmd5 = New SqlCommand(sql5, con)
            cmd6 = New SqlCommand(sql6, con)
            cmd7 = New SqlCommand(sql7, con)
            cmd8 = New SqlCommand(sql8, con)
            cmd9 = New SqlCommand(sql9, con)
            cmd10 = New SqlCommand(sql10, con)
            cmd11 = New SqlCommand(sql11, con)
            cmd12 = New SqlCommand(sql12, con)
            cmd13 = New SqlCommand(sql13, con)

            con.Open()
            Label12.Text = cmd1.ExecuteScalar
            Label1.Text = cmd2.ExecuteScalar
            Label2.Text = cmd3.ExecuteScalar
            Label3.Text = cmd4.ExecuteScalar
            Label4.Text = cmd5.ExecuteScalar
            Label5.Text = cmd6.ExecuteScalar & cmd7.ExecuteScalar & cmd8.ExecuteScalar
            Label6.Text = cmd9.ExecuteScalar
            Label7.Text = cmd10.ExecuteScalar
            Label8.Text = cmd11.ExecuteScalar
            Label9.Text = cmd12.ExecuteScalar
            Label13.Text = cmd13.ExecuteScalar

            con.Close()


        End If
    End Sub
End Class
