<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="SESIONES.Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnCompras" runat="server" Text="Comprar" OnClick="BtnCompras_Click" />
            <asp:Label ID="LblPresentacion" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
