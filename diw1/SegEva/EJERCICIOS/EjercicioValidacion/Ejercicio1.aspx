<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="EjercicioValidacion.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="SCRIPTS/js.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><b>DNI:</b></td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ErrorMessage="DNI es un campo obligatorio" ControlToValidate="txtDNI" Display="Dynamic" ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="reDNI" runat="server" ErrorMessage="El DNI no cumple con el formato adecuado" ValidationExpression="(\d{8}[A-Z]|\d{2}\ \d{3}\ \d{3}[A-Z]|\d{2}\.\{3}\.\d{3}\-[A-Z])" ControlToValidate="txtDNI" Display="Dynamic" ValidationGroup="a"></asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:CustomValidator ID="cvdni" runat="server" ErrorMessage="La letra no corresponde al DNI especificado"  Display="Dynamic" ClientValidationFunction="validarDNI" ControlToValidate="txtDNI" ValidationGroup="a" ></asp:CustomValidator>
            </td>
        </tr>
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
            <td><b>Dirección:</b></td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
           <td colspan="3">
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ErrorMessage="Dirección es un campo obligatorio" ControlToValidate="txtDireccion"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td ><b>Población:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtPoblacion" runat="server"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td><b>CP:</b></td>
            <td>
                <asp:TextBox ID="txtCP" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:RegularExpressionValidator ID="reCP" runat="server" ErrorMessage="El campo CP no contiene 5 dígitos" ValidationExpression="\d{5}" ControlToValidate="txtCP"></asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td><b>Provincia:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
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
