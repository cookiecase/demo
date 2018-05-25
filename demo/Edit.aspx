<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="demo.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label runat="server">角色类型</asp:Label> <asp:DropDownList ID="RoleType" runat="server"></asp:DropDownList>
    <asp:Label runat="server">角色名称</asp:Label> <asp:TextBox ID="RoleName" runat="server"></asp:TextBox>
       <asp:Label runat="server">权限</asp:Label> <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Button runat="server" OnClick="Unnamed_Click"/>
    </div>
    </form>
</body>
</html>
