<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDiseño.aspx.cs" Inherits="Web_ColegioCristoRey.TestDiseño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Css/cssTextbox.css" rel="stylesheet" />
    <link href="Css/cssBoton.css" rel="stylesheet" />
  
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <div style="text-align: center;">
                    <table  style="margin: 0 auto;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="twitterStyleTextbox "></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="twitterStyleTextboxPssw" TextMode="Password"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td style="text-align: left">
                                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesión" CssClass="myButton" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    </div>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
   
</body>
</html>
