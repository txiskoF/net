<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="EXAMEN_BD.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="STYLES/estilos.css"/>
    <style type="text/css">
        .auto-style9 {
            width: 30.2cm;
            height: 10cm;
        }
        .auto-style10 {
            height: 1px;
        }
        .auto-style11 {
            margin-left: 28px;
        }
        .auto-style12 {
            width: 46%;
        }
        .auto-style13 {
            height: 23px;
            width: 46%;
        }
        .auto-style14 {
            width: 257px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server" >
    <div style="margin-left:3cm;margin-top:4cm;margin-right:3cm;padding-left:2cm;padding-top:1cm;"; class="auto-style9" >
    
    <table class="auto-style4">
        <tr style="background-color:#0275d8;color:#ffffff;"><td colspan="3"><h1> Empleados de Editoriales</h1>
              </td></tr>
        <tr><td class="auto-style10" colspan="2" ><b>Editoriales</b></td>
            
            <td class="auto-style10"><b>Empleado</b> &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtcodigo" runat="server" Width="317px" CssClass="auto-style11"></asp:TextBox>
             
                
            </td></tr>
        <tr>
        <td class="c1" colspan="2">
         <asp:DropDownList ID="ddleditoriales" runat="server" BackColor="White" 
             Font-Bold="True"  Height="16px" 
                Width="227px">
        </asp:DropDownList>
            <asp:Label ID="lblEmpleados" runat="server"></asp:Label>
        </td>
        
          
       
        <td class="c3" >
            <asp:TextBox ID="txtnombre" runat="server" Width="122px"></asp:TextBox> 
            <asp:TextBox ID="txtapellido" runat="server" Width="315px"></asp:TextBox>
        </td>
         
       
        </tr>

        <tr>
             
        <td class="auto-style6" >
              <table class="auto-style3">
                  <tr><td>  <asp:Label ID="lblEmpleadosEd" runat="server" Text="Empleados:"  Font-Bold="True" ></asp:Label></td></tr>
                  <tr><td> <asp:ListBox ID="lstEmpleados" runat="server" Height="126px" Width="268px" > </asp:ListBox></td></tr>
            </table>
        </td>
        <td rowspan="4" class="auto-style8">
             <table class="auto-style3">
            <tr><td> <asp:Label ID="LblProfesionesEmp" runat="server" Text="Profesiones:"  Font-Bold="True" ></asp:Label></td></tr>
                 <tr><td><asp:ListBox ID="lstProfesiones" runat="server" Height="105px" Width="183px"></asp:ListBox></td></tr>
                 <tr><td><asp:Label ID="lblMin" runat="server" Text="Min:"  Font-Bold="True" ></asp:Label>
                     <asp:TextBox ID="txtNivelMin" runat="server" ReadOnly="True" Width="33px"></asp:TextBox>
                     <asp:Label ID="lblMax" runat="server" Text="Max:"  Font-Bold="True" ></asp:Label>
                     <asp:TextBox ID="txtNivelMax" runat="server" ReadOnly="True" Width="34px"></asp:TextBox>
                     </td></tr>
                 </table>
            </td>
     <td class="style2">
           <table class="auto-style3">
            <tr>
                <td class="auto-style12">&nbsp;</td><td class="auto-style14">&nbsp;</td>
             </tr>
             <tr>
             <td class="auto-style13"><b>Nivel de Desempeño: </b></td><td class="auto-style14"><asp:TextBox ID="txtNivelDesempeño" 
                     runat="server" Width="87px"></asp:TextBox>
                                                                                  </td>
            </tr>
             <tr>
                <td class="auto-style12"><b>Fecha Contrato:</b></td><td class="auto-style14"><asp:TextBox ID="txtFechaContrato" 
                     runat="server" Width="232px"></asp:TextBox></td>
            </tr>
               <tr>
                   <td class="auto-style12">
                       &nbsp;</td>
                       <td class="auto-style14"><asp:Button ID="btnInsertar" runat="server" Text="Insertar Empleado" 
                               Font-Bold="True" ForeColor="#FFFFFF"   BackColor="#0275d8" 
                               Width="240px"   />
</td>
               </tr>
        </table>   
     </td>
      </tr>
      
       <tr>
       <td class="auto-style7">
  
           <asp:TextBox ID="txtProfesion" runat="server"></asp:TextBox>
           <asp:Button ID="btnModificar" runat="server" Text="Modificar Categoría"  
               Font-Bold="True" ForeColor="#ffffff" Width="239px" BackColor="#0275d8"/></td>

       <td class="style6">
  
    <asp:Button ID="btnModificarSalarios" runat="server" Text="MOSTRAR RESUMENES"  
                Font-Bold="True" ForeColor="#ffffff" Width="453px" BackColor="#0275d8"  />
  
              </td>
       
       </tr>
        </table>
        
        <br />
        
    </div>
    </form>
</body>
</html>

