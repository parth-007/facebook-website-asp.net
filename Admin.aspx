<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin.aspx.vb" Inherits="Admin" Title="Admin Side Page"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #d1 {
            background:#ff6a00;
            color:#0ff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1"><strong><em>Welcome to the Admin Page.</em></strong></h1>
    
    </div>
    <div id="d1">
    <p>&nbsp;</p>
        <h3>
       <b> Enter Username:<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    </h3>
    <h3>
        Enter Password:<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></b>
    </h3>
        <p>
            &nbsp;</p>
        
        </div>
        <asp:Button ID="loginBtn" runat="server" Text="Login" />
&nbsp;&nbsp;
        <asp:Button ID="resetBtn" runat="server" Text="Reset" />
    </form>
    </body>
</html>
