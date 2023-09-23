<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="EjercicioValidacion.Ejercicio3" %>

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
            <td><b>Codigo:</b></td>
            <td >
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
             <td colspan="3">
                    <asp:RequiredFieldValidator ID="rdvCodigo" runat="server" ErrorMessage="El codigo del producto es un campo obligatorio" ControlToValidate="txtCodigo"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="recodigo" runat="server" ErrorMessage="El código del producto introducido no cumple el patrón" ValidationExpression="[A-Z]{2}\-\d{3}" ControlToValidate="txtCodigo" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
       
        </tr>
         <tr>
            <td><b>Nombre</b></td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
           <td colspan="3">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre del producto es un campo obligatorio" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td ><b>Descripción:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" Display="Dynamic" ErrorMessage="Debe introducir la descripción del producto"></asp:RequiredFieldValidator>
            </td>
          
        </tr>
        <tr>
            <td><b>Precio:</b></td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:RequiredFieldValidator ID="rfvprecio" runat="server" ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage="EL campo Precio del Producto debe introducirse"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="ravprecio" runat="server" ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage="El precio debe ser mayor de 0 y menor de 1001" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
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
