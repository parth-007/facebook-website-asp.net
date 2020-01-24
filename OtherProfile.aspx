<%@ Page Title="PAge Info" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="OtherProfile.aspx.vb" Inherits="Main_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 99px;
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
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;Years Of Age
                
                <asp:Button ID="Button1" runat="server" Text="Add Friend" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Follow" />
                    
                <br />
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
                <td rowspan="2" class="auto-style3">
                    <asp:ImageButton ID="ImageButton7" runat="server" BorderColor="Red" ForeColor="Yellow" Height="108px" ImageUrl="~/img/facebook1.png" OnClientClick="window.open('OtherAbout.aspx','otherpage')" PostBackUrl="~/OtherAbout.aspx" Width="153px" />
                </td>
                <td>&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">About</td>
                <td>&nbsp;</td>
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

