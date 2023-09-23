<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="EJEMPLO_LISTAS.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rdbLista" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="1">Uno</asp:ListItem>
                <asp:ListItem Value="2">Dos</asp:ListItem>
                <asp:ListItem Value="3">Tres</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnAñadir" runat="server" OnClick="btnAñadir_Click" Text="AÑADIR" />
            <asp:Label ID="LblTexto" runat="server"></asp:Label>
            <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" />
            <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="BORRAR" />

            <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="BUSCAR" />

            <br />
            <asp:CheckBoxList ID="ChkHobbies" runat="server">
                <asp:ListItem>Deporte</asp:ListItem>
                <asp:ListItem>Musica</asp:ListItem>
                <asp:ListItem>Cine</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="BtnSeleccion" runat="server" OnClick="BtnSMultiple_Click" Text="SELECCION MULTIPLE" />

            <asp:Button ID="BtnBorradoMultiple" runat="server" OnClick="BtnBMULTPLE_Click" Text="BORRADO MULTIPLE" />
                

            <br />
            <br />
            <br />
            <asp:PlaceHolder ID="phmonedas" runat="server">
                <asp:ImageButton ID="ImageButton3" runat="server" />
                <asp:ImageButton ID="ImageButton2" runat="server" />
                <asp:ImageButton ID="ImageButton1" runat="server" />
            </asp:PlaceHolder>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
