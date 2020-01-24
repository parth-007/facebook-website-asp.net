<%@ Page Title="Home Page-Create Your Style" Language="VB" MasterPageFile="~/Facebook.master" AutoEventWireup="false" CodeFile="homepage.aspx.vb" Inherits="homepage" %>
<%@ MasterType VirtualPath="~/Facebook.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4/jquery.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"
        type="text/javascript"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css"
        rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=Textbox2]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: '<%=ResolveUrl("~/WebService.asmx/GetCustomers")%>',
                        data: "{ 'prefix': '" + request.term + "'}",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    label: item.split('-')[0],
                                    val: item.split('-')[1]
                                }
                            }))
                        },
                        error: function (response) {
                            alert(response.responseText);
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        }
                    });
                },
                select: function (e, i) {
                    $("[id$=HiddenField1]").val(i.item.val);
                },
                minLength: 1
            });
        });
    </script>
    <style type="text/css">
        body, html {
  width: 100%;
  height: 100%;
  margin: 0;
}

.container {
  width: 100%;
  height: 100%;
}

.leftpane {

    width: 25%;
    height: 100%;
    float: left;
    background-color: rosybrown;
    border-collapse: collapse;
}

.middlepane {
    width: 50%;
    height: 100%;
    float: left;
    background-color: royalblue;
    border-collapse: collapse;
}

.rightpane {
  width: 25%;
  height: 100%;
  position: relative;
  float: right;
  background-color: yellow;
  border-collapse: collapse;
}	




        .plz {
            text-align:left;
        }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="container">
        <div class="leftpane">
           

            <h1>Test Page</h1>
            <p>&nbsp;</p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:HiddenField ID="HiddenField1" runat="server" />
                <br />
                <asp:Button ID="Button5" runat="server" Text="Button" />
            </p>
        </div>
        <div class="middlepane">        <asp:Button ID="Button4" runat="server" PostBackUrl="~/profileset.aspx" Text="Your Profile Looks Uncomplete..Click me." />
<br />
            <asp:Panel ID="Panel1" runat="server" Height="149px">
                <p align="left"><asp:Image ID="Image2" runat="server" Height="48px" />
                <asp:TextBox ID="TextBox1" runat="server" Height="80px" CssClass="plz" Width="216px" placeholder="Share an Update"></asp:TextBox>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Height="47px" Text="Post Status" Width="85px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Post Picture/Video" Height="47px" Width="142px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Activity" Height="47px" Width="61px" />
                    </p>
              
               
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
              
               
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    &nbsp;</p>
              
               
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Height="420px" Visible="False"><p align="left">
                <asp:FileUpload ID="FileUpload1" runat="server" />&nbsp;<asp:Button ID="btnUpload" runat="server" Text="Upload" />
                <p align="left">
                    <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="White" OnClientClick="window.open('Main_Profile.aspx','otherpage')" style="text-align: left">LinkButton</asp:LinkButton>
                    &nbsp;Added a Picture.<br />
                    <asp:Image ID="Image1" runat="server" Height="314px" Width="558px" />
                </p>
            </asp:Panel>
            <p>
                    <asp:Button ID="likeBtn0" runat="server" Text="Like" />
                    <asp:Label ID="lblcnt0" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="rightpane">
            <h1>Test Page</h1>
            </div>
        
        <br />

        
            <asp:Panel ID="pnl2" runat="server" Height="145px" Visible="False" style="margin-top: 0px">
                <p align="left"><asp:LinkButton ID="LinkButton2" runat="server" style="text-align: left" OnClientClick="window.open('Main_Profile.aspx','otherpage')" ForeColor="White">LinkButton</asp:LinkButton> Updated his status.<br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="likeBtn" runat="server" Text="Like" />
                    <asp:Label ID="lblcnt" runat="server" Text=""></asp:Label>
                </p>
            </asp:Panel>
            

        
</asp:Content>

