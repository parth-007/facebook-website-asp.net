<%@ Page Title="HomePage- Create Your Page" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="hpage.aspx.vb" Inherits="hpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
    <style type="text/css">
        .auto-style1 {
            width: 674px;
        }
    </style>
  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="ui-accordion">
        <tr>
            <td>
                <br />
                This is the Facebook Community</td>
            <td class="auto-style1">        <asp:Button ID="Button4" runat="server" PostBackUrl="~/profileset.aspx" Text="Your Profile Looks Uncomplete..Click me." />
                <br />
                <asp:SiteMapPath ID="SiteMapPath2" runat="server">
                </asp:SiteMapPath>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton6" runat="server" OnClientClick="window.open('OtherProfile.aspx','otherpage')">LinkButton</asp:LinkButton>
                &nbsp;<asp:Label ID="lbl5" runat="server" Text="sent You a Friend Request."></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button8" runat="server" Text="Confirm" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" Text="Cancel" />
                <br />
                <br />
                <asp:LinkButton ID="LinkButton7" runat="server">See All</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="59px" Width="215px">
                </asp:DropDownList>
                </td>
            <td class="auto-style1"><asp:Image ID="Image2" runat="server" Height="48px" />
                <asp:TextBox ID="TextBox1" runat="server" Height="66px" CssClass="plz" Width="372px" placeholder="Share an Update"></asp:TextBox>
                  <br />
                <asp:Button ID="Button1" runat="server" Height="47px" Text="Post Status" Width="110px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Post Picture/Video" Height="47px" Width="176px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" Text="Activity" Height="47px" Width="61px" />
                    </td>
            <td>Search A User :-<br />
                <br />
                By Using the Name:<br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="searchBtn" runat="server" Text="Search" />
                <br />
                <br />
                <asp:DropDownList ID="nameCombo" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                Now Search The Surname:</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button10" runat="server" Text="Friend Requests" />
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:Panel ID="Panel1" runat="server">
                    <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
                    &nbsp;updated
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    &nbsp;status.<br />
                    <asp:Label ID="Label2" runat="server" style="text-decoration: underline; font-style: italic" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="likeBtn0" runat="server" Text="Like" />
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </asp:Panel>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="searchBtn0" runat="server" Text="Search" />
                <br />
                <br />
                <asp:DropDownList ID="nameCombo0" runat="server">
                </asp:DropDownList>
                <asp:Button ID="Button7" runat="server" Text="Search This User" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Panel ID="Panel2" runat="server">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <asp:Button ID="btnUpload" runat="server" Text="Upload" />
                    <br />
                    <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton>
                    &nbsp;Added a Picture.<br />
                    <asp:Image ID="Image3" runat="server" Height="367px" Width="667px" />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Like" />
                    <asp:Label ID="likecnt" runat="server"></asp:Label>
                    <br />

                </asp:Panel>
            </td>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Panel ID="Panel3" runat="server">
                    <asp:LinkButton ID="LinkButton8" runat="server">LinkButton</asp:LinkButton>
                    &nbsp;updated
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    &nbsp;status.<br />
                    <asp:Label ID="Label6" runat="server" style="text-decoration: underline; font-style: italic" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="likeBtn1" runat="server" Text="Like" />
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </asp:Panel>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    
</asp:Content>

