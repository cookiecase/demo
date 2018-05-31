<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="demo.log" %>

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
                      用户名
                    </td>
                    <td style="width:100px">
                         操作时间
                    </td>
                    
                    <td style="width:100px">
                        操作类型
                    </td>
                   
                    <td>
                       备注
                    </td>
                </tr>
            
        </HeaderTemplate>
        <ItemTemplate>
          <tr>
              <td style="color:blue">
               <%#Eval("username")%>
               </td>
              <td  >
                    <%#Eval("operatime")%>
              </td>
              <td>
                  <%#Eval("operatpye")%>
              </td>
              
             
              <td>
                   <%#Eval("remake")%>
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
