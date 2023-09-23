<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="Principal.Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblMensaje" runat="server"></asp:Label>
        </div>
        <asp:Button ID="btnComprar" runat="server" OnClick="btnComprar_Click" Text="COMPRAR" />
        <asp:Button ID="btnCerrar" runat="server" OnClick="btnCerrar_Click" Text="Cerrar Sesion" />
    </form>
</body>
</html>
