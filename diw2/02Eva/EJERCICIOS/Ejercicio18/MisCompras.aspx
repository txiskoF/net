<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MisCompras.aspx.cs" Inherits="Ejercicio18.MisCompras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPedido" runat="server" Text="Su pedido es: " ></asp:Label> <br />
        <asp:Label ID="lblCompras" runat="server"></asp:Label>
        <asp:Label ID="lblPrecio" runat="server" Text="Precio:" ></asp:Label>
   </div>
        <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" Text="Salir" style="z-index: 1; left: 475px; top: 26px; position: absolute" />
    </form>
</body>
</html>
