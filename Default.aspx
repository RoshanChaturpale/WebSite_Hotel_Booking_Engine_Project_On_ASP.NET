<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  >
    <div>
    <table border="1">
        <asp:Repeater ID="Repeater1" runat="server">

            <HeaderTemplate>
               

                    <tr>
                        <td>EBC_Code</td>
                        <td>EBC-Name</td>
                        <td>Hotel_Code</td>
                        <td>Channel_Code</td>
                        <td>Interface_Active_Status</td>
                        <td>Username</td>
                        <td>Password</td>
                    </tr>
            
               
            </HeaderTemplate>


            <ItemTemplate>
          
                
                  <tr>
                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.EBC_Code") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.Hotel_Name") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.Hotel_code") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.Channel_code") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.Interface_Active_Status") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.USername") %>
                      </td>

                      <td>
                         <%#DataBinder.Eval(Container,"DataItem.Password") %>
                      </td>
            </tr>
              </ItemTemplate>
             
        </asp:Repeater>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
    </div>
        
    </form>
</body>
</html>
