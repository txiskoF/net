<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejercicio7_SOLUCION.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
        <h1>PEDIDOS</h1>
    <table>
        <tr><td>
            <asp:Label ID="lblEmpleado" runat="server" Text="Empleado"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEmpleado" runat="server"  OnTextChanged="txtEmpleado_TextChanged" AutoPostBack="True"></asp:TextBox></td>
            <td>
                <asp:Label ID="lblRecibido" runat="server" Text="Recibido"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtRecibido" runat="server"  OnTextChanged="txtRecibido_TextChanged" AutoPostBack="True"></asp:TextBox></td>

        </tr>

        <tr><td>
            <asp:Label ID="lblImprte" runat="server" Text="Importe"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtImporte" runat="server"  OnTextChanged="txtImporte_TextChanged" AutoPostBack="True"></asp:TextBox></td>
            <td>
               </td>
            <td>
              </td>
        </tr>

        <tr><td>
            <asp:Label ID="lblIVA" runat="server" Text="IVA"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtIVA" runat="server"></asp:TextBox></td>
            <td
                <asp:Label ID="lblCambios" runat="server" Text="Cambios"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCambios" runat="server"></asp:TextBox></td>

        </tr>

        <tr><td>
            <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox></td>
            <td>
    </td>
            <td>
              </td>

        </tr>
    </table>
    
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
        <asp:Panel ID="panelC" runat="server" style=" left: 1px; top: 250px;  height: 400px; width: 900px">
        </asp:Panel>
    </div>
    </form>
</body>
</html>
