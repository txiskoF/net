<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejercicio1.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="ESTILO/estilo1.css" rel="stylesheet" />
    <script src="JS/JavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="cabecera" id="etiqueta" runat="server">
            <asp:Label ID="LblMensaje" runat="server"  CssClass="cabeceralabel" Text="Texto de Muestra"></asp:Label></div>
            
            <div class="contenido">
            <asp:Button ID="BtnEscribe" runat="server" Text="Escribe algo..." CssClass="btn" OnClick="BtnEscribe_Click"/>
            <asp:Button ID="BtnFondo" runat="server" Text="Cambia Fondo" CssClass="btn" OnClick="BtnFondo_Click"/>
            <asp:Button ID="BtnLetra" runat="server" Text="Cambia Letra" CssClass="btn" OnClick="BtnLetra_Click" />
            <asp:Button ID="BtnTamaño" runat="server" Text="Cambia Tamaño" CssClass="btn" OnClick="BtnTamaño_Click"/>
            <asp:Button ID="BtnColor" runat="server" Text="Cambia Color"   CssClass="btn" OnClick="BtnColor_Click" />
            <asp:Button ID="BtnLimpiar" runat="server" Text="Reiniciar"  CssClass="btn" OnClick="BtnLimpiar_Click"/>
            
                </div>
        </div>
    </form>
</body>
</html>
