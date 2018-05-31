<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleChoose.aspx.cs" Inherits="demo.Role" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater runat="server" ID="repeater1">
        <HeaderTemplate>
            <table>
                <tr>
                    <td style="width:100px">
                      选择
                    </td>
                    <td style="width:100px">
                        角色名称
                    </td>
                    
                    <td style="width:100px">
                        类型
                    </td>
                   
                    <td>
                        操作
                    </td>
                </tr>
            
        </HeaderTemplate>
        <ItemTemplate>
          <tr>
              <td>
                  <asp:CheckBox runat="server" />
               </td>
              <td style="color:blue" >
                   <%#Eval("rolename")%>
              </td>
              <td>
                   <%#Eval("roletype")%>
              </td>
              
              <td>
                  <a href="RoleEdit.aspx?a=<%#Eval("rolename")%>" name="<%#Eval("rolename")%>" id="transmit" onclick="sub(this);" >修改</a>
              </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
