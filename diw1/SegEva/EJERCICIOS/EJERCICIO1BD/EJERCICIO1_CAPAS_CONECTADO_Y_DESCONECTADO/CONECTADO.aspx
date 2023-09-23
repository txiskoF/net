<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CONECTADO.aspx.cs" Inherits="CONECTADO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type ="text/css">
        table{border-color:#999966;background-color:#999966;color:White;
            width: 93%;
        }
    td.c1{width:30%;}
   
    td.c3{width:30%; }
    h1,h2,h3{display:inline;color:White;}
    td.c4{ vertical-align:bottom;}
        
        .style2
        {
            height: 116px;
            width: 1%;
        }
    
        .style6
        {
            height: 28px;
            width: 1%;
        }
    
        .style7
        {
            height: 116px;
            width: 7%;
        }
        .style8
        {
            height: 28px;
            width: 7%;
        }
    
        .style9
        {
            width: 34%;
        }
        .style10
        {
            height: 116px;
            width: 34%;
        }
        .style11
        {
            height: 28px;
            width: 34%;
        }
    
    </style>
</head>
<body bgcolor="#bbbb88">
    <form id="form1" runat="server">
    <div style="margin-left:6cm;margin-top:4cm;background-color="#999966" >
    
    <table>
        <tr><td colspan="2"><h1> Pedidos a Clientes</h1></td></tr>
        <tr><td class="c1" ><h3><b>Empleado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cliente:</b></h3></td>
            <td><h3>Productos</h3></td></tr>
        <tr>
        <td class="c1">
            <asp:DropDownList ID="ddlEmpleados" runat="server" Height="16px" Width="113px">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlClientes" runat="server" Height="16px" Width="303px">
            </asp:DropDownList>
        </td>
        
          
       
        <td class="c3" >
         <asp:DropDownList ID="ddlproductos" runat="server" BackColor="White" 
             Font-Bold="True" ForeColor="#666633" Height="16px" 
                Width="264px" AutoPostBack="True" OnSelectedIndexChanged="ddlproductos_SelectedIndexChanged" >
        </asp:DropDownList>
        </td>
       
        </tr>

        <tr>
        <td class="style7" >
            &nbsp;</td>
        
     <td class="style2">
           <table>
            <tr>
                <td class="c1" style="width: 37%"><b>Precio:</b></td><td><asp:TextBox ID="txtprecio" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
             <td class="c1" style="width: 37%"><b>Unidades en Stock:</b></td><td><asp:TextBox ID="txtustock" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td class="c1" style="width: 37%"><b>Unidades en Pedido:</b></td><td><asp:TextBox ID="txtupedido" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>   
     </td>
      </tr>

       <tr>
       <td class="style8">
  
           &nbsp;</td>

       <td class="style6">
           &nbsp;</td>
       
       </tr>
        </table>

           <table width="65%">
        <tr><td colspan="2" class="style9"><h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Datos del Pedido</h2></td></tr>

        <tr>
        <td class="style10" >
            &nbsp;</td>
        
     <td class="style2">
           <table>
           <tr>
                <td class="c1" style="width: 37%"><b>Orden ID:</b></td><td colspan="2">
                <asp:Label ID="lblOrdenID" runat="server" Text=""></asp:Label>
                </td>
             </tr>
             <tr>
                <td class="c1" style="width: 37%"><b>Producto:</b></td><td colspan="2"><asp:TextBox ID="txtOProducto" runat="server"></asp:TextBox></td>
             </tr>
            <tr>
                <td class="c1" style="width: 37%"><b>Precio Unitario:</b></td><td><asp:TextBox ID="txtOPrecio" runat="server"></asp:TextBox></td><td>
                <asp:Button ID="btnAñadir"  runat="server" Font-Bold="True" ForeColor="#666633" 
                    Text="Añadir al Pedido" Width="138px" OnClick="btnAñadir_Click" />
                </td>
             </tr>
             <tr>
             <td class="c1" style="width: 37%"><b>Cantidad:</b></td><td><asp:TextBox ID="txtOCantidad" runat="server"></asp:TextBox></td><td>
                 <asp:Button ID="btnFinalizar" runat="server" Font-Bold="True" 
                     ForeColor="#666633" Text="Finalizar el Pedido" Width="137px" OnClick="btnFinalizar_Click" />
                 </td>
            </tr>
             <tr>
                <td class="c1" style="width: 37%"><b>Descuento:</b></td><td colspan="2"><asp:TextBox ID="txtODescuento" runat="server"></asp:TextBox></td>
            </tr>
        </table>   
     </td>
      </tr>

       <tr>
       <td class="style11">
  
    <asp:Button ID="btnGenerarPedido" runat="server" Text="Generar Pedido"  
                Font-Bold="True" ForeColor="#666633" Width="185px" OnClick="btnGenerarPedido_Click" />
  
              </td>

       <td class="style6">
           <asp:Button ID="btnBorrarPedido" runat="server" Text="Borrar Pedido"  
               Font-Bold="True" ForeColor="#666633" Width="211px" OnClick="btnBorrarPedido_Click"/></td>
       
       </tr>
        </table>
       
        
    </div>
  
    </form>
</body>
</html>
