<%@ Page Title="Update Settings" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="settings.aspx.vb" Inherits="settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p align="left">
    Your Name:
    <asp:TextBox ID="nameTxt" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="rstNamee" runat="server" Text="Reset" />
&nbsp;
    <asp:Button ID="updName" runat="server" Text="Update" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
    <p align="left">
    Your Surname:
    <asp:TextBox ID="surTxt" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="rstSur" runat="server" Text="Reset" />
&nbsp;
    <asp:Button ID="updSur" runat="server" Text="Update" />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
<p align="left">
    Your Email:
    <asp:TextBox ID="emailTxt" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="rstEmail" runat="server" Text="Reset" />
&nbsp;
    <asp:Button ID="updEmail" runat="server" Text="Update" />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
<p align="left">
    Your Password:
    <asp:TextBox ID="passTxt" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="rstPass" runat="server" Text="Reset" />
&nbsp;
    <asp:Button ID="updPass" runat="server" Text="Update" />
&nbsp;<asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
<p align="left">
    Your PhoneNo:
    <asp:TextBox ID="phoneTxt" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="rstPhone" runat="server" Text="Reset" />
&nbsp;
    <asp:Button ID="updPhone" runat="server" Text="Update" />
&nbsp;<asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
<p>
    &nbsp;</p>
    <p align="left">
        Now Set Profile Picture for You :-</p>
    <p align="left">
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p align="left">
        <asp:Button ID="Button1" runat="server" Text="Preview Image" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Set as Profile Picture" ToolTip="Set as Profile Picture" />
    </p>
    <p align="left">
        <asp:Image ID="Image1" runat="server" Height="223px" Width="259px" Visible="False" />
    </p>
    <p align="left">
        &nbsp;</p>
    <p align="left">
        Now Pic a Cover Photo Which suits your Style and Mentality: -</p>
    <p align="left">
        <asp:FileUpload ID="FileUpload2" runat="server" />
    </p>
    <p align="left">
        <asp:Button ID="preCover" runat="server" Text="Preview Cover Picture" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="coverPic" runat="server" Text="Set as Cover Pic" />
    </p>
    <p align="left">
        <asp:Image ID="Image2" runat="server" Height="171px" Visible="False" Width="429px" />
    </p>
    <p align="left">
        &nbsp;</p>
</asp:Content>

