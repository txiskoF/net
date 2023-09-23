<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EXAMEN_TIPO.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title></title>
    <link href="STYLES/estilo.css" rel="stylesheet" />
   
    <style type="text/css">
        .auto-style36 {
            height: 33px;
        }
        .auto-style37 {
            position: absolute;
            top: 9px;
            left: 21px;
            z-index: 1;
            width: 903px;
            height: 330px;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ofertas Exclusivas Clientes </h2>
            <table class="auto-style33">
                 <tr><td colspan="4"><b>Datos Personales</b></td>
                    
                     <td><b>Compra Lote</b></td>
                     <td><b>Compra Ojos</b></td>
                      <td><b>Regalos</b></td>
                 </tr>
                <tr>
                    <td>Nombre: </td><td class="auto-style16"><asp:TextBox ID="TxtNombre" runat="server" Width="226px" AutoPostBack="True" OnTextChanged="PasarFoco"></asp:TextBox></td>
                    <td>Correo electrónico: </td><td><asp:TextBox ID="TxtCorreo" runat="server" Width="310px" AutoPostBack="True" OnTextChanged="PasarFoco" ></asp:TextBox></td>
                    <td rowspan="9" ><asp:PlaceHolder ID="PhCompras" runat="server"></asp:PlaceHolder>
                    <td rowspan="8" ><asp:PlaceHolder ID="PhOjos" runat="server"></asp:PlaceHolder></td>
                     </td>
                    <td rowspan="8" ><asp:PlaceHolder ID="PhRegalo" runat="server"></asp:PlaceHolder>
                     </td>
                </tr>
                <tr>
                  
                    <td class="auto-style36">Móvil: </td><td colspan="3" class="auto-style36"><asp:TextBox ID="TxtMovil" runat="server" Width="225px" AutoPostBack="True" OnTextChanged="PasarFoco"></asp:TextBox></td>
                </tr>
                <tr><td colspan="2"><b>Dirección de Envío</b></td></tr>
                <tr>
                    <td>Dirección: </td><td class="auto-style16"><asp:TextBox ID="TxtDireccionE" runat="server" Width="224px" AutoPostBack="True" OnTextChanged="PasarFoco"></asp:TextBox></td>
                    <td>CP: </td><td><asp:TextBox ID="TxtCPE" runat="server" AutoPostBack="True" OnTextChanged="PasarFoco"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Población: </td><td class="auto-style16"><asp:TextBox ID="TxtPoblacionE" runat="server" Width="224px" AutoPostBack="True" OnTextChanged="PasarFoco"></asp:TextBox></td>
                    <td>Provincia: </td><td><asp:TextBox ID="TxtProvinciaE" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        
             <asp:Panel ID="PnlOfertas" runat="server" CssClass="auto-style24">
                 <asp:Panel ID="PnlMarcas" runat="server" CssClass="auto-style25" GroupingText="LOTES MAQUILLAJE ">
                     <asp:RadioButtonList ID="RdblMarcas" runat="server" Font-Names="Arial" Font-Size="Small" Width="280px"  AutoPostBack="True" OnSelectedIndexChanged="RdblMarcas_SelectedIndexChanged">
                         <asp:ListItem>Lote CLARINS</asp:ListItem>
                         <asp:ListItem>Lote LANCOME</asp:ListItem>
                         <asp:ListItem>Lote SHISEIDO</asp:ListItem>
                     </asp:RadioButtonList>
                 </asp:Panel>
                 <asp:Panel ID="PnlClarins" runat="server" CssClass="auto-style26" GroupingText="Lote CLARINS" Visible="False">
                     <asp:CheckBoxList ID="ChklClarins" runat="server" Font-Size="Small" Width="354px" AutoPostBack="True" OnSelectedIndexChanged="ChklClarins_SelectedIndexChanged">
                         <asp:ListItem Value="39,75">Maquillaje Teint Multi-Regenerant (39.75€)</asp:ListItem>
                         <asp:ListItem Value="32,40">Colorete Blush Prodige (32.40€)</asp:ListItem>
                         <asp:ListItem Value="21,15">Labios Joli Rouge (21.15€)</asp:ListItem>
                     </asp:CheckBoxList>
                 </asp:Panel>
                 <asp:Panel ID="PnlLancome" runat="server" CssClass="auto-style27" GroupingText="Lote LANCOME" Visible="False">
                     <asp:CheckBoxList ID="ChklLancome" runat="server" Font-Size="Small" AutoPostBack="True" OnSelectedIndexChanged="ChklLancome_SelectedIndexChanged">
                         <asp:ListItem Value="48,50">Maquillaje Teint Visionnaire (48.50 €)</asp:ListItem>
                         <asp:ListItem Value="32,25">Colorete Blush Subtil (32.25€)</asp:ListItem>
                         <asp:ListItem Value="25,50">Labios L&#39;Absolu Rouge Cream (25.50€)</asp:ListItem>
                     </asp:CheckBoxList>
                 </asp:Panel>
                 <asp:Panel ID="PnlShiseido" runat="server" CssClass="auto-style28" GroupingText="Lote SHISEIDO" Visible="False">
                     <asp:CheckBoxList ID="ChklShiseido" runat="server" Font-Size="Small"  Width="412px" AutoPostBack="True">
                         <asp:ListItem Value="40,75">Maquillaje Syncro Skin Lasting Foundation (40.75€)</asp:ListItem>
                         <asp:ListItem Value="36,60">Colorete Blush Innerglow Chhekpowder (36.60€)</asp:ListItem>
                         <asp:ListItem Value="27,25">Labios Visionary Gel Lipstick (27.25€)</asp:ListItem>
                     </asp:CheckBoxList>
                 </asp:Panel>
                 <asp:Button ID="BtnComprar" runat="server" CssClass="auto-style30"  Text="Comprar" Visible="False" OnClick="BtnComprar_Click" />
                 <asp:Panel ID="PnlOjos" runat="server" CssClass="auto-style29" GroupingText="Lote Ojos" Visible="False">
                     <asp:CheckBoxList ID="ChklOjos" runat="server" CellPadding="4" CellSpacing="4" Font-Size="Small" RepeatDirection="Horizontal"  AutoPostBack="True" OnSelectedIndexChanged="ChklOjos_SelectedIndexChanged">
                         <asp:ListItem Value="39,90">Sombras Ombre Mineral 4 Colours (39.90 €)</asp:ListItem>
                         <asp:ListItem Value="10,9">Lapiz Ojos Feutre (10.90€)</asp:ListItem>
                         <asp:ListItem Value="23,95">Mascara Supra Volumen (23.95€)</asp:ListItem>
                     </asp:CheckBoxList>
                 </asp:Panel>
                 n</asp:Panel>
            <asp:Panel ID="PnlFactura" runat="server" CssClass="auto-style23" Visible="False">
                <asp:Label ID="LblCompra" runat="server" CssClass="auto-style37"></asp:Label>
                <asp:Button ID="BtnFinalizarCompra" runat="server" Text="Finalizar Compra" CssClass="auto-style32" OnClick="BtnFinalizarCompra_Click" />
        <asp:Button ID="BtnSeguirComprando" runat="server"  
            Text="Seguir Comprando" CssClass="auto-style22" OnClick="BtnSeguirComprando_Click"   />
                
                <asp:Button ID="BtnEnviarCompra" runat="server" CssClass="auto-style35" Text="Enviar Compra" OnClick="BtnEnviarCompra_Click" />
                
        </asp:Panel>
            </div>
    </form>
</body>
</html>
