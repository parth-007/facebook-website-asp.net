Imports System.Data
Imports System.Data.SqlClient

Partial Class profileset
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim sql As String
    Dim x As Integer
    Dim i As Integer
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Session("rr") = "Now Your Profile Looks Great"
        Dim ch1 As String
        Dim t As Integer

        ch1 = Session("email")
        sql = "select year from Users where email='" & ch1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        t = cmd.ExecuteScalar

        con.Close()
        If t = Nothing Then
            Response.Write("<script>alert('You have not specified your age');</script>")
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Label3.Visible = True
            Label4.Visible = True

        Else
            Dim todays As Integer
            todays = DateTime.Now.Year
            t = todays - t
            Label1.Text = t
            Panel1.Visible = True
            If t < 5 Then
                Panel2.Visible = False
                Panel3.Visible = False
                Label3.Visible = False
                Label4.Visible = False

            ElseIf t >= 5 And t <= 13 Then
                Panel3.Visible = False
                Label4.Visible = False
                Label3.Visible = True

                Panel2.Visible = True
            Else
                Panel2.Visible = True
                Panel3.Visible = True
                Label3.Visible = True
                Label4.Visible = True

            End If

            If Not IsPostBack Then
                fillstate()

            End If
        End If

    End Sub
    Public Sub fillstate()
        sql = "select  * from State"
        cmd = New SqlCommand(sql, con)
        adp.SelectCommand = cmd
        con.Open()
        adp.Fill(ds)
        con.Close()
        StateCombo.DataTextField = ds.Tables(0).Columns("sname").ToString
        StateCombo.DataValueField = ds.Tables(0).Columns("stateid").ToString


        StateCombo.DataSource = ds.Tables(0)

        StateCombo.DataBind()
        StateCombo.Items.Insert(0, "Select State")

    End Sub

    Protected Sub StateCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateCombo.SelectedIndexChanged
        If StateCombo.SelectedValue.ToString <> "" Then
            Dim x = Convert.ToInt32(StateCombo.SelectedValue)
            fillcities(x)
        End If
    End Sub
    Public Sub fillcities(ByVal n As Integer)
        ds.Tables.Clear()

        sql = "select * from City where stateid=" & n & ""
        adp = New SqlDataAdapter(sql, con)

        con.Open()
        adp.Fill(ds)
        con.Close()

        cityCombo.DataTextField = ds.Tables(0).Columns("cname").ToString
        cityCombo.DataValueField = ds.Tables(0).Columns("cityid").ToString
        cityCombo.DataSource = ds.Tables(0)

        cityCombo.DataBind()
        cityCombo.Items.Insert(0, "Select City")
    End Sub

    Protected Sub cityCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cityCombo.SelectedIndexChanged
        Dim s1 As Integer
        If cityCombo.SelectedValue.ToString <> "" Then
            s1 = Convert.ToInt32(cityCombo.SelectedValue)
            fillschool(s1)
            fillcollege(s1)
        End If
    End Sub
    Public Sub fillcollege(ByVal s1 As Integer)
        ds.Tables.Clear()

        sql = "select * from College where cityid=" & s1 & ""
        adp = New SqlDataAdapter(sql, con)

        con.Open()
        adp.Fill(ds)
        con.Close()

        collegeCombo.DataTextField = ds.Tables(0).Columns("colname").ToString
        collegeCombo.DataValueField = ds.Tables(0).Columns("colid").ToString
        collegeCombo.DataSource = ds.Tables(0)

        collegeCombo.DataBind()
        collegeCombo.Items.Insert(0, "Select College")
    End Sub
    Public Sub fillschool(ByVal s1 As Integer)
        ds.Tables.Clear()

        sql = "select * from School where cityid=" & s1 & ""
        adp = New SqlDataAdapter(sql, con)

        con.Open()
        adp.Fill(ds)
        con.Close()

        schoolCombo.DataTextField = ds.Tables(0).Columns("scname").ToString
        schoolCombo.DataValueField = ds.Tables(0).Columns("schoolid").ToString
        schoolCombo.DataSource = ds.Tables(0)

        schoolCombo.DataBind()
        schoolCombo.Items.Insert(0, "Select School")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ch1 As String
        ch1 = Session("email")

        sql = "update Users set stateid=" & Val(StateCombo.SelectedValue) & ", cityid=" & Val(cityCombo.SelectedValue) & " , schoolid=" & Val(schoolCombo.SelectedValue) & ", colid=" & Val(collegeCombo.SelectedValue) & " where email='" & ch1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery
        con.Close()

        If x > 0 Then
            Response.Write("<script>alert('Information Updated')</script>")
        Else
            MsgBox("Wrong Information Added.. Server is Down")
        End If
    End Sub
End Class
