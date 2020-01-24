Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
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


        If Not IsPostBack Then
            dayCombo.Items.Add("Day")
            monthCombo.Items.Add("Month")
            yearCombo.Items.Add("Year")

            Dim i As Integer
            For i = 1 To 31
                dayCombo.Items.Add(i)
            Next
            For j = 2017 To 1905 Step -1
                yearCombo.Items.Add(j)
            Next

            fillmonths()
            dayCombo.SelectedValue = 5
            monthCombo.SelectedValue = "August"
            yearCombo.SelectedValue = 1998
        End If

        '    fnameTxt.Attributes.Add("onBlur", isitvalid()) = "isitValid(" & fnameTxt.ClientID & ")"
        fnameTxt.Attributes("onBlur") = "isNameEmpty(" & fnameTxt.ClientID & ")"
        surnameTxt.Attributes("onBlur") = "isSurnameEmpty(" & surnameTxt.ClientID & ")"
        mobTxt.Attributes("onBlur") = "isPhoneEmpty(" & mobTxt.ClientID & ")"
        emTxt.Attributes("onBlur") = "isEmailEmpty(" & emTxt.ClientID & ")"
        newpassTxt.Attributes("onBlur") = "isPasswordEmpty(" & newpassTxt.ClientID & ")"
    End Sub

    Protected Sub fnameTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fnameTxt.TextChanged

    End Sub

    Protected Sub surnameTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles surnameTxt.TextChanged
       
    End Sub
    Public Sub fillmonths()
        sql = "select * from Months"
        cmd = New SqlCommand(sql, con)
        adp.SelectCommand = cmd

        con.Open()
        adp.Fill(ds)
        con.Close()

        monthCombo.DataTextField = ds.Tables(0).Columns("name").ToString
        monthCombo.DataValueField = ds.Tables(0).Columns("id").ToString
        monthCombo.DataSource = ds.Tables(0)

        monthCombo.SelectedIndex = 6
        monthCombo.DataBind()
        '    monthCombo.Text = "Month"

    End Sub
    Protected Sub newpassTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles newpassTxt.TextChanged

    End Sub

    Protected Sub accCreateBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles accCreateBtn.Click
        Dim flag As Integer
        Session("ems") = emTxt.Text
        sql = "select userid from Users where email='" & Session("ems") & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteScalar
        con.Close()

        If x <> 0 Then
            Response.Write("Email has Been Used By someone")
            emlText.Focus()
        Else
            sql = "select id from Gmail where email='" & Session("ems") & "'"
            cmd = New SqlCommand(sql, con)
            con.Open()
            x = cmd.ExecuteScalar
            con.Close()

            If x = 0 Then
                Dim gen As String
                If MaleRadio.Checked Then
                    gen = "Male"
                ElseIf femaleRadio.Checked Then
                    gen = "Female"

                End If

                sql = "insert into Users(fname,surname,phone,email,password,day,month,year,gender) values ('" & fnameTxt.Text & "','" & surnameTxt.Text & "'," & mobTxt.Text & ",'" & emTxt.Text & "','" & newpassTxt.Text & "'," & dayCombo.SelectedItem.Text & "," & Val(monthCombo.SelectedValue) & "," & yearCombo.SelectedItem.Text & ",'" & gen & "')"
                cmd = New SqlCommand(sql, con)
                con.Open()

                x = cmd.ExecuteNonQuery

                con.Close()
                Response.Write("Account Created.Please Log in to Your Account")
                'Response.Redirect("homepage.aspx")
                'Session("email") = emTxt.Text
            Else
                MsgBox("Please Create An Account On Gmail..Then Sign Up for Facebook")
                Response.Redirect("gmail.aspx")
            End If
            con.Close()
            'MsgBox(x)

          
        End If



        'Dim str1 As String
        'str1 = emTxt.Text

        'Dim dt As New DataTable
        'sql = "select email from gmail"
        'cmd = New SqlCommand(sql, con)
        'adp.SelectCommand = cmd

        'con.Open()
        'adp.Fill(dt)
        'con.Close()
        'Dim ch As String
        'Dim i As Integer
        'Dim currow As Integer
        'For i = 0 To dt.Rows.Count
        '    If dt.Rows(0).cells(0).tostring Then


        '    End If


        'Next



        'If x > 0 Then
        '    Response.Write("<script>alert('Record inserted')</script>")
        '    Session("eml") = emTxt.Text

        '    ' i have one idea that i can stop the re entering or reinserting of dupliacate record by redirecting the user to the another page .. so
        '    ' only first time record will get enter not second
        '    Response.Write("<script>alert('Yow will be redirected to the Gmail page for the verification of your email')</script>")
        '    Response.Redirect("gmail.aspx")

        '    'response.redirect("terms.aspx")

        'End If

    End Sub
    Public Sub check()

    End Sub
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click

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

           

            cmd = New SqlCommand("select email from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'", con)
            cmd1 = New SqlCommand("select password from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'", con)
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "select email from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"
            cmd1.CommandText = "select password from Users where email='" & emlText.Text & "' and password='" & passTxt.Text & "'"
            x = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar
            con.Close()

            If x = t1 And y = t2 Then
                Session("email") = emlText.Text

                sql = "insert into Login (email,password,date) values (' " & emlText.Text & " ',' " & passTxt.Text & "',' " & DateTime.Now & "')"
                cmd = New SqlCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Session("flag") = "done"
                Response.Write("<script language='javascript'>Alert('Record Found')</script>")
                Response.Redirect("hpage.aspx")

            Else
                Response.Write("<script>alert('Not Found')</script>")
                '      MsgBox("y")
            End If
        End If

    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click

    End Sub

    'Protected Sub emTxt_TextChanged(sender As Object, e As EventArgs) Handles emTxt.TextChanged
    '    Dim dt As New DataTable

    '    Session("em1") = emTxt.Text
    '    sql = "select count(*) from Users where email='" & Session("em1") & "'"
    '    cmd = New SqlCommand(sql, con)
    '    adp = New SqlDataAdapter(sql, con)
    '    con.Open()
    '    x = cmd.ExecuteScalar
    '    con.Close()

    '    If x = 0 Then
    '        sql = "select count(*) from Gmail where email='" & Session("em1") & "'"
    '        con.Open()
    '        x = cmd.ExecuteScalar
    '        con.Close()
    '        If x = 0 Then
    '            MsgBox("You Entered invalid email")
    '            MsgBox("You Are Being redirected at Gmail account Creation")
    '            Response.Redirect("gmail.aspx")
    '        Else
    '            Response.Write("<script>alert('Yes...Looks Nice Email')</script>")
    '        End If

    '    Else
    '        Response.Write("<script>alert('This is a used Email.. Please Enter a New one')</script>")
    '        emTxt.Focus()
    '    End If

    'End Sub
End Class
