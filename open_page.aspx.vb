Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Partial Class open_page
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand


    Dim ds As New DataSet
    Dim x As Integer
    Dim i As Integer
    Dim sql1, sql2, sql3, sql4, sql5 As String
    Dim cmd1, cmd2, cmd3, cmd4, cmd5 As New SqlCommand
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("takeme") = "Brand Or Product" Then
                Label1.Text = Session("takeme")
            ElseIf Session("takeme") = "Company, Organization or Institution" Then
                Label1.Text = Session("takeme")
            ElseIf Session("takeme") = "Local Business or Place" Then
                Label1.Text = Session("takeme")
            ElseIf Session("takeme") = "Artist, Band or Public" Then
                Label1.Text = Session("takeme")
            ElseIf Session("takeme") = "Entertainment" Then
                Label1.Text = Session("takeme")
            ElseIf Session("takeme") = "Cause or Community" Then
                Label1.Text = Session("takeme")
            End If
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FileUpload1.HasFile Then
            Dim m As String
            Dim str As String
            m = FileUpload1.FileName
            Session("g1") = FileUpload1.FileName
            str = Server.MapPath("~/pagepics/") + FileUpload1.FileName
            FileUpload1.SaveAs(str)
            'Image1.ImageUrl(Server.MapPath("~/profilepics/") + m)
            Image2.Visible = True
            Image2.ImageUrl = "pagepics/" + FileUpload1.FileName
            Dim temp As String
            temp = "pagepics/" + FileUpload1.FileName
        Else
            Response.Write("<script>alert('No Image Selected')</script>")
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Write("<script>alert('Picture Saved');</script>")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim temp3 As String

        temp3 = "pagepics/" + Session("g1")
        sql1 = "insert into Page(type,pname,email,password,date_create,picture) values('" & Session("takeme") & "','" & pagename.Text & "','" & emailtext.Text & "','" & passtext.Text & "','" & DateTime.Now & "','" & temp3 & "')"
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        x = cmd1.ExecuteNonQuery

        con.Close()
        If x > 0 Then
            Response.Write("Page Saved")
        End If
    End Sub
End Class
