<%@ Page Language="VB" Title="Create Page"%>

<!DOCTYPE html>

<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        If Not IsPostBack Then
            Label2.Text = Session("takeme")
            Label3.Text = Session("em5")
            Label1.Text = Session("name5")
            Image1.ImageUrl = Session("pic5")
            Label4.Text=Session("dc5")
        End If
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:right">

            Email:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></div>
    <div style="text-align: center">
    
        <br />
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: xx-large" Text="Label"></asp:Label>
    
    </div>
        <asp:Image ID="Image1" runat="server" Height="368px" Width="1148px" />
        <p>
            Type: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Created on:
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
