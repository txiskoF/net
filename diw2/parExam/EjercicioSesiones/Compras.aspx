<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compras.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblusuario" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="hlcesta" runat="server" Font-Bold="True" 
            
            style="z-index: 1; left: 500px; top: 76px; position: absolute; width: 8px" 
            NavigateUrl="~/MisCompras.aspx">0</asp:HyperLink>
        <br />
        Productos<br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"  >
            <asp:ListItem Value="0">Libros Electrónicos</asp:ListItem>
            <asp:ListItem>Accesorios Libros Electrónicos</asp:ListItem>
            <asp:ListItem>Tablets</asp:ListItem>
        </asp:DropDownList>
    
        <br />
        <p>
        <asp:Image ID="Image2" runat="server" Height="69px" ImageUrl="~/imagenes/cesta.jpeg" 
            style="z-index: 1; left: 476px; top: 4px; position: absolute" Width="71px" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
    </div>
   
    <br />
    <br />
    <br />
    

    
    <br />
   
    </form>
</body>
</html>
