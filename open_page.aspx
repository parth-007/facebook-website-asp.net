<%@ Page Title="Design Your Page" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="open_page.aspx.vb" Inherits="open_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:SiteMapPath ID="SiteMapPath2" runat="server">
        </asp:SiteMapPath>
        <br />
    </p>
<p>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="window.open('Page.aspx','otherpage')">Go To Main Page</asp:LinkButton>
    </p>
<p>
        Create a Page here for
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Enter Your Email:
        <asp:TextBox ID="emailtext" runat="server"></asp:TextBox>
    </p>
<p>
        Enter Password:
        <asp:TextBox ID="passtext" runat="server"></asp:TextBox>
    </p>
    <p>
        Give A Name of Your Page:-<asp:TextBox ID="pagename" runat="server"></asp:TextBox>
    </p>
    <p>
        Upload A Cover Picture for Your Page:-</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Preview Picture" />
        <asp:Button ID="Button2" runat="server" Text="Save this Picure" />
    </p>
    <p>
        <center><asp:Image ID="Image2" runat="server" Height="227px" Width="558px" /></center>
    n<p>
        <asp:Button ID="Button3" runat="server" Text="Save This Page" /> </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

