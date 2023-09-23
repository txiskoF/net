<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MisCompras.aspx.cs" Inherits="LIBROS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbltitulo" runat="server" Text="Su pedido es: " Font-Bold="True" Font-Size="X-Large"></asp:Label> <br />
        <asp:Label ID="lblcompras" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblprecio" runat="server" Text="Precio:" Font-Bold="True" 
            Font-Size="Large"></asp:Label>
        
    </div>
    </form>
</body>
</html>
