<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PRODUCTOS.aspx.cs" Inherits="CONECTADO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            color: #999999;
        }
    </style>
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr><td colspan="5" class="style6"><h2>Categoria</h2></td></tr>
    <tr>
    <td class="A" width="200" colspan="2">
    Identificativo Categoria:</td><td class="auto-style1">
            <asp:TextBox ID="txtidcat" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="149px"></asp:TextBox></td>
                <td class="style17">
                    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" 
                        BackColor="White" Font-Bold="True" ForeColor="#999999" Height="25px" 
                        TabIndex="1" Width="144px" style="margin-left: 0px" /></td>
                <td>
                    <asp:Button ID="btnmostraPr" runat="server" Text="Mostrar Productos" 
                        BackColor="White" Font-Bold="True" ForeColor="#999999" Height="25px" 
                        TabIndex="1" Width="159px" style="margin-left: 0px" /></td>
                      
                      
    </tr>
    <tr><td class="A" colspan="2">Nombre Categoría:</td><td class="style3" colspan="2"> 
        <asp:TextBox ID="txtnombrecat" 
            runat="server" Font-Bold="True" Width="270px" ForeColor="#999999"></asp:TextBox></td><td class="A">
                    <h2>Productos</h2></td></tr>
    
    <tr><td class="A" colspan="2">Descripción:</td><td class="style3" colspan="2"> 
        <asp:TextBox ID="txtdescripcion" 
            runat="server" Width="275px" Height="111px"  Font-Bold="True" TextMode="MultiLine" ForeColor="#999999"></asp:TextBox></td><td class="A">
            <asp:ListBox ID="lstproductos" runat="server" Font-Bold="True" Height="110px" Width="154px" ForeColor="#999999">
            </asp:ListBox>
        </td></tr>
    
   
    
  
    <tr><td class="style2" colspan="5" bgcolor="White"></td></tr>
    
  
    <tr><td class="A" colspan="5"><h2>Descripción de Productos</h2></td></tr>
    
  
    <tr><td class="style13">Id. Producto:</td><td class="A"> 
            <asp:TextBox ID="txtidproducto" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="122px"></asp:TextBox></td><td class="style15" > 
            Nombre:</td><td class="style17">
            <asp:TextBox ID="txtnombrepro" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="134px"></asp:TextBox></td><td class="A">
                    <asp:Button ID="btninsertar" runat="server" Text="Insertar Producto" 
                        BackColor="White" Font-Bold="True" ForeColor="#999999" Height="25px" 
                                Width="159px" />
                   </td></tr>
    
  
    <tr><td class="style13">Precio:</td><td class="A"> 
            <asp:TextBox ID="txtprecio" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="122px"></asp:TextBox></td><td class="style15" > Unidades en Stock:</td>
           <td class="style17"> 
               <asp:TextBox ID="txtstock" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="134px"></asp:TextBox></td><td class="A">
                    <asp:Button ID="btnmodificar" runat="server" Text="Modificar Producto" 
                        BackColor="White" Font-Bold="True" ForeColor="#999999" Height="25px" 
                                Width="158px" />
                   </td></tr>
    
  
    <tr>
    <td class="style14" colspan="2">
        <asp:CheckBox ID="chkdiscontinuo" runat="server" Text="Discontinuo" />
        </td> 
    <td class="style16"> 
               Nivel nuevo pedido:</td><td class="style8" >
               <asp:TextBox ID="txtnivel" runat="server" 
                Font-Bold="True" ForeColor="#999999" style="margin-left: 0px" 
                Width="134px"></asp:TextBox>
                   </td>
                   <td class="A">
                    <asp:Button ID="btnpedido" runat="server" Text="Petición Productos" 
                        BackColor="White" Font-Bold="True" ForeColor="#999999" Height="25px" 
                                Width="156px" />
                   </td></tr>
    
  
    </table>
    </div>
    </form>
</body>
</html>
