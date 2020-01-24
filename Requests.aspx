<%@ Page Title="" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="Requests.aspx.vb" Inherits="requests" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <!--<asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <ItemStyle ForeColor="#000066" />
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>Mutual Friends</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Button" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        </asp:DataList>-->

    </p>
        <br /><asp:Panel runat="server" ID="pnl1"><p align="left">
    <asp:LinkButton ID="LinkButton6" runat="server">LinkButton</asp:LinkButton>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Sent You a Friend Request"></asp:Label>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Confirm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Reject" /></p></asp:Panel>
</asp:Content>


