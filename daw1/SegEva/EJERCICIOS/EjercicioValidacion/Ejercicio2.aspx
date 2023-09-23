<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="EjercicioValidacion.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table>
        
         <tr>
            <td><b>Nombre:</b></td>
            <td >
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
             <td colspan="3">
                    <asp:RequiredFieldValidator ID="rdvNombre" runat="server" ErrorMessage="Nombre es un campo obligatorio" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
       
        </tr>
         <tr>
            <td><b>Apellido:</b></td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
           <td colspan="3">
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ErrorMessage="Apellido es un campo obligatorio" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td ><b>Edad:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEdad" runat="server" ControlToValidate="txtEdad" Display="Dynamic" ErrorMessage="Debe introducir la edad"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="ravedad" runat="server" ControlToValidate="txtEdad" Display="Dynamic" ErrorMessage="La edad debe estar comprendida entre 7 y 20 años" MaximumValue="20" MinimumValue="7" Type="Integer"></asp:RangeValidator>
            </td>
          
        </tr>
        <tr>
            <td><b>móvil:</b></td>
            <td>
                <asp:TextBox ID="txtMovil" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:RequiredFieldValidator ID="rfvmovil" runat="server" ControlToValidate="txtMovil" Display="Dynamic" ErrorMessage="EL campo Movil debe introducirse"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="removil" runat="server" ErrorMessage="El móvil introducido no cumple el patrón" ValidationExpression="(\d{3}\ \d{2}\ \d{2}\ \d{2}|\d{3}\.\d{2}\.\d{2}\.\d{2}|\d{9})" ControlToValidate="txtMovil" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td><b>Correo Electrónico:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvcorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="El correo electrónico es obligatorio"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="recorreo" runat="server" ControlToValidate="txtCorreo" Display="Dynamic" ErrorMessage="El correo electrónico no sigue el patrón correcto" ValidationExpression="(\w+[\._]?)+@(zabal|zabalburu).net"></asp:RegularExpressionValidator>
            </td>
                        
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" /></td>
           
                        
        </tr>

    </table>
    </div>
    </form>
</body>
</html>

 

