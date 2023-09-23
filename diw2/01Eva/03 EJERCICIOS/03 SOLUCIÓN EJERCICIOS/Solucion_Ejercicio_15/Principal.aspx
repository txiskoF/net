<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Solucion_Ejercicio_17.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    
        
        <asp:Panel ID="Panel1" runat="server" GroupingText="Factura" Height="279px">
            <asp:Label ID="Label1" runat="server" 
                Text="Introduzca el código de la factura:"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server" 
                ontextchanged="txtCodigo_TextChanged" style="height: 22px" 
                AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Fecha Factura:"></asp:Label>
            <asp:TextBox ID="txtFechaFactura" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Importe Factura:"></asp:Label>
            <asp:TextBox ID="txtImporteFactura" runat="server" 
                ontextchanged="txtImporteFactura_TextChanged" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" 
                 />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" 
                onclick="btnCalcular_Click" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" GroupingText="Pagos" 
            style="z-index: 1; left: 10px; top: 248px; position: absolute; height: 295px; width: 732px">
            <asp:Label ID="Label4" runat="server" Text="Importe IVA incluido"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtImporteIVA" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Importe"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Fecha"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Primer Plazo"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrimerImporte" runat="server" height="22px" Width="103px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFechaPrimer" runat="server" Width="253px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Segundo Plazo"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSegundoImporte" runat="server" Width="103px" ></asp:TextBox>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtSegundaFecha" runat="server" height="22px" width="253px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Tercer Plazo"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTercerImporte" runat="server" height="22px" width="103px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTerceraFecha" runat="server" height="22px" width="253px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
