<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Autentificacion.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="txtusuario" runat="server" 
        style="z-index: 1; left: 98px; top: 15px; position: absolute" ></asp:TextBox>
    <b>Usuario:</b><div>
    
        <b>
        <br />
        Password:</b><asp:TextBox ID="txtpassword" runat="server" 
            style="z-index: 1; left: 98px; position: absolute" TextMode="Password" 
           ></asp:TextBox>
    
        <br />
    
        <br />
    
    </div>
    <asp:Button ID="btnaceptar" runat="server" Text="ACEPTAR" 
        onclick="btnaceptar_Click" />
    </form>
</body>
</html>
