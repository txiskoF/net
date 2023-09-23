<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secundario.aspx.cs" Inherits="Ejercicio9.Secundario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="RdbNivel1" runat="server" AutoPostBack="True" GroupName="Niveles"  Text="Nivel1" OnCheckedChanged="RdbNivel1_CheckedChanged" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkMusica" runat="server" AutoPostBack="True" Text="Musica" />
        <BR/>
         <asp:RadioButton ID="RdbNivel2" runat="server" AutoPostBack="True" GroupName="Niveles"  Text="Nivel2" OnCheckedChanged="RdbNivel2_CheckedChanged" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="ChkRaton" runat="server" AutoPostBack="True" Text="Raton" />
        <BR/>
         <asp:RadioButton ID="RdbNivel3" runat="server" AutoPostBack="True" GroupName="Niveles" Text="Nivel3" OnCheckedChanged="RdbNivel3_CheckedChanged" />

    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="ChkColor" runat="server" AutoPostBack="True"  Text="Color" />

    </div>
        <asp:TextBox ID="TxtPanel" runat="server" Height="169px" style="z-index: 1; left: 15px; top: 135px; position: absolute" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>