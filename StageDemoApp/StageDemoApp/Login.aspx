<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StageDemoApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the demo app</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label><asp:TextBox ID="txt_userID" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter a user ID" ControlToValidate="txt_userID"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter a password" ControlToValidate="txt_password"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btn_submit" runat="server" Text="Button" OnClick="btn_submit_Click" />
        <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
