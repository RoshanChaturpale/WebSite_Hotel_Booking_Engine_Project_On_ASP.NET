<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARI Supression.aspx.cs" Inherits="ARI_Supression" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 98px;
        }
        .auto-style5 {
            width: 126px;
        }
        .auto-style6 {
            width: 105px;
        }
        .auto-style7 {
            width: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Room Type</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Rate Code</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">Hot Deal</td>
                <td class="auto-style6">HRS1</td>
                <td class="auto-style7">Special</td>
                <td>Tradeshow</td>
            </tr>
            <tr>
                <td class="auto-style2">King</td>
                <td class="auto-style5">
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </td>
                <td class="auto-style6">
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                </td>
                <td class="auto-style7">
                    <asp:CheckBox ID="CheckBox5" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Queen</td>
                <td class="auto-style5">
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </td>
                <td class="auto-style6">
                    <asp:CheckBox ID="CheckBox4" runat="server" />
                </td>
                <td class="auto-style7">
                    <asp:CheckBox ID="CheckBox6" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" Text="Save" Width="63px" />
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
