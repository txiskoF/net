<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EJEMPLO_VARIABLES.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnIncremento" runat="server" Text="+1" OnClick="BtnIncremento_Click" /><BR />
            <asp:Button ID="BtnDecremento" runat="server" Text="-1" OnClick="BtnDecremento_Click" /><BR />
            <asp:Label ID="LblResultado" runat="server" Text=""></asp:Label><BR />

            <asp:Button ID="BtnCrear" runat="server" Text="Crear Botón EN EJECUCIÓN" OnClick="BtnCrear_Click" />

            <asp:Button ID="BtnCrearMatriz" runat="server" Text="Crear Varios Botones EN EJECUCIÓN" OnClick="BtnCrearMatriz_Click" />
            <asp:Button ID="BtnBorrar" runat="server" OnClick="BtnBorrar_Click" Text="Borrar CONTROLES (En diseño o Ejecución)" />
        </div>
        <asp:Panel ID="pnlBotones" runat="server" GroupingText="Botones de Redireccionamiento">
        </asp:Panel>
    </form>
</body>
</html>
