<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autentificar.aspx.cs" Inherits="Ejercicio18.Autentificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" ></asp:TextBox>
            </br>
            </br>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
             </br>
            </br>
            <asp:Button ID="btnAceptar" TextMode="Password" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" />
        </div>
    </form>
</body>
</html>
