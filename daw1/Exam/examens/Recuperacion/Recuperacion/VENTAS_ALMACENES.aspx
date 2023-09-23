<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VENTAS_ALMACENES.aspx.cs" Inherits="Recuperacion.VENTAS_ALMACENES" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type ="text/css">
        table{border-color:#999966;background-color:#999966;color:White;
            width: 89%;
        }
    td.c1{width:30%;}
   
    td.c3{width:30%; }
    h1,h2,h3{display:inline;color:White;}
    td.c4{ vertical-align:bottom;}
        
        .style2
        {
            height: 150px;
            width: 1%;
        }
    
        .style6
        {
            height: 28px;
            width: 1%;
        }
    
        .style7
        {
            height: 150px;
            width: 7%;
        }
        .style8
        {
            height: 28px;
            width: 7%;
        }
    
        .auto-style1 {
            width: 100%;
        }
    
        .auto-style2 {
            width: 1572px;
        }
        .auto-style3 {
            width: 62%;
        }
    
        .auto-style4 {
            width: 58%;
        }
        .auto-style5 {
            width: 343px;
        }
    
    </style>
</head>
<body bgcolor="#bbbb88">
    <form id="form1" runat="server">
    <div style="margin-top:4cm;background-color="#999966" class="auto-style2" >
    
    <table class="auto-style1">
        <tr><td colspan="3"><h1> Ventas a </h1>
          
           <h1> <asp:HyperLink ID="hlAlmacenes" runat="server">Almacenes</asp:HyperLink></h1>
          
        <tr><td class="c1" ><h3><b>Almacen:</b></h3>
            <asp:TextBox ID="txtNombreAlmacen" runat="server" Width="332px" OnTextChanged="txtNombreAlmacen_TextChanged"></asp:TextBox> 
              </td>
            <td colspan="2"><h3>Venta</h3>
            </td></tr>
        <tr>
        <td class="c1">
            <asp:DropDownList ID="ddlAlmacenes" runat="server" OnSelectedIndexChanged="ddlAlmacenes_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        
          
       
        <td colspan="2" class="c3" >
         <asp:DropDownList ID="ddlVentas" runat="server" BackColor="White" 
             Font-Bold="True" ForeColor="#666633" Height="16px" 
                Width="227px" OnSelectedIndexChanged="ddlVentas_SelectedIndexChanged">
        </asp:DropDownList>
        </td>
       
        </tr>

        <tr>
        <td class="style7" >
            <asp:ListBox ID="lstLibros" runat="server" Height="101px" Width="387px">
            </asp:ListBox>
            <asp:Label ID="lblnumlibros" runat="server"></asp:Label>
            </td>
        
     <td class="style2">
           <table class="auto-style3">
            <tr>
                <td class="c1"><b>Fecha:</b></td><td>
                <asp:Label ID="lblFechaVenta" runat="server"></asp:Label>
                </td>
             </tr>
             <tr>
             <td class="c1"><b>Precio:</b></td><td>
                 <asp:TextBox ID="txtPrecio" 
                    runat="server" Width="138px"></asp:TextBox></td>
            </tr>
             <tr>
                <td class="c1"><b>Cantidad:</b></td><td>
                 <asp:TextBox ID="txtCantidad" 
                     runat="server" Width="137px"></asp:TextBox></td>
            </tr>
               <tr>
                   <td>
                       <b>Total Venta:</b></td>
                       <td>
                           <asp:Label ID="lblTotalVenta" runat="server"></asp:Label>
</td>
               </tr>
        </table> 
         
     </td>
            <td class="auto-style5">
                <table class="auto-style4">
                    <tr>
                        <td>
               
                            <asp:RadioButtonList ID="RdbLMostrarDatos" runat="server">
                                <asp:ListItem>Almacen</asp:ListItem>
                                <asp:ListItem>Orden de Venta</asp:ListItem>
                            </asp:RadioButtonList>
               
                    </td></tr>
                    <tr><td class="style6"> <asp:Button ID="btnMostrarDatos" runat="server" Font-Bold="True" ForeColor="#666633" Width="214px" Text="Mostrar Datos" /></td></tr>
                   
                </table>
            </td>
      </tr>

      <tr><td colspan="3">
          <asp:Label ID="Label1" runat="server" Text="Nuevo Libro:"></asp:Label>
          <asp:TextBox ID="txtNuevoLibro" runat="server" Width="220px"></asp:TextBox>
          <asp:Label ID="Label2" runat="server" Text="Cantidad Nuevo Libro:"></asp:Label>
          <asp:TextBox ID="txtNuevaCantidad" runat="server"></asp:TextBox>
          <asp:Label ID="lblMensaje" runat="server"></asp:Label>
          </td></tr>
       <tr>
       <td class="style8" colspan="3">
  
           <asp:Button ID="btnAgregarLOV" runat="server" Text="Insertar nuevo Libro a la Venta" 
                               Font-Bold="True" ForeColor="#666633"
                               Width="222px"  />
  
    <asp:Button ID="btnBorrarOV" runat="server" Text="Borrar Libro de la Orden de Venta"  
                Font-Bold="True" ForeColor="#666633" Width="247px" 
                />
  
              </td>

      
       
       </tr>
        </table>
        
    </div>
  
    </form>
</body>
</html>

