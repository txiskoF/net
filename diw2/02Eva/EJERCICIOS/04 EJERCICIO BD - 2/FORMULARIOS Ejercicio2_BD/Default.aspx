<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css" >
    table{border-top:double;border-top-width:2px;border-top-color:#6699ff;
          border-bottom:double;border-bottom-width:2px;border-bottom-color:#6699ff;}
    td{background-color:#999966; color:#FFFFFF;
            font-weight: 700;
        }
    h2{display:inline;}

        .auto-style2 {
            width: 206px;
        }

        .auto-style19 {
            width: 213px;
        }

        .auto-style20 {
            width: 879px;
        }
        .auto-style21 {
            width: 879px;
            height: 235px;
        }

        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    
    
  
    <tr><td class="A" colspan="5"><h2>Descripción de Productos</h2></td></tr>
    
  
    <tr><td class="style13"> <b>Id. Producto:</b></td><td class="A"> 
            <asp:Label ID="LblIdProducto" runat="server"></asp:Label>
        </td><td class="style15" > 
            <strong>Nombre</strong><b>:</b></td><td class="auto-style19">
            <asp:Label ID="LblProducto" runat="server"></asp:Label>
        </td><td class="auto-style2">
                    &nbsp;</td></tr>
    
  
    <tr><td class="style13"> <strong>Precio</strong><b>:</b></td><td class="A"> 
            <asp:Label ID="LblPrecio" runat="server"></asp:Label>
        </td><td class="style15" >  <b>Unidades en Stock:</b></td>
           <td class="auto-style19"> 
               <asp:Label ID="LblStock" runat="server"></asp:Label>
        </td><td class="auto-style2">
                    Unidades en Pedido:  <b>
                    <asp:TextBox ID="TxtUnidadesPedido" runat="server"></asp:TextBox>
                    </b>
        </td></tr>
    
  
    <tr>
    <td class="style14" colspan="2">
        <asp:CheckBox ID="chkdiscontinuo" runat="server" Text="Discontinuo" />
        </td> 
    <td class="style16"> 
               <b>Nivel nuevo pedido:</b></td><td class="auto-style19" >
               <asp:Label ID="LblNivel" runat="server"></asp:Label>
                   </td>
                   <td class="auto-style2">
                       &nbsp;</td></tr>
    
  
    </table>
        <br />
         <table>
    
    
  
    <tr><td class="auto-style20" colspan="5"><h2>Descripción del Pedido</h2></td></tr>
<tr><td class="auto-style21" colspan="5">
    <asp:TextBox ID="TxtPedido" runat="server" Height="307px" TextMode="MultiLine" Width="872px"></asp:TextBox></td></tr>
             </table>
    </div>
</body>
</html>
