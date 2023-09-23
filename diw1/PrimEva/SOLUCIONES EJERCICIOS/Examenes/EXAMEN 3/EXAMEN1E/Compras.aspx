<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compras.aspx.cs" Inherits="Compras" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="ESTILOS/estilo.css" />
</head>
<body >
    <form id="form1" runat="server" width="100%">
     <div class="page">
      <div class="cabecera"></div>
       <div class="main">
    <table>
    <tr><td colspan="3" ><h1>Verduras y Frutas Ecológicas</h1> </td>
      <td>  
          <asp:Image ID="img1" ImageUrl="IMAGENES/logo.jpg" runat="server" 
            Height="128px" Width="256px" />
        </td></tr>
    <tr><td colspan="4">
      
        </td></tr>

        <tr><td class="style2"><b>Correo Electrónico:</b></td><td>
            <asp:TextBox ID="txtcorreo" runat="server" Width="334px"></asp:TextBox>
        </td>
        <td class="style2"><b>Nombre:</b></td><td>
            <asp:TextBox ID="txtnombre" runat="server" Width="334px"></asp:TextBox>
        </td>
        </tr>
    <tr><td class="style2"><b>Dirección:</b></td><td class="style3"><asp:TextBox ID="txtdireccion" 
            runat="server" Width="334px"></asp:TextBox>
        </td>
    <td><b>Organización:</b></td><td><asp:TextBox ID="txtorganizacion" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td class="style2"><b>Población:</b></td><td class="style3"><asp:TextBox ID="txtpoblacion" runat="server"></asp:TextBox></td>
    <td>&nbsp;</td><td>&nbsp;</td>
    </tr>
   
        

    <tr><td class="style1" colspan="2"><h2 style="width: 350px">Verduras y Frutas</h2>
        <asp:RadioButton ID="rdbfrutas" runat="server" Text="FRUTAS" 
             />
    
    
        <br />
        <asp:RadioButton ID="rdbverduras" runat="server" 
            Text="VERDURAS"/>
        <br />
        <asp:RadioButton ID="rdbplatos" runat="server" Text="PLATOS PREPARADOS" />
    
    
    </td><td width="450"></td><td><h2>Su Cesta:</h2></td></tr>
    <tr>
        <td valign="top" class="style2">
            <asp:Panel ID="pnlfrutas" runat="server" Height="100px" GroupingText="Frutas">
               
                <asp:RadioButtonList ID="rdblfrutas" runat="server">
                    <asp:ListItem>Fresas</asp:ListItem>
                    <asp:ListItem>Manzanas</asp:ListItem>
                    <asp:ListItem>Naranjas</asp:ListItem>
                    <asp:ListItem>Platanos</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
             <asp:Panel ID="pnlverduras" runat="server" Height="100px" 
                GroupingText="Verduras">
                
                <asp:RadioButtonList ID="rdblverduras" runat="server">
                    <asp:ListItem>Berenjenas</asp:ListItem>
                    <asp:ListItem>Calabacín</asp:ListItem>
                    <asp:ListItem>Pimientos</asp:ListItem>
                    <asp:ListItem>Vainas</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
             <asp:Panel ID="pnlplatos" runat="server" Height="100px" 
                GroupingText="Platos Preparados">
            
                <asp:RadioButtonList ID="rdblplatos" runat="server">
                    <asp:ListItem>Albondigas</asp:ListItem>
                    <asp:ListItem>Canelones</asp:ListItem>
                    <asp:ListItem>Ensaladilla Rusa</asp:ListItem>
                    <asp:ListItem>Lasagna</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
        </td>
         <td valign="top" class="style3" >
                <asp:TextBox ID="txtcantidad" runat="server" Width="116px"></asp:TextBox>
                <asp:ImageButton ID="tmgproducto" runat="server" 
                    ImageUrl="~/IMAGENES/logo.jpg" Width="124px" />
                </td>
            <td>
               
                &nbsp;</td>
          <td><asp:ListBox ID="lstcesta" runat="server" Height="100px" Width="150px">
            </asp:ListBox>
              
              <asp:CheckBox ID="chkmultiple" runat="server" Text="Más Productos" />
              
              <asp:Button ID="btnborrarP" runat="server" Text="Borrar Producto" 
                  Width="150px" />
              <br />
              <asp:Button ID="btnfinalizar" runat="server" Text="Finalizar Pedido" 
                  Width="150px"  />
        </td>
             </tr>
             <tr>
             <td>
                 <asp:CheckBox ID="chktransporte" runat="server" Text="Transporte a domicilio" />
             
             </td>
             <td>
                 <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label></td>
                 <td>
                     <asp:Label ID="lbltiempoPedido" runat="server" Text="Tiempo:"></asp:Label></td>
             <td align="right"> 
                <h2> <asp:Label ID="lbltotalPedido" runat="server" Text="Total: "></asp:Label> 
                 &nbsp; 
                 <asp:Label ID="lblprecio" runat="server" Text=""></asp:Label></h2>
                 </td>
             </tr>
    </table>
    </div>
    </div>
    </form>
</body>
</html>
