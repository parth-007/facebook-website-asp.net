Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Partial Class password
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd1 As New SqlCommand
    Dim cmd2 As New SqlCommand
    Dim x As Integer
    Dim sql2 As String

    Dim sql1 As String

    Protected Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged

        Panel1.Visible = True

        Panel2.Visible = False


    End Sub

    Protected Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged

        Panel2.Visible = True

        Panel1.Visible = False


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mymsg As MailMessage = New MailMessage
        mymsg.Subject = "Recovery"
        mymsg.Body = "Hello World,Planet Wrox"
        mymsg.From = New MailAddress("parthmangukiya20@gmail.com", "parthmangukiya20@gmail.com")
        mymsg.To.Add(New MailAddress("parthmangukiya20@gmail.com", TextBox1.Text))

        Dim mysmptp As SmtpClient = New SmtpClient
        Dim x As Integer

        mysmptp.Send(mymsg)


        'Dim str1 As String
        'Dim t1 As String
        'Dim t2 As String

        'str1 = TextBox1.Text

        'sql1 = "select fname from Users where email='" & str1 & "'"
        'sql2 = "select surname from Users where email='" & str1 & "'"
        'cmd2 = New SqlCommand(sql2, con)

        'cmd1 = New SqlCommand(sql1, con)
        'con.Open()
        't1 = cmd1.ExecuteScalar
        't2 = cmd2.ExecuteScalar

        'con.Close()

        'If t1 = "" Or t2 = "" Then
        '    Response.Write("<script>alert('Sorry,You Have Entered Email which is not Assigned to any account')</script>")
        'Else
        '    'Response.Write("<script>alert('" & t1 & "' & '" & t2 & "')</script>")

        '    Label1.Visible = True
        '    Label1.Text = t1 & " " & t2

        'End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("flag") = "" Then
            Response.Redirect("Default.aspx")

        End If
        Panel2.Visible = True
        Panel1.Visible = True
        Label1.Visible = False

        upd1.Visible = False
        passphone.Visible = False
        Label3.Visible = False

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str1 = TextBox1.Text

        sql1 = "update Users set password='" & passtxt.Text & "' where email='" & str1 & "'"
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        Dim a As Integer
        a = cmd1.ExecuteNonQuery
        con.Close()

        If a > 0 Then
            Response.Write("<script>alert('Password Updated.. Redirecting you to the Login Page')</script>")
            Server.Transfer("Default.aspx")
        End If
    End Sub
    
    Protected Sub phoneVerify_Click(sender As Object, e As EventArgs) Handles phoneVerify.Click
        Dim str2 As String
        str2 = txtPhone.Text
        Dim t1, t2 As String

        sql1 = "select fname from Users where phone=" & str2 & ""
        sql2 = "select surname from Users where phone=" & str2 & ""
        cmd2 = New SqlCommand(sql2, con)

        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        t1 = cmd1.ExecuteScalar
        t2 = cmd2.ExecuteScalar

        con.Close()

        If t1 = "" Or t2 = "" Then
            Response.Write("<script>alert('Sorry,You Have Entered Email which is not Assigned to any account')</script>")
        Else
            'Response.Write("<script>alert('" & t1 & "' & '" & t2 & "')</script>")

            Label2.Visible = True
            Label2.Text = t1 & " " & t2
            tb3.Text = GetRandomString(10)



        End If

    End Sub
    
    Protected Sub upd1_Click(sender As Object, e As EventArgs) Handles upd1.Click
        Dim sss As String
        sss = txtPhone.Text

        sql2 = "update Users set password='" & passphone.Text & "' where phone=" & sss & ""
        cmd2 = New SqlCommand(sql2, con)
        con.Open()
        Dim dd As Integer
        dd = cmd2.ExecuteNonQuery
        con.Close()

        If dd > 0 Then
            Response.Write("<script>alert('Password Updated. Redirecting you to the main page')</script>")
            Server.Transfer("Default.aspx")

        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If anstxt.Text = tb3.Text Then
            Response.Write("<script>alert('Captcha Entered is right. Now Set New Password')</script>")
            Label3.Visible = True

            passphone.Visible = True
            upd1.Visible = True
        Else
            Label3.Visible = False

            passphone.Visible = False
            upd1.Visible = False
        End If
    End Sub
    Public Function GetRandomString(ByVal iLength As Integer) As String
        Dim sResult As String = ""
        Dim rdm As New Random()

        For i As Integer = 1 To iLength
            sResult &= ChrW(rdm.Next(32, 126))
        Next

        Return sResult
    End Function
    'Dim random As Random = New Random


    'Private Shared rand As Random = New Random()
    'Public Shared Function RandomString(ByVal length As Integer) As String
    '    Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
    'Return New String(Enumerable.Repeat(chars, length).Select(s=>s(random.Next(s.Length))).ToArray())
    'End Function

    'Public Sub alpha()
    '    Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    '    Dim schar(10) As String
    '    Dim fstr(10) As String
    '    Dim rnd As Random
    '    For i = 0 To schar.Length
    '        schar(i) = chars(rnd.Next(chars.Length))
    '        fstr(i) = schar(i)

    '    Next

    '    tb3.Text = fstr.ToString



    'End Sub

End Class
