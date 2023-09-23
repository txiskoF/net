<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PresupuestosClientes.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="~/Styles/EjemploInicial.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 474px;
            left: 577px;
            z-index: 1;
            height: 14px;
        }
        .auto-style2 {
            position: absolute;
            top: 473px;
            left: 468px;
            z-index: 1;
            width: 100px;
            height: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
      <div class="cabecera">
        
            <h1>Agencia de Viajes  Limusín</h1>
         
       </div>
       <div class="main">
           <asp:Panel ID="PnlDatosPersonales" runat="server" 
               GroupingText="Datos Personales" Height="255px">
            
            <div class="izquierda">
           <asp:Label ID="lbletiqueta" runat="server" Text="Código Cliente" CssClass ="label "></asp:Label>
           <asp:TextBox ID="TxtCodigo" runat="server" Width="178px"></asp:TextBox>

           <asp:Label ID="Label1" runat="server" Text="Nombre Cliente" CssClass ="label "></asp:Label>
               
           <asp:TextBox ID="TxtNombre" runat="server" Width="181px"></asp:TextBox>
           
            <asp:Label ID="Label2" runat="server" Text="Fecha Nacimiento" CssClass ="label " 
                    Width="114px"></asp:Label>
           <asp:TextBox ID="TxtFechaNacimiento" runat="server" Width="178px"></asp:TextBox> 
               <!-- <asp:Panel ID="pnlsexo" runat="server" GroupingText="Sexo" Width="116px"  >-->
                  <asp:Label ID="Label5" runat="server" Text="Tipo Persona" CssClass ="label "></asp:Label>
                <asp:CheckBox ID="ChkAdultos" runat="server" Text="Adultos" />
                <asp:TextBox ID="TxtAdultos" runat="server" Width="29px"></asp:TextBox>
                <BR />
                    <asp:CheckBox ID="ChkMayores" runat="server" Text="Tercera Edad" />
                <asp:TextBox ID="TxtMayores" runat="server" Width="29px"></asp:TextBox>
                     <br />
                <!--</asp:Panel>-->
                <asp:CheckBox ID="ChkNiños" runat="server" Text="Niños" />
                <asp:TextBox ID="TxtNiños" runat="server" Width="29px"></asp:TextBox>
           </div>
              <div class="medio">
              <asp:Label ID="Label3" runat="server" Text="Tipo Viaje" CssClass ="label "></asp:Label>
                <asp:TextBox ID="TxtTipoViaje" runat="server" Width="192px"></asp:TextBox>

                  <asp:Label ID="lblPrecio" runat="server" CssClass ="label "></asp:Label>
                </div>
              <div class="derecha">
                <asp:Label ID="Label4" runat="server" Text="Foto" CssClass ="label1 " ></asp:Label>
               <asp:Image ID="imgViaje" runat="server" Width="100px" CssClass ="imagen" 
                      Height="140px"/>
               </div>
               </asp:Panel> 
             
              <asp:Panel ID="PnlViajes" runat="server" GroupingText="Viajes"  
               CssClass ="panel" Height="204px" >
              <div class="izquierda ">
                  <asp:RadioButton ID="rdbcrucero" runat="server" Text="Crucero" /><BR />
                  <asp:RadioButton ID="rdbvviajeorganizado" runat="server" Text="Viajes Organizados" /><BR/>
                  <asp:RadioButton ID="rdbviajepropia" runat="server" Text="Viajes Por Cuenta Propia" /><BR/>
                  <BR/>
                    <asp:Label ID="LblDias" runat="server" CssClass="auto-style2" Text="Nº de días:"></asp:Label>
                   <asp:TextBox ID="TxtDias" runat="server" CssClass="auto-style1" Width="87px"></asp:TextBox>
              </div>
           
              <div class="medio">
                <asp:RadioButtonList ID="rdbViajes" runat="server">

                  </asp:RadioButtonList>
                  <asp:TextBox ID="txtnuevoviaje" runat="server" Width="178px" 
                      CssClass="btnlista"></asp:TextBox> 
                  <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btnlista"  />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" CssClass="btnlista" Width="104px"/>
                </div>

               <div class="derecha">
                   <asp:Button ID="btnCalcular" runat="server" Text="Calcular" Width="121px" 
                       CssClass="btn" Height="44px"/>
                   <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" Width="121px" CssClass="btn" Height="46px" />
                 </div>
                 
                
               </asp:Panel> 
             
              <asp:Panel ID="pnlPresupuesto" runat="server" GroupingText="Presupuesto" 
               Visible="False" Height="241px"   >
                  <asp:Label ID="LblPresupuesto" runat="server"></asp:Label>
                      <asp:Button ID="btnImprimir" runat="server" Text="Imprimir" Width="121px"  CssClass="btnimp"/>
                </asp:Panel> 
          
               
       </div>
  </div>
    </form>
</body>
</html>
