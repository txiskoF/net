<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Extraescolares.aspx.cs" Inherits="Examen_Final_Primera_Evaluacion.Extraescolares" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="~/Styles/EjemploInicial.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
      <div class="cabecera">
        
            <h1>Educación No Formal - Las Meninas</h1>
         
       </div>
       <div class="main">
     
           <asp:Panel ID="pnlDatosPersonales" runat="server" 
               GroupingText="Datos Personales" Height="237px">
            
            <div class="izquierda">
           <asp:Label ID="lbletiqueta" runat="server" Text="Nombre Alumno" CssClass ="label "></asp:Label>
           <asp:TextBox ID="txtNombre" runat="server" Width="178px"></asp:TextBox>

           <asp:Label ID="Label1" runat="server" Text="Nombre Tutor" CssClass ="label "></asp:Label>
               
           <asp:TextBox ID="txtTutor" runat="server" Width="181px"></asp:TextBox>
           
            <asp:Label ID="Label2" runat="server" Text="Fecha Nacimiento" CssClass ="label " 
                    Width="114px"></asp:Label>
           <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="178px"></asp:TextBox> 
            
                  <asp:Label ID="Label5" runat="server" Text="Tipo Familia" CssClass ="label "></asp:Label>
                    <asp:RadioButton ID="rdbFNormal" runat="server"  Text ="Familia Normal" 
                    CssClass ="radioB"/>
                     <br />
                     <asp:RadioButton ID="rdbFNumerosa" runat="server" Text="Familia Numerosa" />
              
           </div>
              <div class="medio">
              <asp:Label ID="Label3" runat="server" Text="Fotografía Alumno" CssClass ="label "></asp:Label>
                <asp:TextBox ID="txtFotografia" runat="server" Width="192px"></asp:TextBox> 

                      &nbsp;</div>
              <div class="derecha">
                <asp:Label ID="Label4" runat="server" Text="Foto" CssClass ="label1 " ></asp:Label>
               <asp:Image ID="imgFotografia" runat="server" Width="100px" CssClass ="imagen" 
                      Height="140px"/>

               </div>
               </asp:Panel> 
             
              <asp:Panel ID="pnlactividades" runat="server" GroupingText="Actividades"  
               CssClass ="panel" >
              <div class="izquierda ">
                  <asp:Label ID="Label6" runat="server" Text="Complementos"></asp:Label>
                  <asp:ListBox ID="lstComplementos" runat="server" Height="120px" 
                      SelectionMode="Multiple" Width="189px">
                  </asp:ListBox>
                  <br />
                  <asp:Button ID="btnEliminarComplementos" runat="server" 
                      Text="Eliminar Complementos" CssClass="btnlista" Width="182px" />
                    <asp:Button ID="btnRestablecer" runat="server" Text="Restablecer Complementos" 
                      CssClass="btnlista" Width="182px"/>
              </div>
           
              <div class="medio">
                  <asp:Label ID="Label7" runat="server" Text="Actividades"></asp:Label>
                  <asp:ListBox ID="lstActividades" runat="server" Height="127px" Width="190px">
                      <asp:ListItem Value="50">Música + instrumento</asp:ListItem>
                      <asp:ListItem Value="70">Dantzak</asp:ListItem>
                      <asp:ListItem Value="150">Futbol5</asp:ListItem>
                      <asp:ListItem Value="100">Patinaje</asp:ListItem>
                      <asp:ListItem Value="120">Baloncesto</asp:ListItem>
                      <asp:ListItem Value="60">Inglés</asp:ListItem>
                      <asp:ListItem Value="70">Taller de Teatro en Inglés</asp:ListItem>
                      <asp:ListItem Value="80">Ajedrez</asp:ListItem>
                      <asp:ListItem Value="80">Danza Moderna</asp:ListItem>
                      <asp:ListItem Value="60">Música+Coro</asp:ListItem>
                  </asp:ListBox>
                  
             
                  
                   <asp:Button ID="btnCalcular" runat="server" 
                      Text="Calcular" CssClass="btnlista" Width="182px" />
                </div>

               <div class="derecha">
               <h4>Importe</h4>
                   <asp:Label ID="lblImporte" runat="server" Text=""></asp:Label>
                   <br />
                   <asp:CheckBox ID="chkPagoFraccionado" runat="server" Text ="FraccionarPago" />
                  
                   <asp:RadioButtonList ID="rdblpagofraccionado" runat="server">
                   
                       <asp:ListItem>2 Pagos</asp:ListItem>
                       <asp:ListItem>3 Pagos</asp:ListItem>
                   
                   </asp:RadioButtonList>

                   <asp:Button ID="btnMatricular" runat="server" Text="Matricúlate" Width="121px" 
                       CssClass="btnlista"/>
                   <asp:Button ID="btnInicio" runat="server" Text="Inicio" Width="121px" 
                       CssClass="btnlista" />
                 </div>
               </asp:Panel> 
             
              <asp:Panel ID="pnlMatricula" runat="server" GroupingText="Matrícula" 
               Visible="False"   >
                  <asp:Label ID="lblmatricula" runat="server" Text=""></asp:Label>
                      <asp:Button ID="btnImprimir" runat="server" Text="Imprimir" Width="121px"  
                      CssClass="btnimp"/>
                       <asp:Button ID="btnVolver" runat="server" Text="Volver" Width="121px"  
                      CssClass="btnlista"/>
                </asp:Panel> 
          
               
       </div>
  </div>
    </form>
</body>
</html>
