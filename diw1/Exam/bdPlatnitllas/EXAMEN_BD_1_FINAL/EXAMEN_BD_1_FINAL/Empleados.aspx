<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="EXAMEN_BD_1_FINAL.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="STYLES/estilos.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:2cm;margin-top:4cm;margin-right:2cm;background-color:#999966" >
    
    <table class="auto-style4">
        <tr><td colspan="3"><h1> Empleados de Editoriales</h1>
              </td></tr>
        <tr><td class="c1" style="height: 29px; " colspan="2" ><h3><b>Editoriales</b></h3></td>
            
            <td class="auto-style5"><h3>Empleado</h3>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcodigo" runat="server" Width="122px"></asp:TextBox> 
            </td></tr>
        <tr>
        <td class="c1" colspan="2">
         <asp:DropDownList ID="ddleditoriales" runat="server" BackColor="White" 
             Font-Bold="True" ForeColor="#666633" Height="16px" 
                Width="227px" AutoPostBack="True" >
        </asp:DropDownList>
            <asp:Label ID="lblEmpleados" runat="server"></asp:Label>
        </td>
        
          
       
        <td class="c3" >
            <asp:TextBox ID="txtnombre" runat="server" Width="122px"></asp:TextBox> 
            <asp:TextBox ID="txtapellido" runat="server" Width="297px"></asp:TextBox>
        </td>
         
       
        </tr>

        <tr>
             
        <td class="auto-style6" >
              <table class="auto-style3">
                  <tr><td>  <asp:Label ID="lblEmpleadosEd" runat="server" Text="Empleados:"  Font-Bold="True" ForeColor="#666633"></asp:Label></td></tr>
                  <tr><td> <asp:ListBox ID="lstEmpleados" runat="server" Height="126px" Width="268px" > </asp:ListBox></td></tr>
            </table>
        </td>
        <td rowspan="4" class="auto-style8">
             <table class="auto-style3">
            <tr><td> <asp:Label ID="LblProfesionesEmp" runat="server" Text="Profesiones:"  Font-Bold="True" ForeColor="#666633"></asp:Label></td></tr>
                 <tr><td><asp:ListBox ID="lstProfesiones" runat="server" Height="105px" Width="183px"></asp:ListBox></td></tr>
                 <tr><td><asp:Label ID="lblMin" runat="server" Text="Min:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
                     <asp:TextBox ID="txtNivelMin" runat="server" ReadOnly="True" Width="33px"></asp:TextBox>
                     <asp:Label ID="lblMax" runat="server" Text="Max:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
                     <asp:TextBox ID="txtNivelMax" runat="server" ReadOnly="True" Width="34px"></asp:TextBox>
                     </td></tr>
                 </table>
            </td>
     <td class="style2">
           <table class="auto-style3">
            <tr>
                <td class="c1" style="width: 43%">&nbsp;</td><td>&nbsp;</td>
             </tr>
             <tr>
             <td class="c1" style="height: 23px; width: 43%"><b>Nivel de Desempeño :</b></td><td class="auto-style1"><asp:TextBox ID="txtNivelDesempeño" 
                     runat="server" Width="87px"></asp:TextBox>
                                                                                  </td>
            </tr>
             <tr>
                <td class="c1" style="width: 43%"><b>Fecha Contrato:</b></td><td><asp:TextBox ID="txtFechaContrato" 
                     runat="server" Width="207px"></asp:TextBox></td>
            </tr>
               <tr>
                   <td class="auto-style2">
                       &nbsp;</td>
                       <td><asp:Button ID="btnInsertar" runat="server" Text="Insertar Empleado" 
                               Font-Bold="True" ForeColor="#666633"
                               Width="215px"  />
</td>
               </tr>
        </table>   
     </td>
      </tr>
      
       <tr>
       <td class="auto-style7">
  
           <asp:TextBox ID="txtProfesion" runat="server"></asp:TextBox>
           <asp:Button ID="btnModificar" runat="server" Text="Modificar Categoría"  
               Font-Bold="True" ForeColor="#666633" Width="239px"/></td>

       <td class="style6">
  
    <asp:Button ID="btnModificarSalarios" runat="server" Text="MOSTRAR RESUMENES"  
                Font-Bold="True" ForeColor="#666633" Width="395px" />
  
              </td>
       
       </tr>
        </table>
        
    </div>
    </form>
</body>
</html>

