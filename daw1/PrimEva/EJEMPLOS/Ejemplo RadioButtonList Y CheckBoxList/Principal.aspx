<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RdbLNumeros" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Uno</asp:ListItem>
            <asp:ListItem Value="2">Dos</asp:ListItem>
            <asp:ListItem Value="3">Tres</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
        <asp:Label ID="LblEtiqueta" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SELECCIONAR" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="AÑADIR" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="INSERTAR" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="BORRAR" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="BUSCAR" />
        <br />
        <asp:Button ID="Button6" runat="server" Text="MOSTRAR SELECCIONES CHKBOXLIST" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="BORRAR ELEMENTOS SELECCIONADOS CHBOXLIST" />
        <br />
        <asp:CheckBoxList ID="ChkLLetras" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem Value="A">Letra A</asp:ListItem>
            <asp:ListItem Value="B">LetraB</asp:ListItem>
            <asp:ListItem>Letra C</asp:ListItem>
            <asp:ListItem>Letra D</asp:ListItem>
            <asp:ListItem>Letra E</asp:ListItem>
        </asp:CheckBoxList>
    </form>
</body>
</html>
