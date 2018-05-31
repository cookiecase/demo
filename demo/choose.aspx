<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choose.aspx.cs" Inherits="demo.choose" %>

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
                        用户名
                    </td>
                    
                    <td style="width:100px">
                        角色
                    </td>
                    <td style="width:100px">
                        电话
                    </td>
                    <td style="width:100px">
                         状态
                    </td>
                    <td>
                        操作
                    </td>
                </tr>
            
        </HeaderTemplate>
        <ItemTemplate>
          <tr>
              <td>
                  <asp:CheckBox runat="server" id ="checkbox"   Enabled="True" Checked="false"/>
                                 </td>
              <td style="color:blue" >
                  <asp:Label ID="lbName" Text='<%#Eval("username")%>' runat="server"></asp:Label>
              </td>
              <td>
                   <%#Eval("role")%>
              </td>
              <td>
                   <%#Eval("telephone")%>
              </td>
              <td>
                  <%#Eval("Login")%>
              </td>
              <td>
                  <a href="userEdit.aspx?a=<%#Eval("username")%>" name="<%#Eval("username")%>" id="transmit" onclick="sub(this);" >修改</a>
              </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
       <asp:Button runat="server" Text="删除" OnClick="Unnamed1_Click"/>
    </div>
    </form>
    <script src="jquery-1.8.3.min.js"></script>
    <script>
        function sub(obj) {
            
            //parent.$('#123').attr("name") = $('#transmit').attr("name");
        }
    </script>
</body>
</html>
