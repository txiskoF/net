<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EJEMPLO_BASE_DATOS.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 301px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLibros" runat="server" Height="16px" Width="291px" AutoPostBack="True" OnSelectedIndexChanged="ddlLibros_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="Lblnumlibros" runat="server"></asp:Label>
            <asp:TextBox ID="TxtBuscaTitulo" runat="server" AutoPostBack="True" OnTextChanged="TxtBuscaTitulo_TextChanged" Width="272px"></asp:TextBox>
            <table>
                <tr>
                    <td>Identificativo Libro:</td><td class="auto-style1">
                        <asp:TextBox ID="TxtIdLibro" runat="server" style="width: 128px"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Título Libro:</td>
                     <td class="auto-style1"><asp:TextBox ID="TxtTitulo" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Tipo Libro:</td>
                     <td class="auto-style1"><asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Editor Libro:</td>
                     <td class="auto-style1"><asp:TextBox ID="TxtEditor" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Precio Libro:</td>
                     <td class="auto-style1"><asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Fecha Edición Libro:</td>
                     <td class="auto-style1"><asp:TextBox ID="TxtFechaEdicion" runat="server"></asp:TextBox></td>
                </tr>

            </table>
        </div>
        <asp:Button ID="BtnInsertar" runat="server" Text="INSERTAR LIBRO" />
        <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR LIBRO" />
        <asp:Button ID="BtnModificar" runat="server" Text="MODIFICAR LIBRO" />
    </form>
</body>
</html>
