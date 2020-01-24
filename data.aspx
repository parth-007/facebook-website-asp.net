<%@ Page Language="VB" AutoEventWireup="false" CodeFile="data.aspx.vb" Inherits="data" Title="Data Confi. Page"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="userid" HeaderText="UserID" />
                <asp:BoundField DataField="fname" HeaderText="FirstName" />
                <asp:BoundField DataField="surname" HeaderText="Surname" />
                <asp:BoundField DataField="phone" HeaderText="PhoneNo" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="password" HeaderText="Password" />
                <asp:BoundField DataField="day" HeaderText="Date" />
                <asp:BoundField DataField="name" HeaderText="Month" />
                <asp:BoundField DataField="year" HeaderText="Year" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:ImageField AlternateText="Image not Available" DataImageUrlField="pic" HeaderText="PRofile Picture">
                    <ItemStyle Height="10px" Width="10px" />
                </asp:ImageField>
                <asp:ImageField AlternateText="Picture Not Available" DataImageUrlField="coverpic" HeaderText="Cover Picture">
                    <ItemStyle Height="1px" Width="1px" />
                </asp:ImageField>
                <asp:BoundField DataField="sname" HeaderText="State" />
                <asp:BoundField DataField="cname" HeaderText="City" />
                <asp:BoundField DataField="scname" HeaderText="School" />
                <asp:BoundField DataField="colname" HeaderText="College" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
