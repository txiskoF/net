<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ControlesValidacion.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="SCRIPTS/validacion.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDni" runat="server" Text="DNI" Width="150px"></asp:Label>
            <asp:TextBox ID="txtDni" runat="server"  ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDni" runat="server" Display="Dynamic" ErrorMessage="Debe introducir un DNI" ControlToValidate="txtDni"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtDni" ErrorMessage="El DNI no cumple el formato"></asp:RegularExpressionValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="La letra no es correcta" ClientValidationFunction="validarLetra" ControlToValidate="txtDni" ></asp:CustomValidator>
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre" Width="150px"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Debe introudcir un nombre" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección" Width="150px"></asp:Label>
            <asp:TextBox ID="TexttxtDireccionBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPoblacion" runat="server" Text="Población" Width="150px"></asp:Label>
            <asp:TextBox ID="txtPoblacion" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCodigo" runat="server" Text="Codigo Postal" Width="150px"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El codigo no es correcto" ControlToValidate="txtCodigo" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label>
            <asp:TextBox ID="txtProvinica" runat="server" Width="129px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server"  Text="ENVIAR" OnClick="Button1_Click" Width="70px" />
            <br />
        </div>
    </form>
</body>
</html>

