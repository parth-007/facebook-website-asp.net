<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page.aspx.vb" Inherits="Page" Title="Facebook Page Section"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.min.js"></script>
<script>
$(function(){

$("#i1").die()
});
</script>
    <title></title>


    <style type="text/css">
        


        #d1
        {
            background:#3b5998;
        }
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 29px;
        }
        .style3
        {
            height: 29px;
            font-size: xx-large;
            width: 722px;
        }
        .style4
        {
            width: 722px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="d1">
    <table class="style1">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
 <font color="white">
    
                Email or Phone</font></td>
            <td>
 <font color="white">
    
                Password</font></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <font face="Lucida Grande" color="white">
                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;facebook&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span 
            class="style1">
        <asp:Button ID="signupBtn" runat="server" BackColor="Lime" ForeColor="White" 
            Height="43px" style="font-weight: 700" Text="Sign Up" Width="107px" OnClientClick="window.open('Default.aspx','otherpage');" />
                </span></strong></font></td>
            <td class="style2">
 <font color="white">
    
                <asp:TextBox ID="emlText" runat="server"></asp:TextBox>
        </font>
        
        
        
    
            </td>
            <td class="style2">
 <font color="white">
    
                <asp:TextBox ID="passTxt" runat="server" TextMode="Password"></asp:TextBox>
        </font>
        
        
        
    
            </td>
            <td class="style2">
 <font color="white">
    
                <asp:Button ID="loginBtn" runat="server" Text="Log In" />
        </font>
        
        
        
    
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
 <font color="white">
    
                <asp:LinkButton ID="forgetPasslinklbl" runat="server" ForeColor="White">Forgotten account ?</asp:LinkButton>
        </font>
        
        
        
    
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>

        Login To Your Page:-<br />
        Email:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" />
        <br />
&nbsp;<div class="uiHeader uiHeaderWithImage uiHeaderPage" 
        style="padding: 6px 0px 0px; font-family: Helvetica, Arial, sans-serif; color: rgb(29, 33, 41); font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
        <div class="clearfix uiHeaderTop" 
            style="zoom: 1; position: relative; font-family: inherit;">
            <div style="font-family: inherit;">
                <h2 aria-hidden="true" class="uiHeaderTitle" 
                    style="color: rgb(22, 38, 67); font-size: 16px; margin: 0px; padding: 0px 0px 2px 22px; outline: none; line-height: 20px; min-height: 20px; vertical-align: bottom; font-family: inherit;">
                    Create a Page</h2>
            </div>
        </div>
    </div>
    <div class="_4e2a" 
        style="margin: 8px 0px 16px 24px; width: 580px; font-family: Helvetica, Arial, sans-serif; color: rgb(29, 33, 41); font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
        <div class="fsm fwn fcg" 
            style="font-size: 12px; font-weight: normal; color: rgb(144, 148, 156); font-family: inherit;">
            Give your brand, business or cause a voice on Facebook and connect with the 
            people who matter to you.</div>
        <div class="_4e2b fsm fwn fcg" 
            style="margin-top: 6px; font-size: 12px; font-weight: normal; color: rgb(144, 148, 156); font-family: inherit;">
            It&#39;s free to set up. Just choose a Page type to get started.</div>
    </div>
    <center>
    <table class="style1">
        <tr>
            <td><center>
                <img alt="" src="images/1r.PNG" style="width: 272px" id="i1"/><br />
                <asp:Button ID="localbusinessorplace" runat="server" Text="Create Page" />
                </center></td>
            <td><center>
                <img alt="" src="images/2.PNG" style="width: 272px"/><br />
                <asp:Button ID="comanyorganizationorinstitution" runat="server" Text="Create Page" />
                </center></td>
            <td><center>
                <img alt="" src="images/3.PNG" style="width: 272px"/><br />
                <asp:Button ID="brandorproduct" runat="server" Text="Create Page" OnClientClick="window.open('open_page.aspx','otherpage')" PostBackUrl="~/open_page.aspx" />
                </center></td>
        </tr>
        <tr>
            <td><center>
                <img alt="" src="images/4.PNG" style="width: 272px"/><br />
                <asp:Button ID="artistbandorpublic" runat="server" Text="Create Page" />
                </center></td>
            <td><center>
                <img alt="" src="images/5.PNG" style="width: 272px"/><br />
                <asp:Button ID="entertainment" runat="server" Text="Create Page" />
                </center></td>
            <td><center>
                <img alt="" src="images/6.PNG" style="width: 272px"/><br />
                <asp:Button ID="causeorcommunity" runat="server" Text="Create Page" />
                </center></td>
        </tr>
    </table></center>
        <asp:SiteMapPath ID="SiteMapPath2" runat="server" SiteMapProvider="web.sitemap">
        </asp:SiteMapPath>
    </form>
    </body>
</html>
