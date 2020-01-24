Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Partial Class settings

    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand


    Dim ds As New DataSet
    Dim x As Integer
    Dim i As Integer
    Dim sql1, sql2, sql3, sql4, sql5 As String
    Dim cmd1, cmd2, cmd3, cmd4, cmd5 As New SqlCommand

    Protected Sub rstNamee_Click(sender As Object, e As EventArgs) Handles rstNamee.Click
        nameTxt.Enabled = True

        surTxt.Text = String.Empty

    End Sub

    Protected Sub rstEmail_Click(sender As Object, e As EventArgs) Handles rstEmail.Click
        emailTxt.Enabled = True

        emailTxt.Text = String.Empty

    End Sub

    Protected Sub rstPass_Click(sender As Object, e As EventArgs) Handles rstPass.Click
        passTxt.Enabled = True

        passTxt.Text = String.Empty


    End Sub

    Protected Sub rstPhone_Click(sender As Object, e As EventArgs) Handles rstPhone.Click
        phoneTxt.Enabled = True


        phoneTxt.Text = String.Empty

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim ch1 As String
            ch1 = Session("email")

            sql1 = "select fname from Users where email='" & ch1 & "'"
            sql2 = "select surname from Users where email='" & ch1 & "'"
            sql3 = "select email from Users where email='" & ch1 & "'"
            sql4 = "select password from Users where email='" & ch1 & "'"
            sql5 = "select phone from Users where email='" & ch1 & "'"

            cmd1 = New SqlCommand(sql1, con)
            cmd2 = New SqlCommand(sql2, con)
            cmd3 = New SqlCommand(sql3, con)
            cmd4 = New SqlCommand(sql4, con)
            cmd5 = New SqlCommand(sql5, con)

            con.Open()
            nameTxt.Text = cmd1.ExecuteScalar
            surTxt.Text = cmd2.ExecuteScalar
            emailTxt.Text = cmd3.ExecuteScalar
            passTxt.Text = cmd4.ExecuteScalar
            phoneTxt.Text = cmd5.ExecuteScalar
            con.Close()

        End If
    End Sub

    Protected Sub rstSur_Click(sender As Object, e As EventArgs) Handles rstSur.Click
        surTxt.Enabled = True
        surTxt.Text = String.Empty


    End Sub

    Protected Sub updName_Click(sender As Object, e As EventArgs) Handles updName.Click
        Dim ch1 As String
        ch1 = Session("email")
        sql1 = "update Users set fname='" & nameTxt.Text & "' where email='" & ch1 & "'"




        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        x = cmd1.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Label1.Visible = True

            Label1.Text = "Name Updated Successfully"
        End If
    End Sub

    Protected Sub updSur_Click(sender As Object, e As EventArgs) Handles updSur.Click
        Dim ch1 As String
        ch1 = Session("email")

        sql2 = "update Users set surname='" & surTxt.Text & "' where email='" & ch1 & "'"
        cmd2 = New SqlCommand(sql2, con)
        con.Open()
        x = cmd2.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Label2.Visible = True

            Label2.Text = "Surname Updated Successfully"
        End If
    End Sub

    Protected Sub updEmail_Click(sender As Object, e As EventArgs) Handles updEmail.Click
        Dim ch1 As String
        ch1 = Session("email")
        sql3 = "update Users set email='" & emailTxt.Text & "' where email='" & ch1 & "'"
        cmd3 = New SqlCommand(sql3, con)
        con.Open()
        x = cmd3.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Label3.Visible = True
            Label3.Text = "Email Updated Successfully"
            Session("email") = emailTxt.Text

        End If
    End Sub

    Protected Sub updPass_Click(sender As Object, e As EventArgs) Handles updPass.Click
        Session("psg") = passTxt.Text
        Dim ch1 As String
        ch1 = Session("email")
        sql4 = "update Users set password='" & Session("psg") & "' where email='" & ch1 & "'"
        cmd4 = New SqlCommand(sql4, con)
        con.Open()
        x = cmd4.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Label4.Visible = True
            Label4.Text = "Password Updated Successfully"
        End If
    End Sub

    Protected Sub updPhone_Click(sender As Object, e As EventArgs) Handles updPhone.Click
        Dim ch1 As String
        ch1 = Session("email")
        sql5 = "update Users set phone='" & phoneTxt.Text & "' where email='" & ch1 & "'"
        cmd5 = New SqlCommand(sql5, con)
        con.Open()
        x = cmd5.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Label5.Visible = True
            Label5.Text = "Phone Number Updated Successfully"
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FileUpload1.HasFile Then


            Dim str As String
            Dim m As String = FileUpload1.FileName

            Session("t1") = FileUpload1.FileName
            str = Server.MapPath("~/profilepics/") + FileUpload1.FileName
            FileUpload1.SaveAs(str)
            'Image1.ImageUrl(Server.MapPath("~/profilepics/") + m)
            Image1.Visible = True
            Image1.ImageUrl = "profilepics/" + FileUpload1.FileName
            Dim temp As String
            temp = "profilepics/" + FileUpload1.FileName
        Else
            Response.Write("<script>alert('No Image Selected')</script>")
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch1 As String
        ch1 = Session("email")
        Dim temp3 As String
        temp3 = "profilepics/" + Session("t1")
        sql1 = "update Users set pic='" & temp3 & "' where email='" & ch1 & "'"
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        x = cmd1.ExecuteNonQuery
        con.Close()
        If x > 0 Then
            Response.Write("<script>alert('Profile Picture successfully Updated')</script>")
        End If
    End Sub

    Protected Sub preCover_Click(sender As Object, e As EventArgs) Handles preCover.Click
        If FileUpload2.HasFile Then


            Dim str As String
            Dim m As String = FileUpload2.FileName

            Session("t2") = FileUpload2.FileName

            str = Server.MapPath("~/coverpics/") + FileUpload2.FileName

            FileUpload2.SaveAs(str)

            'Image1.ImageUrl(Server.MapPath("~/profilepics/") + m)
            Image2.Visible = True

            Image2.ImageUrl = "coverpics/" + FileUpload2.FileName
            Dim temp As String
            temp = "coverpics/" + FileUpload2.FileName
        Else
            Response.Write("<script>alert('No Image Selected')</script>")
        End If



    End Sub

    Protected Sub coverPic_Click(sender As Object, e As EventArgs) Handles coverPic.Click
        Dim ch1 As String
        ch1 = Session("email")

        Dim temp3 As String
        temp3 = "coverpics/" + Session("t2")


        sql1 = "update Users set coverpic='" & temp3 & "' where email='" & ch1 & "'"
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        x = cmd1.ExecuteNonQuery

        con.Close()
        If x > 0 Then
            Response.Write("<script>alert('Cover Picture successfully Updated')</script>")
        End If
    End Sub
End Class
