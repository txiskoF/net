<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ExamenJunio.Pedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
    
   
</head>
<body >
    <form id="form1" runat="server">
        <div>
            <table >
                <tr><td colspan="5">
                    &nbsp;</td></tr>
                <tr><td colspan="6"><H1>Datos del Pedido</H1></td></tr>
                <tr><td colspan="5"><H2>Empleado</H2></td><td><h2>Productos</h2></td></tr>
                <tr><td>Empleado:</td><td>
                    <asp:TextBox ID="txtNombreEmpleado" runat="server" Width="235px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="LblNombre" runat="server" BackColor="#CCCCCC"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LblApellido1" runat="server" BackColor="#CCCCCC"></asp:Label>
                    </td>
                    <td>
                         <asp:Label ID="LblApellido2" runat="server" BackColor="#CCCCCC"></asp:Label>
                    </td>
                    <td rowspan="7">
                    <asp:ListBox ID="LstPedidos" runat="server" Height="368px" Width="373px">
                        </asp:ListBox></td>
                    <td rowspan="8"><asp:Label ID="LblEnvío" runat="server"></asp:Label></td>
                </tr>
              <tr>
                  <td>Dirección:</td>
                  <td colspan="4">
                      <asp:TextBox ID="TxtPoblacion" runat="server" Width="606px"></asp:TextBox>
                  </td>
              </tr>
                <tr>
                  <td class="auto-style3">CP:</td>
                  <td colspan="4" class="auto-style3">
                      <asp:Label ID="LblCP" runat="server" BackColor="#CCCCCC"></asp:Label> 
                  </td>
              </tr>
                <tr>
                  <td class="auto-style2">Población:</td>
                  <td colspan="4" class="auto-style2">
                      <asp:Label ID="LblPoblacion" runat="server" BackColor="#CCCCCC"></asp:Label> 
                  </td>
              </tr>
                <tr>
                  <td class="auto-style4">Provincia:</td>
                  <td colspan="4" class="auto-style4">
                      <asp:Label ID="LblProvincia" runat="server" BackColor="#CCCCCC"></asp:Label> 
                  </td>
              </tr>
                <tr><td colspan="5" ><h2>Envío</h2></td></tr>
              <tr>
                 
                  <td colspan="5">
                      
                    <asp:Panel ID="PnlClaseEnvio"  GroupingText="Clase Envío" Font-Names="Times new roman"  runat="server" Width="207px" Height="86px">
                    <asp:RadioButton ID="RdbNormal" Text="Normal" runat="server" /><br />
                    <asp:RadioButton ID="RdbFragil" Text= "Fragil" runat="server" />
                    </asp:Panel>
                    
                     
                  </td>
              </tr>
                <tr><td>
                    
                 
                    <asp:Panel ID="PnlTipoEnvio" GroupingText="Tipo Envío" Font-Names="Times new roman" runat="server">
                        <asp:RadioButtonList ID="RdbTipoEnvio"  runat="server" Width="159px">
                        <asp:ListItem>Ordinario</asp:ListItem>
                        <asp:ListItem>Urgente</asp:ListItem>
                        <asp:ListItem>En 1 hora</asp:ListItem>
                     </asp:RadioButtonList>
                    </asp:Panel>
                    

                    
                </td><td>
                          <asp:Panel ID="PnlPaqueteria" GroupingText="Servicio de Envío" Font-Names="Times new roman" runat="server" Height="111px">
                        <asp:RadioButtonList ID="RdbPaqueteria"  runat="server" Width="159px">
                        <asp:ListItem>Correos</asp:ListItem>
                        <asp:ListItem>MRW</asp:ListItem>
                        <asp:ListItem>SEUR</asp:ListItem>
                     </asp:RadioButtonList>
                    </asp:Panel>

                          </td><td colspan="3">
                              <asp:Panel ID="PnlRecepcionPedido" GroupingText="Recepción del Pedido" Font-Names="Times new roman" runat="server">
                                  <asp:CheckBoxList ID="ChkRecepcion" runat="server" Width="237px" OnSelectedIndexChanged="ChkRecepcion_SelectedIndexChanged">
                                      <asp:ListItem>SMS</asp:ListItem>
                                      <asp:ListItem>Correo Electrónico</asp:ListItem>
                                      <asp:ListItem>Llamada Telefónica</asp:ListItem>
                                  </asp:CheckBoxList>

                              </asp:Panel>
                               </td>
                      <td>
                          <asp:Button ID="BtnEnvio" runat="server" Text="Procesar Envío" Height="103px" Width="369px" /></td>
                </tr>
                
                     
                     
            </table>
        </div>
    </form>
</body>
</html>
