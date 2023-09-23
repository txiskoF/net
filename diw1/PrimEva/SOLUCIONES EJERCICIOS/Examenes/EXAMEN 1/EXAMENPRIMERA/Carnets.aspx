<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Carnets.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="~/Styles/EjemploInicial.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
      <div class="cabecera">
        
            <h1>Gimnasio Tickets</h1>
         
       </div>
       <div class="main">
           <asp:Panel ID="pnlDatosPersonales" runat="server" 
               GroupingText="Datos Personales" Height="224px">
            
            <div class="izquierda">
           <asp:Label ID="lbletiqueta" runat="server" Text="Código Cliente" CssClass ="label "></asp:Label>
           <asp:TextBox ID="txtCodigo" runat="server" Width="178px"></asp:TextBox>

           <asp:Label ID="Label1" runat="server" Text="Nombre Cliente" CssClass ="label "></asp:Label>
               
           <asp:TextBox ID="txtNombre" runat="server" Width="181px"></asp:TextBox>
           
            <asp:Label ID="Label2" runat="server" Text="Fecha Nacimiento" CssClass ="label " 
                    Width="114px"></asp:Label>
           <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="178px"></asp:TextBox> 
               <!-- <asp:Panel ID="pnlsexo" runat="server" GroupingText="Sexo" Width="116px"  >-->
                  <asp:Label ID="Label5" runat="server" Text="Sexo" CssClass ="label "></asp:Label>
                    <asp:RadioButton ID="rdbhombre" runat="server"  Text ="Hombre" CssClass ="radioB"/>
                     <br />
                     <asp:RadioButton ID="rdbmujer" runat="server" Text="Mujer" />
                <!--</asp:Panel>-->
           </div>
              <div class="medio">
              <asp:Label ID="Label3" runat="server" Text="Fotografía Cliente" CssClass ="label "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>

                  <asp:Label ID="Label6" runat="server" Text="Beneficiarios a su Cargo" CssClass ="label "></asp:Label>
                  <asp:CheckBox ID="chkmenores" runat="server" Text ="Menores de 18 años" />
                  <asp:TextBox ID="txtCargosMenores" runat="server" Width="38px" CssClass ="textos"></asp:TextBox>
                   <asp:CheckBox ID="chkmediana" runat="server" Text ="Mayores de 18 años" />
                  <asp:TextBox ID="txtCargosMedianos" runat="server" Width="38px" CssClass ="textos"></asp:TextBox>
                </div>
              <div class="derecha">
                <asp:Label ID="Label4" runat="server" Text="Foto" CssClass ="label1 " ></asp:Label>
               <asp:Image ID="Image1" runat="server" Width="100px" CssClass ="imagen" Height="140px"/>
               </div>
               </asp:Panel> 
             
              <asp:Panel ID="pnlactividades" runat="server" GroupingText="Actividades"  CssClass ="panel" >
              <div class="izquierda ">
                  <asp:RadioButtonList ID="rdbactividades" runat="server">
                      <asp:ListItem>Actividades de Tierra</asp:ListItem>
                      <asp:ListItem>Actividades de Agua</asp:ListItem>
                  </asp:RadioButtonList>
                   <asp:TextBox ID="txtnuevaActividad" runat="server" Width="178px" CssClass="btnlista"></asp:TextBox> 
                  <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btnlista" />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" CssClass="btnlista"/>
              </div>
           
              <div class="medio">
                <asp:RadioButtonList ID="rdbentradas" runat="server">

                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>Bono 5</asp:ListItem>
                    <asp:ListItem>Bono 10</asp:ListItem>
                    <asp:ListItem>Bono Mensual</asp:ListItem>
                    <asp:ListItem>Bono Anual</asp:ListItem>

                  </asp:RadioButtonList>
                </div>

               <div class="derecha">
                   <asp:CheckBox ID="chkTicket" runat="server" Text ="Generar Ticket" />
                   <asp:Button ID="btnGenerar" runat="server" Text="Generar" Width="121px" CssClass="btn"/>
                   <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" Width="121px" CssClass="btn" />
                 </div>
               </asp:Panel> 
             
              <asp:Panel ID="pnlTicket" runat="server" GroupingText="Ticket"   >
                  <asp:TextBox ID="txtticket" runat="server" Height="150px" TextMode="MultiLine" 
                      Width="525px"></asp:TextBox>
                      <asp:Button ID="btnImprimir" runat="server" Text="Imprimir" Width="121px"  CssClass="btnimp"/>
                </asp:Panel> 
          
               
       </div>
  </div>
    </form>
</body>
</html>
