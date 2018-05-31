<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userEdit.aspx.cs" Inherits="demo.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>frame</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a id="7987"></a>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <div>
       <label style="margin:0 20px 0 0"  runat="server">用户名</label><a ></a>    <asp:TextBox AUTOCOMPLETE="OFF" ID="UserName" runat="server"></asp:TextBox>
            </div>
       <div><label>登录密码</label> <asp:TextBox ID="UserKey" AUTOCOMPLETE="OFF" runat="server"></asp:TextBox>
           </div>
       <div> <label style="margin: 0 10px 0 0 ">确认密码</label><asp:TextBox AUTOCOMPLETE="OFF" ID="Confirm" runat="server"></asp:TextBox>
         
           </div>
         <div>

        <label  style="margin: 0 10px 0 0 ">选择图片</label><asp:FileUpload ID="FileUpload1" runat="server" />
             </div> 
    </div>
        
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="button_Click" Text="Edit" />
        </p>
        
    </form>
    
</body>
</html>
