<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EjemploBaseDatos.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLibros" runat="server" Height="16px" Width="291px" OnSelectedIndexChanged="ddlLibros_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="Lblnumlibros" runat="server"></asp:Label>
            <asp:TextBox ID="TxtBuscaTitulo" runat="server" AutoPostBack="True" OnTextChanged="TxtBuscaTitulo_TextChanged" Width="99px"></asp:TextBox>
            <table>
                <tr>
                    <td>Identificativo Libro</td><td>
                    <asp:TextBox ID="TxtIdLibro" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Título Libro</td><td>
                    <asp:TextBox ID="TxtTitulo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tipo Libro</td><td>
                    <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Editor Libro</td><td>
                    <asp:TextBox ID="TxtEditor" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Editor Libro</td><td>
                    <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Precio Libro</td><td>
                    <asp:TextBox ID="TxtFechaEdicion" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="BtnInsertar" runat="server" Text="INSERTAR LIBRO" OnClick="BtnInsertar_Click" />
        <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR LIBRO" OnClick="BtnEliminar_Click" />
        <asp:Button ID="BtnModificar" runat="server" Text="MODIFICAR LIBRO" OnClick="BtnModificar_Click" />
        <asp:TextBox ID="TxtPrecioCalcular" runat="server" Width="61px"></asp:TextBox>
        <asp:Button ID="BtnCalcularLibrosPrecio" runat="server" OnClick="Button1_Click" Text="CalcularLibrosPrecio" />
    </form>
</body>
</html>
