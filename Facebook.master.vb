Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Services

Imports System.Configuration
Imports System.Web.Script.Services
Partial Class Facebook

    Inherits System.Web.UI.MasterPage
    Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim x As Integer
    Dim sql As String
    Dim sql1 As String
    Dim cmd1 As New SqlCommand
    Dim cmd2 As New SqlCommand
    Dim sql2 As String

    Public Property linkbtnmsg As String
        Get
            Return mymain.Text
        End Get
        Set(ByVal value As String)
            mymain.Text = value
        End Set
    End Property
    'Protected Sub OnPageIndexChanging(sender As Object, e As GridViewPageEventArgs)
    '    GridView1.PageIndex = e.NewPageIndex
    '    Me.datafill()
    '    Page.ClientScript.RegisterStartupScript(Me.GetType(), "Popup", "ShowPopup();", True)
    'End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("flag") = "" Then
            Response.Redirect("Default.aspx")
        End If
        Dim id As Integer
        Dim res As String = "no"
        sql = "select userid from Users where email='" & Session("email") & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        id = cmd.ExecuteScalar

        con.Close()

        Dim r1 As Integer
        sql = "select count(*) from FriendReq where acceptuserid2=" & id & " and response='" & res & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        r1 = cmd.ExecuteScalar
        Session("r1") = r1

        con.Close()

        'fr.Text = Session("r1")





        Dim s1 As String
        Dim x, y As String
        Dim z As String

        s1 = Session("email")
        sql = "select fname from Users where email='" & s1 & "'"
        sql1 = "select surname from Users where email='" & s1 & "'"
        sql2 = "select pic from Users where email='" & s1 & "'"
        cmd = New SqlCommand("select fname from Users where email='" & s1 & "'", con)
        cmd1 = New SqlCommand("select surname from Users where email='" & s1 & "'", con)
        cmd2 = New SqlCommand(sql2, con)

        con.Open()
        x = cmd.ExecuteScalar
        y = cmd1.ExecuteScalar
        If Not IsDBNull(cmd2.ExecuteScalar) Then
            z = cmd2.ExecuteScalar

            Image1.ImageUrl = z
        Else

        End If

        con.Close()

        mymain.Text = x & " " & y


    End Sub

    Protected Sub homelink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles homelink.Click
        Response.Redirect("homepage.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

    End Sub
    'Public Sub datafill()
    '    Dim s As String
    '    s = ViewState("Search.Text")

    '    sql = "select fname from Users where fname like 's%'"
    '    Dim dt As New DataTable
    '    adp = New SqlDataAdapter(sql, con)
    '    con.Open()
    '    adp.Fill(dt)
    '    con.Close()
    '    GridView1.DataSource = dt
    '    GridView1.DataBind()


    'End Sub



    Protected Sub mymain_Click(sender As Object, e As EventArgs) Handles mymain.Click

    End Sub
    <WebMethod()> _
    Public Shared Function GetAutoCompleteData(ByVal username As String) As List(Of String)
        Dim result As New List(Of String)()
        Dim con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("select fname,surname from Users where fname LIKE '%'+@SearchText+'%'", con)
        con.Open()
        cmd.Parameters.AddWithValue("@SearchText", username)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            result.Add(String.Format("{0}/{1}", dr("fname"), dr("surname")))
        End While
        Return result

    End Function
    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Session("email") = Nothing
        ' Session("reqstatus") = Nothing
        Session("flag") = Nothing
        Session("xyz") = Nothing

        Server.Transfer("Default.aspx")
        '   Page.ClientScript.RegisterOnSubmitStatement(Type.GetType(Page), "closePage", "window.onunload = CloseWindow();")


    End Sub


   
   

    Protected Sub LinkButton4_Click(sender As Object, e As EventArgs) Handles LinkButton4.Click
        Response.Redirect("onlyus.aspx")
    End Sub
End Class

