<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="BIOTEK.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre: " Width="150px"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        
            

            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Debe introducir un nombre" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
        
            

            <p>
        
            

            <asp:Label ID="lblEmail" runat="server" Text="E-mail: " Width="150px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            

        
                <asp:RegularExpressionValidator ID="reEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Debe introducir un e-mail válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            

        
            </p>
            <p>
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña: " Width="150px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="rvfContraseña" runat="server" ErrorMessage="Debe introducir una contraseña" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </p>
            <p>
            <asp:Label ID="lblConfirmar" runat="server" Text="Confirmar contraseña: " Width="150px"></asp:Label>
            <asp:TextBox ID="txtConfirmar" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="rvfConfirmar" runat="server" ErrorMessage="Debe introducir una contraseña" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvContraseña" runat="server" ErrorMessage="La contraeña no coincide" Display="Dynamic" ControlToCompare="txtPassword" ControlToValidate="txtConfirmar"></asp:CompareValidator>
            </p>
            <p>
            <asp:Button ID="btnRegistro" runat="server" Text="Registrarse" OnClick="Button1_Click" />
            </p>
            
        </div>
    </form>
</body>
</html>
