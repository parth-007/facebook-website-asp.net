<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Facebook - Login or Signup</title>
    <script type="text/javascript">
        function isNameEmpty(fnameTxt) {
            if (fnameTxt.value.length < 2) {
                alert("Empty");
                fnameTxt.focus();
            }
             function isSurnameEmpty(surnameTxt) {
            if (surnameTxt.value.length < 2) {
                
                surnameTxt.focus();
            }
             function isPhoneEmpty(mobTxt) {
            if (mobTxt.value.length < 10) {
                
                mobTxt.focus();
            }
            function isEmailEmpty(emTxt) {
                if (emTxt.value.length < 5) {
                
                    emTxt.focus();
                }
                function isPasswordEmpty(newpassTxt) {
                    if (newpassTxt.value.length < 8) {
                         
                        newpassTxt.focus();
                        document.getElementById("newpassTxt").style.borderColor=blue;
                    }
                }
            }
   </script>
   <script src="https://code.jquery.com/jquery-1.12.4.js" type="text/javascript"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js" type="text/javascript"></script>
  <script type="text/javascript">
      function f1() {
          var dd = confirm("Providing your date of birth helps make sure that you get the right Facebook experience for your age. If you want to change who sees this, go to the About section of your Profile. For more details, please visit our Data Policy.")

      }
  </script>
    <style type="text/css">
        .Curved
    {
    	
        border-radius: 7px;
    }
        #accCreateBtn
        {
            background:#4F7642;
            font-weight: 700;
            color: #FFFFFF;
            
        }
        #d2
        {
            background: lavender;
        }
        #d1
        {
            background: #3b5998;
        }
        .style2 
        {
            width: 100%;
            
        }
       
        .style3
        {
                height: 1px;
        }
        .style4
        {
            height: 1px;
            text-align: center;
            width: 758px;
            font-size: xx-large;
        }
        .style5
        {
            width: 758px;
        }
        .style6
        {
            text-align: center;
            width: 758px;
        }
        .style7
        {
            width: 230px;
        }
        .style8
        {
            height: 1px;
            width: 230px;
        }
        .style9
        {
            width: 226px;
        }
        .style10
        {
            height: 1px;
            width: 226px;
        }
        .style12
        {
            font-size: large;
        }
        .style13
        {
            font-size: medium;
        }
        .style14
        {
            font-size: x-large;
        }
        .style15
        {
            width: 801px;
            
        }
        .style17
        {
            height: 90px;
        }
        .style18
        {
            font-size: small;
            text-align: justify;
        }
        .style19
        {
            width: 801px;
            text-align: left;
        }
        .style20
        {
            width: 801px;
            height: 45px;
        }
        .style21
        {
            height: 52px;
        }
        .auto-style1 {
            width: 795px;
        }
        .auto-style2 {
            width: 795px;
            text-align: left;
        }
        .auto-style3 {
            width: 795px;
            height: 45px;
        }
        .auto-style4 {
            width: 221px;
        }
        .auto-style5 {
            height: 1px;
            width: 221px;
        }
    </style>
</head>
<body>
    <audio controls>
        <source src="tumhidekho.mp3" type="audio/mp3" />

    </audio>
  <!-- <video controls>
        <source src="" type="video/mp4" size/>

    </video>-->
<div id="d1">
    <form id="form1" runat="server">

 <font color="white">
    
    <table class="style2">
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style7">
                Email </td>
            <td class="auto-style4">
                Password</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4"><font face="Lucida Grande">
                facebook</font></td>
            <td class="style8">
                <asp:TextBox ID="emlText" runat="server" CssClass="Curved" ValidationGroup="pol"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="passTxt" runat="server" TextMode="Password" CssClass="Curved" ValidationGroup="pol"></asp:TextBox>
            </td>
            <td class="style3">
                <asp:Button ID="loginBtn" runat="server" Text="Log In" CssClass="Curved" ValidationGroup="pol" />
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
 <font color="white">
    
                <asp:LinkButton ID="forgetPasslinklbl0" runat="server" ForeColor="White" CssClass="Curved" OnClientClick="window.open('gmail.aspx','Otherpage');">Go To Gmail.com</asp:LinkButton>
        </font>
        
        
        
    
            </td>
            <td class="auto-style4">
                <asp:LinkButton ID="forgetPasslinklbl" runat="server" ForeColor="White" CssClass="Curved" OnClientClick="window.open('password.aspx','Otherpage');">Forgotten account ?</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="White" OnClientClick="window.open('Admin.aspx','Otherpage');">Admin Login</asp:LinkButton>
            </td>
        </tr>
        </table>
        </font>
        
        
        
    
    </div>
    
<div id="d2">   
 <table class="style2">
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Facebook helps you connect and share with the<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                people in your life.</td>
            <td colspan="2" class="style17" rowspan="3">
                <span class="style14">Create a new account</span><br class="style12" />
                <br />
                <span class="style13">It&#39;s free and always will be.<br />
                <br />
                <asp:TextBox ID="fnameTxt" runat="server" placeholder="First Name" 
                    Font-Names="Times New Roman" Font-Size="Large" Height="35px" Width="330px" CssClass="Curved"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                    ControlToValidate="fnameTxt" Display="Dynamic" ErrorMessage="Name not valid" 
                    ValidationExpression="[A-Z]{1}[a-zA-Z]{2,30}"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fnameTxt" Display="Dynamic" ErrorMessage="Can't Be Empty"></asp:RequiredFieldValidator>
                <br /><asp:TextBox ID="surnameTxt" 
                    runat="server" placeholder="Surame" Font-Names="Times New Roman" 
                    Font-Size="Large" Height="35px" Width="327px" CssClass="Curved"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="surnameTxt" Display="Dynamic" 
                    ErrorMessage="Surname not valid" ValidationExpression="[A-Z]{1}[a-zA-Z]{2,30}"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="surnameTxt" Display="Dynamic" ErrorMessage="Can't Be Empty"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="mobTxt" runat="server" Font-Names="Times New Roman" 
                    Height="35px" Width="329px" placeholder="Mobile number" 
                    Font-Size="Large" CssClass="Curved"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="mobTxt" ErrorMessage="Phone no not valid" 
                    ValidationExpression="^[7-9]{1}[0-9]{9}$" Display="Dynamic"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobTxt" Display="Dynamic" ErrorMessage="Can't Be Empty"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="emTxt" runat="server" Font-Names="Times New Roman" 
                    Height="35px" Width="329px" placeholder="Email Address" 
                    Font-Size="Large" CssClass="Curved"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="emTxt" ErrorMessage="Email not valid" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="emTxt" Display="Dynamic" ErrorMessage="Can't Be Empty"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="newpassTxt" runat="server" Font-Names="Times New Roman" 
                    Height="35px" Width="329px" Font-Size="Large" placeholder="New password" 
                    TextMode="Password" CssClass="Curved"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="newpassTxt" ErrorMessage="Password not valid" 
                    ValidationExpression="^[a-zA-Z0-9#@., ]{8,50}$" SetFocusOnError="True"></asp:RegularExpressionValidator>
                <br />
                <br />
                Birthday<br />
                <br />
                <asp:DropDownList ID="dayCombo" runat="server" CssClass="Curved">
                </asp:DropDownList>
&nbsp;
                <asp:DropDownList ID="monthCombo" runat="server" CssClass="Curved">
                </asp:DropDownList>
&nbsp;
                <asp:DropDownList ID="yearCombo" runat="server" CssClass="Curved">
                </asp:DropDownList>
                &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Small" OnClientClick="f1()">Why do i need to provide my birthdate ?</asp:LinkButton>
                </span></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <center><img alt="" src="images/pyNVUg5EM0j.png" /></center></td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
                </asp:Menu>
                <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            </td>
            <td rowspan="3" style="text-align: left">
                <br />
&nbsp;<asp:RadioButton ID="femaleRadio" runat="server" Text="Female" ValidationGroup="mik" />
                <asp:RadioButton ID="MaleRadio" runat="server" Text="Male" ValidationGroup="mik" />
                <br />
                <br />
                <span class="style18">By clicking Create Account, you agree to our </span>
                <asp:LinkButton ID="termsLink" runat="server" CssClass="style18" OnClientClick="window.open('Terms.aspx','Otherpage');">Terms</asp:LinkButton>
                <span class="style18">&nbsp;and confirm that you
                <br />
                have read our </span>
                <asp:LinkButton ID="datalink" runat="server" CssClass="style18">Data Policy</asp:LinkButton>
                <span class="style18">, including our Cookie use policy. You may recieve<br />
&nbsp;SMS messages notifications from facebook and can opt our at any time.</span></td>
            <td rowspan="3">
                </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                </td>
        </tr>
        <tr>
            <td class="auto-style1" rowspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style21">
                <asp:Button ID="accCreateBtn" runat="server" Height="48px" 
                    Text="Create Account" Width="213px" CssClass="Curved" />
            </td>
            <td class="style21">
                </td>
        </tr>
        <tr>
            <td class="auto-style1" rowspan="3">
                &nbsp;</td>
            <td><p>
                <br />
                
&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="window.open('Page.aspx','otherpage');">Create a Page</asp:LinkButton>
&nbsp;for celebrity, band or business.<br />&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;
                </p>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
       
        </table>
    </div>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
 
    
    
    
    </div>
</form>    
</body>
</html>
