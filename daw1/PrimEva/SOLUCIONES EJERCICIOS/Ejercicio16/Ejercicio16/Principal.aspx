<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejercicio16.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 815px">
    <form id="form1" runat="server">
    <div style="height: 484px">
    
        <asp:Label ID="Label1" runat="server" Text="SALARIOS EMPLEADOS"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Identificativo Empleado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIdentificativo" runat="server" 
           ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre Empleado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Fecha Contrato"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtContrato" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Puesto"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Base de Cotización"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:RadioButtonList ID="rdblPuesto" runat="server" AutoPostBack="True" 
            BackColor="#99CCFF" BorderColor="Black" BorderStyle="Solid" Height="128px" 
            style="z-index: 1; left: 9px; top: 290px; position: absolute; height: 128px; width: 146px" OnSelectedIndexChanged="rdblPuesto_SelectedIndexChanged">
            <asp:ListItem Value="3802,25">Analista</asp:ListItem>
            <asp:ListItem Value="3102,50">Programador</asp:ListItem>
            <asp:ListItem Value="4585,75">Jefe de Area</asp:ListItem>
            <asp:ListItem Value="4100,35">Jefe de Proyecto</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButtonList ID="rdblCotizacion" runat="server" AutoPostBack="True" 
            BackColor="#99CCFF" BorderColor="Black" BorderStyle="Solid" 
            style="z-index: 1; top: 291px; position: absolute; height: 128px; width: 135px; left: 205px">
            <asp:ListItem Value="858,60">Mínima</asp:ListItem>
            <asp:ListItem Value="1888,801">Media</asp:ListItem>
            <asp:ListItem Value="3425,70">Máxima</asp:ListItem>
        </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnLimpiar" runat="server" height="26px" 
            style="z-index: 1; left: 205px; top: 440px; position: absolute; width: 144px" 
            Text="Limpiar" OnClick="btnLimpiar_Click" />
        <asp:Button ID="btnCalcular" runat="server" 
            style="z-index: 1; left: 34px; top: 440px; position: absolute; width: 144px; right: 574px" 
            Text="Calcular" OnClick="btnCalcular_Click"  />
    
    </div>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <asp:Label ID="lblCuadro" runat="server"></asp:Label>
    </form>
</body></html>

