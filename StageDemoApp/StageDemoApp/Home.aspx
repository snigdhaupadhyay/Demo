<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StageDemoApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
        <asp:Label ID="lbl_userID" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Domain"></asp:Label>
        <asp:Label ID="lbl_userDomain" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="OS Version"></asp:Label>
        <asp:Label ID="lbl_osVersion" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text="Machine Name"></asp:Label>
        <asp:Label ID="lbl_machine" runat="server" Text=""></asp:Label>
        <br />
        
    </div>
    </form>
</body>
</html>
