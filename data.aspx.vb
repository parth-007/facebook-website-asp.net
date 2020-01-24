Imports System.Data.SqlClient
Imports System.Data

Partial Class data
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet
    Dim x As Integer
    Dim i As Integer
    Dim sql As String

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            fillgrid()

        End If
    End Sub
    Public Sub fillgrid()
        sql = "select u.userid,u.fname,u.surname,u.phone,u.email,u.password,u.day,m.name,u.year,u.gender,u.pic,u.coverpic,s.sname,c.cname,sch.scname,col.colname from Users u,Months m,State s,City c,School sch,College col where u.month=m.id and u.stateid=s.stateid and u.cityid=c.cityid and u.schoolid=sch.schoolid and u.colid=col.colid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)

        con.Close()
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()

    End Sub
End Class
