<%@ Page Title="Reset Your Profile Here" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="profileset.aspx.vb" Inherits="profileset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p style="box-sizing: border-box; margin: 0px 0px 10px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: right; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;">
        Here We will be adding some of the basic information about your self. Facebook is all about chatting and interacting and enjoying life with friends.</p>
    <p style="box-sizing: border-box; margin: 0px 0px 10px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: right; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;">
        We will be asking this information for suggesting the closest friends of yours and give you the best experience of Facebook.</p>
    <p align="left">
        You Are
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        Years Old </p>
    <p align="left">
        You Can Reset Your Profile Here.</p>
    <p align="left">
        Now First of All, Select Your State:-</p>
    <p align="left">
        Your State :
        <asp:DropDownList ID="StateCombo" runat="server" AutoPostBack="True">
        </asp:DropDownList>
    </p>
    <table class="nav-justified">
        <tr>
            <td align="left">
                &nbsp;<asp:Panel ID="Panel1" runat="server">
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Select City :"></asp:Label>
                    <asp:DropDownList ID="cityCombo" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Panel ID="Panel2" runat="server">
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Select School:"></asp:Label>
                    <asp:DropDownList ID="schoolCombo" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Panel ID="Panel3" runat="server">
                    &nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Select College:"></asp:Label>
                    <asp:DropDownList ID="collegeCombo" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    </asp:Panel>
                    <br />
                    Once You&#39;re Set, Please Click On Below Button.<br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Update Information" />
                
            </td>
        </tr>
    </table>
</asp:Content>

