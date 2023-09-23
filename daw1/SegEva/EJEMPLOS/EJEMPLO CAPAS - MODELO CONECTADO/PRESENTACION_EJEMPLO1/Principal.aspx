<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PRESENTACION_EJEMPLO1.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLibros" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLibros_SelectedIndexChanged">
            </asp:DropDownList>
            <table>
                <tr><td><b>Id. Libro:</b></td><td>
                    <asp:TextBox ID="txtIdLibro" runat="server"></asp:TextBox>
                    <asp:Label ID="LblTotalLibros" runat="server"></asp:Label>
                    </td></tr>
                 <tr><td><b>Título Libro:</b></td><td>
                     <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></td></tr>
                <tr><td><b>Tipo Libro:</b></td><td>
                    <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox></td></tr>
                 <tr><td><b>Precio Libro:</b></td><td>
                     <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td></tr>
                <tr><td><b>Fecha Edición Libro:</b></td><td>
                    <asp:TextBox ID="txtFechaEdicion" runat="server"></asp:TextBox></td></tr>
                <tr><td>
                    <asp:Button ID="BtnInsertar" runat="server" Text="Insertar" OnClick="BtnInsertar_Click" /></td>
                    <td>
                        <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" /></td>
                    <td>
                        <asp:Button ID="BtnBorrar" runat="server" Text="Eliminar" OnClick="BtnBorrar_Click" /></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
