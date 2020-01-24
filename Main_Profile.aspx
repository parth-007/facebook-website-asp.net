<%@ Page Title="Profile Page" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="Main_Profile.aspx.vb" Inherits="Main_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style3 {
            width: 99px;
        }
        .auto-style4 {
            height: 91px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <script type="text/javascript">

    </script>
    <br />
    <table class="nav-justified">
        <tr>
            <td colspan="2" align="left" class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Image ID="Image2" runat="server" Height="167px" Width="637px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                &nbsp;<asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Marketting.xml" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" align="left">
                <asp:Image ID="Image3" runat="server" Height="165px" Width="143px" />
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1" align="left">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
    <p align="left">
        &nbsp;</p>
    <p align="left">
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:ImageButton ID="ImageButton7" runat="server" BorderColor="Red" ForeColor="Yellow" Height="108px" ImageUrl="~/img/facebook1.png" OnClientClick="window.open('aboutde.aspx','otherpage')" PostBackUrl="~/aboutde.aspx" Width="153px" />
                </td>
                <td class="auto-style4">
                    <asp:ImageButton ID="ImageButton8" runat="server" BorderColor="Red" ForeColor="Yellow" Height="108px" ImageUrl="~/Facebook/friends.png" PostBackUrl="~/Friends.aspx" Width="153px" />
                </td>
               
            </tr>
            <tr>
                <td class="auto-style3">About</td>
                <td>Friends</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>

