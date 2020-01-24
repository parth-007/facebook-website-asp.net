<%@ Page Language="VB" AutoEventWireup="false" CodeFile="password.aspx.vb" Inherits="password" Title="Facebook Password"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function func() {
            var b1 = document.getElementById("rb1");
            var b2 = document.getElementById("rb2");
            var pnl = document.getElementById("Panel1");

            var pnl1 = document.getElementById("Panel2");
            if (b1.checked = true) {
                pnl.style.display = 'block';
            }
            else {
                pnl1.style.display = 'block';
            }


        }
    </script>
    <style type="text/css">
p{margin:0 0 10px}p,h2,h3{orphans:3;widows:3}*{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}*{text-shadow:none!important;color:#000!important;background:transparent!important;box-shadow:none!important}input,button,select,textarea{font-family:inherit;font-size:inherit;line-height:inherit}input{line-height:normal}button,input,optgroup,select,textarea{color:inherit;font:inherit;margin:0}a{color:#428bca;text-decoration:none}a,a:visited{text-decoration:underline}a{background:0 0}
        .style7
        {
            width: 230px;
        }
        .style9
        {
            width: 226px;
        }
        .style8
        {
            height: 1px;
            width: 230px;
        }
        .Curved
    {
    	
        border-radius: 7px;
    }
        .style10
        {
            height: 1px;
            width: 226px;
        }
               
        .style3
        {
                height: 1px;
        }
        .style2 
        {
            width: 100%;
            
        }
       
        .auto-style1 {
            width: 91px;
        }
        .auto-style2 {
            height: 248px;
        }
        .auto-style3 {
            height: 248px;
            width: 523px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Select Either of the way You would like to Reach to Your Account :-</p>
        <table class="style2">
            <tr>
                <td class="auto-style1">
                    <asp:RadioButton ID="rb1" runat="server" GroupName="gname" />
                </td>
                <td>Using The gmail which was Provided</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:RadioButton ID="rb2" runat="server" GroupName="gname"/>
                </td>
                <td>Using the Phone number</td>
            </tr>
        </table>
            <br />
        <br />

        <table class="style2">
            <tr>
                <td class="auto-style3">
                    <asp:Panel ID="Panel1" runat="server" Height="234px" Width="535px">
                        Enter The Mail:<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Verify" />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        Enter New PAssword:
                        <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="Button2" runat="server" Text="Update" />
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                </td>
                <td class="auto-style2">
                    <asp:Panel ID="Panel2" runat="server" Height="424px" Visible="False">
                        Enter The Phone Number:<br />
                        <br />
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="phoneVerify" runat="server" Text="Verify" />
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <asp:TextBox ID="tb3" runat="server" Enabled="False" Font-Size="Large" Height="55px" Width="241px"></asp:TextBox>
                        <br />
                        <br />
                        Enter The Captcha Here:<br />
                        <asp:TextBox ID="anstxt" runat="server" Width="240px"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" Text="Check" />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Enter New PAssword:"></asp:Label>
&nbsp;<asp:TextBox ID="passphone" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="upd1" runat="server" Height="31px" Text="Update" />
                        <br />
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
