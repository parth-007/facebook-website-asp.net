Imports System.Data
Imports System.Data.SqlClient

Partial Class Page
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
    
    Dim cmd2 As New SqlCommand
    Dim sql2 As String
    Dim cmd3, cmd4, cmd5 As New SqlCommand
    Dim sql3, sql5, sql4 As String

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

    Protected Sub signupBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles signupBtn.Click

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub brandorproduct_Click(sender As Object, e As EventArgs) Handles brandorproduct.Click
        Session("takeme") = "Brand Or Product"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub comanyorganizationorinstitution_Click(sender As Object, e As EventArgs) Handles comanyorganizationorinstitution.Click
        Session("takeme") = "Company, Organization or Institution"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub localbusinessorplace_Click(sender As Object, e As EventArgs) Handles localbusinessorplace.Click
        Session("takeme") = "Local Business or Place"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub artistbandorpublic_Click(sender As Object, e As EventArgs) Handles artistbandorpublic.Click
        Session("takeme") = "Artist, Band or Public"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub entertainment_Click(sender As Object, e As EventArgs) Handles entertainment.Click
        Session("takeme") = "Entertainment"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub causeorcommunity_Click(sender As Object, e As EventArgs) Handles causeorcommunity.Click
        Session("takeme") = "Cause or Community"
        Response.Redirect("open_page.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As String
        Dim t1, t2 As String
        x = TextBox1.Text
        y = TextBox2.Text

        sql1 = "select email from Page where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        sql2 = "select password from Page where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        sql3 = "select pname from Page where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        sql4 = "select date_create from Page where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        sql5 = "select picture from Page where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        cmd1 = New SqlCommand(sql1, con)
        cmd2 = New SqlCommand(sql2, con)
        cmd3 = New SqlCommand(sql3, con)
        cmd4 = New SqlCommand(sql4, con)
        cmd5 = New SqlCommand(sql5, con)
        con.Open()
        t1 = cmd1.ExecuteScalar
        t2 = cmd2.ExecuteScalar

        con.Close()

        If t1 = x And t2 = y Then
            Response.Write("<script>alert('Login Successful')</script>")
            con.Open()

            Session("em5") = TextBox1.Text
            Session("pic5") = cmd5.ExecuteScalar
            Session("name5") = cmd3.ExecuteScalar
            Session("dc5") = cmd4.ExecuteScalar

            con.Close()

            Response.Redirect("MyPage.aspx")
        Else
            Response.Write("<script>alert('Access Denied')</script>")
        End If
    End Sub
End Class
