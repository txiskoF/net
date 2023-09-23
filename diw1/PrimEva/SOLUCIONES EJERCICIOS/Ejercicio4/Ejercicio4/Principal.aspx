<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 4</title>
    <link rel="stylesheet" type="text/css" href="Estilos/Estilo.css" />
    <script type="text/javascript" src="SCRIPTS/funciones.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page" id="pagina" runat="server">
        <div class="cabecera"><h1>Calculadora</h1></div>
        <div class="contenido">
            <fieldset class="field1">
        <asp:TextBox ID="txtaltura" runat="server" CssClass="elemento" Text="Introduzca la altura en cm." AutoPostBack="True" OnTextChanged="txtaltura_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtpeso" runat="server" CssClass="elemento" Text="Introduzca el peso en kg." AutoPostBack="True" OnTextChanged="txtpeso_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtsexo" runat="server" CssClass="elemento" Text="Introduzca el sexo del niñ@" AutoPostBack="True" OnTextChanged="txtsexo_TextChanged"></asp:TextBox>
                    <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn" OnClick="btnCalcular_Click" />
                </fieldset>
     <fieldset class="field2" id="field2" runat="server">
        <asp:Label ID="lblIMC" runat="server" Text="IMC:" CssClass="etiquetas"></asp:Label>
        <asp:Label ID="lblIbuprofeno" runat="server" Text="Ibuprofeno:" CssClass="etiquetas"></asp:Label>
        <asp:Label ID="lblParacetamol" runat="server" Text="Paracetamol:" CssClass="etiquetas"></asp:Label>
        <asp:Button ID="btnOtros" runat="server" Text="Otros Datos" CssClass="btn" OnClick="btnOtros_Click" />
       </fieldset>
        <asp:Button ID="btnInicia" runat="server" Text="Limpiar" CssClass="btn2" OnClick="btnInicia_Click" />
    </div>
    </div>
    </form>
</body>
</html>
