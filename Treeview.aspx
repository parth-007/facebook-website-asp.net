<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Treeview.aspx.vb" Inherits="Treeview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource2" ShowLines="True">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource2" runat="server" />
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    <div>
    
    </div>
    </form>
</body>
</html>
