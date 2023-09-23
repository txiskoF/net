<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="pnlmicros" runat="server" GroupingText="MicroProcesadores" 
            style="z-index: 1; left: 799px; top: 15px; position: absolute; height: 155px; width: 345px">
            <asp:RadioButtonList ID="rdblmicros" runat="server" Font-Names="Arial"                 Font-Size="Small" Width="339px">
                <asp:ListItem Value="123,55">INTEL CORE I3 2100 3.1Ghz SK1155 3MB</asp:ListItem>
                <asp:ListItem Value="204,73">INTEL CORE I5 2400 3,1Ghz SK1155 6MB</asp:ListItem>
                <asp:ListItem Value="306,12">INTEL CORE I7 2600 3,4Ghz SK1155 8MB</asp:ListItem>
                <asp:ListItem Value="366,25">INTEL CORE I7 3770K 3,5Ghz SK1155 8MB</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" GroupingText="Cajas ATX" 
            style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 155px; width: 345px">
            <asp:RadioButtonList ID="rdblcajas" runat="server" Font-Names="Arial" 
                Font-Size="Small" Width="351px"   
              >
                <asp:ListItem Value="23,41">SEMITORRE ASUS VENTO TAB863 S/F</asp:ListItem>
                <asp:ListItem Value="34,90">SEMITORRE TACENS MAGNUS NEGRA S/F</asp:ListItem>
                <asp:ListItem Value="50,95">AEROCOOL VS4 NEGRA S/F</asp:ListItem>
                <asp:ListItem Value="121,36">SEMITORRE NZXT PHANTOM NEGRA LED AZUL</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
    
    </div>
    <p>
        &nbsp;</p>
    <asp:Panel ID="pnlplacas" runat="server" GroupingText="Placas Base" 
        style="z-index: 1; left: 407px; top: 15px; position: absolute; height: 155px; width: 345px">
        <asp:RadioButtonList ID="rdblplacas" runat="server" Font-Names="Arial" 
            Font-Size="Small" Width="326px">
            <asp:ListItem Value="59,83">INTEL CORE I3/I5/I7 ASUS P8H61-M</asp:ListItem>
            <asp:ListItem Value="46,15">INTEL CORE I3/I5/I7 GIGABYTE H61M-DS2</asp:ListItem>
            <asp:ListItem Value="74,25">INTEL CORE I3/I5/I7 ASROCK PRO3-M</asp:ListItem>
            <asp:ListItem Value="94,58">INTEL CORE I3/I5/ I7 ASUS P81761/USB3 B3</asp:ListItem>
        </asp:RadioButtonList>
    </asp:Panel>
    <asp:Panel ID="pnlhd" runat="server" GroupingText="Discos Duros" 
        style="z-index: 1; left: 407px; top: 172px; position: absolute; height: 155px; width: 345px">
        <asp:RadioButtonList ID="rdblhd" runat="server" Font-Names="Arial" 
            Font-Size="Small" Width="335px">
            <asp:ListItem Value="65,84">500GB SEAGATE SATA3 7200 16MB</asp:ListItem>
            <asp:ListItem Value="88,96">1TBSEAGATE SATA3 7200 32MB</asp:ListItem>
            <asp:ListItem Value="78,50">1TB WESTERN DIGITAL SATA3 32MB</asp:ListItem>
            <asp:ListItem Value="107,84">2TB WESTERN DIGITAL 64MB CAVIAR GREEN </asp:ListItem>
        </asp:RadioButtonList>
    </asp:Panel>
    <asp:Panel ID="pnlram" runat="server" GroupingText="Memoria RAM" 
        style="z-index: 1; left: 13px; top: 172px; position: absolute; height: 155px; width: 345px">
        <asp:RadioButtonList ID="rdblram" runat="server" Font-Names="Arial" 
            Font-Size="Small" Width="338px">
            <asp:ListItem Value="12,20">DDR3 2GB I333 KINGSTON</asp:ListItem>
            <asp:ListItem Value="14,25">DDR3 2GB 1333 KINGSTON HYPERX BLU CL9</asp:ListItem>
            <asp:ListItem Value="21,18">DDR3 4GB KINGSTON I333</asp:ListItem>
            <asp:ListItem Value="24,82">DDR3 4GB KINGSTON HYPERX BLUE CL9</asp:ListItem>
        </asp:RadioButtonList>
    </asp:Panel>
    <asp:Panel ID="pnltgrafica" runat="server" GroupingText="Tarjetas Gráficas" 
        style="z-index: 1; left: 799px; top: 172px; position: absolute; height: 155px; width: 345px">
        <asp:RadioButtonList ID="rdbltg" runat="server" Font-Names="Arial" 
            Font-Size="Small" Width="337px">
            <asp:ListItem Value="112,93">1GB GIGABYTE GTX580 DDR5 HDMI</asp:ListItem>
            <asp:ListItem Value="92,04">1GB ATI SAPPHERE HD6670 DDR5 HDMI DPORT</asp:ListItem>
            <asp:ListItem Value="108,28">1GB ATI GIGABYTE HD7750 HDMI</asp:ListItem>
            <asp:ListItem Value="114,44">2GB GIGABYTE GT640 DDR3 HDMI</asp:ListItem>
        </asp:RadioButtonList>
    </asp:Panel>
    <asp:CheckBoxList ID="chklopcional" runat="server" Font-Names="Arial" 
        Font-Size="Small"  
        RepeatDirection="Horizontal" 
        
        style="z-index: 1; left: 16px; top: 337px; position: absolute; height: 27px; width: 1291px" 
       >
        <asp:ListItem Value="29,95">ANTIVIRUS KASPERSKY INTERNET SECURITY 1 LIC.</asp:ListItem>
        <asp:ListItem Value="12,90">RATON LOGITECH OPTICO INALAMBRICO</asp:ListItem>
        <asp:ListItem Value="24,90">TECLADO B-MOVE TOUCHLIGHT USB</asp:ListItem>
        <asp:ListItem Value="69">IMPRESORA HP DESKJET 3050 MULTIFUNCION WIFI</asp:ListItem>
    </asp:CheckBoxList>
    <asp:Button ID="btncalcular" runat="server" 
        style="z-index: 1; left: 28px; top: 446px; position: absolute" 
        Text="CALCULAR PRESUPUESTO" OnClick="btncalcular_Click1" />
    <p>
        <asp:Label ID="lblprecio" runat="server" 
            
            style="z-index: 1; left: 905px; top: 520px; position: absolute; width: 123px;" 
            Text="PRECIO: "></asp:Label>
    </p>
    <asp:TextBox ID="txtdescripcion" runat="server" 
        style="z-index: 1; left: 418px; top: 388px; position: absolute; width: 410px; height: 158px" 
        TextMode="MultiLine">La descripción del ordenador es: </asp:TextBox>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnReinicio" runat="server"  
            Text="Reiniciar" />
    </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
