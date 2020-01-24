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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

   

    Protected Sub signupbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles signupbtn.Click
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
            Response.Write("<script>alert('Login to your Account')</script>")
            Panel2.Visible = False

            Panel1.Visible = True

        End If
    End Sub

    Protected Sub loginbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        If emailtxt.Text = "" Or passgtxt.Text = "" Then
            MsgBox("Insufficient Input")
        Else
            Dim t1, x1, y As String
            Dim t2 As String
            t1 = ViewState(emailtxt.Text)
            t2 = ViewState(passgtxt.Text)
            Session("email") = emailtxt.Text

            sql = "select email from gmail where email='" & emailtxt.Text & "' and password='" & passgtxt.Text & "'"
            sql1 = "select password from gmail where email='" & emailtxt.Text & "' and password='" & passgtxt.Text & "'"



            cmd = New SqlCommand("select email from gmail where email='" & emailtxt.Text & "' and password='" & passgtxt.Text & "'", con)
            cmd1 = New SqlCommand("select password from gmail where email='" & emailtxt.Text & "' and password='" & passgtxt.Text & "'", con)
            con.Open()
          

            x1 = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar
            con.Close()

            If x1 = t1 And y = t2 Then
                Response.Write("<script>alert('Record Found')</script>")
                Response.Write("<script>alert('Redirecting you to the main page')</script>")
                sql = "insert into gmailLogin(email,password) values ('" & emailtxt.Text & "','" & passgtxt.Text & "')"
                cmd = New SqlCommand(sql, con)
                con.Open()
                x = cmd.ExecuteNonQuery
                con.Close()
                If x > 0 Then
                    Response.Write("<script>alert('Login Granted')</script>")
                    Response.Redirect("homepage.aspx")
                Else
                    MsgBox("Failure")
                End If

                
            Else
                Response.Write("<script>alert('User Not Found')</script>")
            End If
        End If
    End Sub

    Protected Sub resetbtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles resetbtn.Click
        emailtxt.Text = String.Empty
        passgtxt.Text = String.Empty
    End Sub

    Protected Sub emltxt_TextChanged(sender As Object, e As EventArgs) Handles emltxt.TextChanged
        If emltxt.Text <> Session("eml") Then
            ' emltxt.Focus()

            Response.Write("<script>alert('Different Emails Entered')</script>")
            MsgBox("Please Enter the same email you entered on Login Page")
        Else
            Dim f = 1

        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
