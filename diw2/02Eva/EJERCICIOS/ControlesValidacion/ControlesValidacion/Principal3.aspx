<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal3.aspx.cs" Inherits="ControlesValidacion.Principal3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Introducir un código del tipo AA-000" ValidationExpression="[A-Z]{2}-[0-9]{3}"></asp:RegularExpressionValidator>
             </td>
       
        </tr>
         <tr>
            <td><b>Nombre</b></td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
           <td colspan="3">
                    &nbsp;</td>
        </tr>
        <tr>
            <td ><b>Descripción:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td><b>Precio:</b></td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:RangeValidator ID="rvPrecio" runat="server" ErrorMessage="El precio debe estar entre 1-1000" ControlToValidate="txtPrecio" MaximumValue="1000" MinimumValue="1" Type="Currency"></asp:RangeValidator>
            </td>
            
        </tr>
         <tr>
            <td colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" /></td>
           
                        
        </tr>

    </table>
    </div>
    </form>
</body></html>
