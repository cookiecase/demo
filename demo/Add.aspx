<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="demo.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
       <asp:Label runat="server">用户名</asp:Label> <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
       <asp:Label runat="server">登录密码</asp:Label> <asp:TextBox ID="UserKey" runat="server"></asp:TextBox>
        <asp:Label runat="server">确认密码</asp:Label><asp:TextBox ID="Confirm" runat="server"></asp:TextBox>
        <asp:Label runat="server">选择图片</asp:Label><asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
        
        <p>
        <asp:Button  runat="server" ID="button"  OnClick="button_Click" Width="89px"/>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" />
        </p>
        
    </form>
    
</body>
</html>
