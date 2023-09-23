<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pincipal2.aspx.cs" Inherits="EjercicioValidacion.Pincipal2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre" Width="100px"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" Display="Dynamic" ErrorMessage="Debe introdcir un nombre"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblApellido" runat="server" Text="Apellido" Width="100px"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" Display="Dynamic" ErrorMessage="Debe introducir un apellido"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblEdad" runat="server" Text="Edad" Width="100px"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEdad" Display="Dynamic" ErrorMessage="Debe introducir  una edad"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtEdad" Display="Dynamic" ErrorMessage="seleccionar entre 7 y 20" MaximumValue="20" MinimumValue="7" Type="Integer"></asp:RangeValidator>
            <br />
            <asp:Label ID="lblMovil" runat="server" Text="Móvil" Width="100px"></asp:Label>
            <asp:TextBox ID="txtMovil" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMovil" Display="Dynamic" ErrorMessage="Debe introducir un número"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMovil" ErrorMessage="Debe introducir 9 digitos" ValidationExpression="\d{3}[\s\.]?\d{2}[\s\.]?\d{2}[\s\.]?\d{2}[\s\.]?"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblCorreo" runat="server" Text="Correo" Width="100px"></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCorreo" Display="Dynamic" ErrorMessage="Debe introducir un correo electrónico"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCorreo" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
            <br />
        </div>
    </form>
</body>
</html>
