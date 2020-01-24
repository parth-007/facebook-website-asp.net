<%@ Page Title="Other Info Page" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="OtherAbout.aspx.vb" Inherits="aboutde" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            width: 433px;
        }
        .auto-style3 {
            height: 20px;
            width: 433px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="ui-accordion">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style2">Unique Facebook ID</td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Name</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Surname</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Phone</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email</td>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Birthdate</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">State</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">City</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">School</td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                College</td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>

