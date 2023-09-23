<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejemplo1.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Estilos/Estilo_ej1.css" rel="stylesheet" />
    <script src="Scripts/Js_ej1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="cabecera"><h1 >Ejemplo1</h1></div>
            <div class="contenido" id="contenido" runat="server">
            <asp:Label ID="LblNombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="txt"></asp:TextBox>
            <asp:Label ID="LblCorreo" runat="server" Text="Correo" CssClass="label"></asp:Label>
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="txt"></asp:TextBox>
            <asp:Button ID="BtnImprimir" runat="server" Text="Imprimir" CssClass="btn" OnClick="BtnImprimir_Click" />
            <asp:Button ID="BtnLimpiar" runat="server" Text="Limpiar" CssClass="btn" />
            </div>
        </div>
    </form>
</body>
</html>
