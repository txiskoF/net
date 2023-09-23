<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarPedidos.aspx.cs" Inherits="SOLUCION_Ejercicio1.EliminarPedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#999966">
    <form id="form1" runat="server">
    <div>
    <table><tr><td>
        <asp:Label ID="lblorden" runat="server" Text="OrdenID:" ForeColor=White 
            Font-Bold="True"></asp:Label></td><td>
        <asp:TextBox ID="txtordenID" runat="server" Font-Bold="True" ForeColor="#666633"></asp:TextBox> </td>
        <td> <asp:Button ID="txtBuscar" runat="server" Text="Buscar Orden Pedido" 
                BackColor="White" Font-Bold="True" ForeColor="#666633" OnClick="txtBuscar_Click" 
                />
        </td>
        </tr>
        <tr><td colspan="3" align="right">
          <asp:ListBox ID="LstDetalles" runat="server" Font-Bold="True" 
                ForeColor="#666633"></asp:ListBox>
           </td>
           </tr>
           <tr><td colspan="3" align="right">
               <asp:Button ID="btnEliminar" runat="server" Text="Borrar Pedido" 
                   BackColor="White" Font-Bold="True" ForeColor="#666633" 
                   style="height: 26px" OnClick="btnEliminar_Click"  /></td></tr>
        
        </table>
    </div>
    </form>
</body>
</html>
