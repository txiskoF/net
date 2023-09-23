<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="Ejercicio18.Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
            <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" Text="Salir" style="position: relative; top: 13px; left: 575px" />
        <br />
        <br />
        <asp:HyperLink ID="hlCesta" runat="server" Font-Bold="True" 
            
            NavigateUrl="~/MisCompras.aspx" style="z-index: 1; left: 508px; top: 96px; position: absolute">0</asp:HyperLink>
        <br />
        Productos<br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"  >
            <asp:ListItem Value="0">Libros Electrónicos</asp:ListItem>
            <asp:ListItem>Accesorios Libros Electrónicos</asp:ListItem>
            <asp:ListItem>Tablets</asp:ListItem>
        </asp:DropDownList>
    
        <asp:Image ID="Image2" runat="server" Height="69px" ImageUrl="~/imagenes/cesta.jpeg" style="z-index: 1; left: 481px; top: 13px; position: absolute" />
    
    </div>
    </form>
</body>
</html>

