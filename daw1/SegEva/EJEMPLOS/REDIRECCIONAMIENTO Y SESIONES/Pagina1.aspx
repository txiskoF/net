<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Principal.Pagina1" %>

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
                <tr><td>Nombre:</td><td>
                    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox></td></tr>
                <tr><td>Correo:</td><td>
                    <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox></td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" PostBackUrl="~/Pagina2.aspx" />
                    <asp:Button ID="btnENVIAR" runat="server" Text="ENVIAR RESPONSE" OnClick="btnENVIAR_Click" />
                    <asp:Button ID="btnENVIAR0" runat="server" Text="ENVIAR SERVER" OnClick="btnENVIAR0_Click"  />
                    <asp:HyperLink ID="HyperLink1" runat="server">Enviar</asp:HyperLink>
                    <asp:LinkButton ID="LinkButton1" runat="server">Enviar</asp:LinkButton>
                    </td></tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ENVIAR SESSION" />
    </form>
</body>
</html>
