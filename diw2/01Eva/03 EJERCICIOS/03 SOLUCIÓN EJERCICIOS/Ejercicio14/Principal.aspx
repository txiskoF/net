<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlnombres" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Roman Pérez,Luis</asp:ListItem>
            <asp:ListItem>Garcia Joyosa,Ainara</asp:ListItem>
            <asp:ListItem>Durán Reyes,Martina</asp:ListItem>
            <asp:ListItem>Alonso Guadalajara,Jesús</asp:ListItem>
            <asp:ListItem>Rivas Fernández,Carlos</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
        <asp:Label ID="lblnombre" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellidos: "></asp:Label>
        <asp:Label ID="lblapellidos" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre Completo: "></asp:Label>
        <asp:Label ID="lblnombrecompleto" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
