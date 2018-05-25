<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="demo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="UserName" ></asp:TextBox>
        <asp:TextBox runat="server" ID="UserKey"></asp:TextBox>
        <asp:Button  runat="server" ID="LoginButton" OnClick="LoginButton_Click"/>

    </div>
    </form>
</body>
</html>
