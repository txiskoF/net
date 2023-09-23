<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SESIONES.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td><b>Nombre:</b></td><td>
                    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox></td></tr>
                <tr><td>Apellido:</td><td>
                    <asp:TextBox ID="TxtApellido" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" /></td></tr>
            </table>
        </div>
        <asp:HyperLink ID="hlAcceso" runat="server" NavigateUrl="~/Compras.aspx">Ir a Compras</asp:HyperLink>
    </form>
</body>
</html>
