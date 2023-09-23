
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Formulario_COMMAND.aspx.cs" Inherits="Formulario_COMMAND" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 69px;
            top: 146px;
            position: absolute;
            height: 26px;
            width: 38px;
        }
        .auto-style2 {
            top: 146px;
        }
        .auto-style3 {
            top: 146px;
            z-index: 1;
            left: 144px;
            position: absolute;
            width: 39px;
        }
        .auto-style4 {
            z-index: 1;
            left: 65px;
            top: 213px;
            position: absolute;
            width: 39px;
        }
        .auto-style5 {
            z-index: 1;
            left: 137px;
            top: 213px;
            position: absolute;
            width: 34px;
        }
        .auto-style6 {
            z-index: 1;
            left: 170px;
            top: 213px;
            position: absolute;
            width: 34px;
        }
        .auto-style7 {
            z-index: 1;
            left: 204px;
            top: 213px;
            position: absolute;
            width: 34px;
        }
        .auto-style8 {
            top: 213px;
            z-index: 1;
            left: 104px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 32px;
            top: 213px;
            position: absolute;
            width: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblIVA" runat="server" Text="IVA:" style="z-index: 1; left: 271px; top: 26px; position: absolute; height: 19px"></asp:Label>
            <asp:TextBox ID="txtcantidad" runat="server" style="z-index: 1; left: 97px; top: 26px; position: absolute" AutoPostBack="True" OnTextChanged="txtcantidad_TextChanged"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 24px; position: absolute; height: 21px" Text="Cantidad"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 271px; top: 76px; position: absolute" Text="Total:"></asp:Label>
            <asp:Button ID="btn16" runat="server" height="29px" style="z-index: 1; left: 106px; position: absolute" Text="16%" width="38px" CommandArgument="0,16" CommandName="16%" OnCommand="Calcular" CssClass="auto-style2" />
            <asp:Button ID="btn4" runat="server" style="z-index: 1; left: 30px; top: 146px; position: absolute" Text="4%" CommandArgument="0,04" CommandName="4%" OnCommand="Calcular" EnableTheming="False" />
            <asp:Button ID="btn21" runat="server" height="29px" Text="21%" CommandArgument="0,21" CommandName="21%" OnCommand="Calcular" CssClass="auto-style3" />
            <asp:Button ID="btn8" runat="server" Text="8%" CommandArgument="0,08" CommandName="8%" OnCommand="Calcular" CssClass="auto-style1" height="29px" />
     
        <asp:Button ID="btnh1" runat="server" Text="H1" CommandArgument="&lt;/H1&gt;" CommandName="&lt;H1&gt;" CssClass="auto-style9" OnCommand="Marcar"  />
    
   
      
            <asp:Button ID="btnh2" runat="server" Text="H2" CommandArgument="&lt;/H2&gt;" CommandName="&lt;H2&gt;" CssClass="auto-style4" height="29px" OnCommand="Marcar"  />
       
            <asp:Button ID="btnh3" runat="server" Text="H3" CommandArgument="&lt;/H3&gt;" CommandName="&lt;H3&gt;" CssClass="auto-style8" height="29px" OnCommand="Marcar" width="34px" />
                 
            <asp:Button ID="btnh4" runat="server" Text="H4" CommandArgument="&lt;/H4&gt;" CommandName="&lt;H4&gt;" CssClass="auto-style5" height="29px" OnCommand="Marcar"  />
              
           <asp:Button ID="btnh5" runat="server" Text="H5" CommandArgument="&lt;/H5&gt;" CommandName="&lt;H5&gt;" CssClass="auto-style6" height="29px" OnCommand="Marcar"  />
                    
           <asp:Button ID="btnh6" runat="server" Text="H6" CommandArgument="&lt;/H6&gt;" CommandName="&lt;H6&gt;" CssClass="auto-style7" height="29px" OnCommand="Marcar"  />
          </asp:Panel>
        
       </div>  
    </form>
</body>
</html>
