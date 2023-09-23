<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Ejercicio13_SOLUCION.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 794px;
            height: 80px;
            left: 10px;
            top: 15px;
        }
        .style2
        {
            width: 794px;
            height: 80px;
            position: absolute;
            left: 10px;
            top: 15px;
        }
        .auto-style1 {
            z-index: 1;
            left: 248px;
            top: 237px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 246px;
            top: 187px;
            position: absolute;
            right: 702px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="z-index: 1">
    
        <asp:Label ID="Label1" runat="server" Text="Elemento: "></asp:Label>
        <asp:TextBox ID="txtelemento" runat="server" AutoPostBack="True" 
            ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br class="style2" />
        <asp:Button ID="btnborrar" runat="server"  
            style="z-index: 1; left: 359px; top: 355px; position: absolute" 
            Text="Borrar Elementos" OnClick="btnborrar_Click" />
        <span class="style1">
        <asp:ListBox ID="lstelementos" runat="server" SelectionMode="Multiple" 
            style="z-index: 1; left: 64px; top: 179px; position: absolute; width: 115px; height: 140px">
            <asp:ListItem>Uno</asp:ListItem>
            <asp:ListItem>Dos</asp:ListItem>
            <asp:ListItem>Tres</asp:ListItem>
            <asp:ListItem>Cuatro</asp:ListItem>
            <asp:ListItem>Cinco</asp:ListItem>
        </asp:ListBox>
        <asp:ListBox ID="lstpapelera" runat="server" SelectionMode="Multiple" 
            style="z-index: 1; left: 356px; top: 179px; position: absolute; height: 132px; width: 228px"></asp:ListBox>
    
        </span>
    
    </div>
    <p>
        <span class="style1"><asp:ImageButton ID="ImageButton2"
            runat="server" ImageUrl="~/IMAGENES/flechaEnviar.png" 
            Width="50px" OnClick="ImageButton2_Click" CssClass="auto-style2" />
        </span>
    </p>
    <asp:Button ID="btnVaciar" runat="server" 
        style="z-index: 1; left: 583px; top: 358px; position: absolute" 
        Text="Vaciar Papelera" OnClick="btnVaciar_Click" />
        <p>
        <span class="style1">
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/IMAGENES/flechaRestaurar.png" 
            Width="50px" OnClick="ImageButton1_Click" CssClass="auto-style1"/>
    
        </span>
    
        </p>
    </form>
</body>
</html>
