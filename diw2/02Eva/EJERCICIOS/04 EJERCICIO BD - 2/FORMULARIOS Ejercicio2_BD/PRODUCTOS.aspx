<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PRODUCTOS.aspx.cs" Inherits="CONECTADO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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

        .auto-style1 {
            position: relative;
            left: 0px;
            top: 0px;
            width: 150px;
            height: 40px;
        }

        .auto-style2 {
            width: 206px;
        }

        .auto-style3 {
            height: 129px;
        }
        .auto-style4 {
            width: 206px;
            height: 129px;
        }
        .auto-style5 {
            margin-left: 0px;
        }

        .auto-style6 {
            position: absolute;
            top: 420px;
            left: 126px;
            z-index: 3;
            height: 28px;
        }
        .auto-style7 {
            position: absolute;
            top: 421px;
            left: 126px;
            z-index: 2;
        }
        .auto-style8 {
            position: absolute;
            top: 397px;
            left: 436px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 394px;
            left: 436px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 424px;
            left: 436px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 421px;
            left: 435px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 450px;
            left: 436px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 448px;
            left: 434px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 395px;
            left: 600px;
            z-index: -1;
            height: 28px;
        }
        .auto-style15 {
            position: absolute;
            top: 394px;
            left: 637px;
            z-index: -1;
            width: 26px;
            height: 28px;
        }
        .auto-style16 {
            position: absolute;
            top: 396px;
            left: 600px;
            z-index: 1;
            width: 20px;
            height: 19px;
        }
        .auto-style17 {
            position: absolute;
            top: 394px;
            left: 633px;
            z-index: 1;
        }

        .auto-style18 {
            position: absolute;
            top: 423px;
            left: 600px;
            z-index: 1;
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
    <b>Identificativo Categoria:</b></td><td class="style15">
            <asp:TextBox ID="txtidcategoria" runat="server" 
                Font-Bold="True" ForeColor="#6699FF" style="margin-left: 0px" 
                Width="158px"></asp:TextBox></td>
                <td class="style17">
                    <asp:Button ID="btnbuscar" runat="server" Text="BUSCAR" 
                        BackColor="#bbbb88" Font-Bold="True" ForeColor="#FFFFFF" 
                        TabIndex="1" style="margin-left: 0px" OnClick="btnbuscar_Click" CssClass="auto-style1" /></td>
                <td class="auto-style2">
                    <asp:Button ID="btnmostraPr" runat="server" Text="MOSTRAR PRODUCTOS" 
                        BackColor="#bbbb88" Font-Bold="True" ForeColor="#ffffff" Height="44px" 
                        TabIndex="1" Width="203px" style="margin-left: 0px" OnClick="btnmostraPr_Click" /></td>
                      
                      
    </tr>
    <tr><td class="A" colspan="2"><b>Nombre Categoría:</b></td><td class="style3" colspan="2"> 
        <asp:TextBox ID="txtnombrecat" 
            runat="server" Width="308px"></asp:TextBox></td><td class="auto-style2">
                    <h2>Productos</h2></td></tr>
    
    <tr><td class="auto-style3" colspan="2"><strong>Descripción</strong><b>:</b></td><td class="auto-style3" colspan="2"> 
        <br />
        <asp:TextBox ID="txtdescripcion" 
            runat="server" Width="300px" Height="78px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <br />
        </td><td class="auto-style4">
            <asp:ListBox ID="lstproductos" runat="server" Height="175px" Width="204px" AutoPostBack="True" OnSelectedIndexChanged="lstproductos_SelectedIndexChanged" CssClass="auto-style5">
            </asp:ListBox>
        </td></tr>
    
   
    
  
    <tr><td class="style2" colspan="5" bgcolor="White"></td></tr>
    
  
    <tr><td class="A" colspan="5"><h2>Descripción de Productos</h2></td></tr>
    
  
    <tr><td class="style13"> <b>Id. Producto:</b></td><td class="A"> 
            <asp:Label ID="LblIdProducto" runat="server"></asp:Label>
        </td><td class="style15" > 
            <strong>Nombre</strong><b>:</b></td><td class="style17">
            <asp:Label ID="LblNombrePro" runat="server" CssClass="auto-style8"></asp:Label>
            <asp:TextBox ID="txtnombrepro" runat="server" 
                Font-Bold="True" ForeColor="#6699FF" style="margin-left: 0px; " 
                Width="141px" CssClass="auto-style9"></asp:TextBox></td><td class="auto-style2">
                    <asp:ImageButton ID="ImgGuardar" runat="server" Height="20px" ImageUrl="~/imagenes/Guardar.png" Width="20px"  CssClass="auto-style14" />
                    <asp:ImageButton ID="ImgNueva" runat="server" ImageUrl="~/imagenes/Nueva.png" CssClass="auto-style16" />
                    <asp:ImageButton ID="ImgEliminar" runat="server" Height="20px" ImageUrl="~/imagenes/eliminar.png" Width="20px" CssClass="auto-style17" />
                    <asp:ImageButton ID="ImgCancelar" runat="server"  Height="20px" ImageUrl="~/imagenes/Cancelar.png" CssClass="auto-style15" />
                   </td></tr>
    
  
    <tr><td class="style13"> <strong>Precio</strong><b>:</b></td><td class="A"> 
            <asp:Label ID="LblPrecio" runat="server" CssClass="auto-style6"></asp:Label>
            <asp:TextBox ID="txtprecio" runat="server" 
                Font-Bold="True" ForeColor="#FFFFFF" style="margin-left: 0px; " 
                Width="122px" CssClass="auto-style7"></asp:TextBox></td><td class="style15" >  <b>Unidades en Stock:</b></td>
           <td class="style17"> 
               <asp:Label ID="LblStock" runat="server" CssClass="auto-style10"></asp:Label>
               <asp:TextBox ID="txtstock" runat="server" 
                Font-Bold="True" ForeColor="#6699FF" style="margin-left: 0px; " 
                Width="140px" CssClass="auto-style11"></asp:TextBox></td><td class="auto-style2">
                    <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style18" Height="19px" ImageUrl="~/imagenes/edit.png" Width="25px" />
        </td></tr>
    
  
    <tr>
    <td class="style14" colspan="2">
        <asp:CheckBox ID="chkdiscontinuo" runat="server" Text="Discontinuo" />
        </td> 
    <td class="style16"> 
               <b>Nivel nuevo pedido:</b></td><td class="style8" >
               <asp:Label ID="LblNivel" runat="server" CssClass="auto-style12"></asp:Label>
               <asp:TextBox ID="txtnivel" runat="server" 
                Font-Bold="True" ForeColor="#6699FF" style="margin-left: 0px; " 
                Width="141px" CssClass="auto-style13"></asp:TextBox>
                   </td>
                   <td class="auto-style2">
                    <asp:Button ID="btnpedido" runat="server" Text="Petición Productos" 
                        BackColor="#bbbb88" Font-Bold="True" ForeColor="#FFFFFF" Height="25px" 
                                Width="201px" OnClick="btnpedido_Click" />
                   </td></tr>
    
  
    </table>
    </div>
    </form>
</body>
</html>
