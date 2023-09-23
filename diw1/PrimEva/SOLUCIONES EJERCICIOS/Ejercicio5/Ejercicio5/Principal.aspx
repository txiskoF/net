<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            z-index: 1;
            left: 65px;
            top: 211px;
            position: absolute;
            width: 34px;
        }
        .auto-style4 {
            z-index: 1;
            left: 110px;
            top: 211px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 150px;
            top: 211px;
            position: absolute;
            width: 34px;
        }
        .auto-style6 {
            z-index: 1;
            left: 193px;
            top: 211px;
            position: absolute;
            width: 34px;
        }
        .auto-style7 {
            z-index: 1;
            left: 236px;
            top: 211px;
            position: absolute;
            width: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblIVA" runat="server" Text="IVA:" style="z-index: 1; left: 271px; top: 26px; position: absolute; height: 19px"></asp:Label>
            <asp:TextBox ID="txtcantidad" runat="server" style="z-index: 1; left: 97px; top: 26px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 24px; position: absolute; height: 21px" Text="Cantidad"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 271px; top: 76px; position: absolute" Text="Total:"></asp:Label>
            <asp:Button ID="btn16" runat="server" height="29px" style="z-index: 1; left: 106px; position: absolute" Text="16" width="38px" OnClick="Calcular" CssClass="auto-style2" />
            <asp:Button ID="btn4" runat="server" style="z-index: 1; left: 30px; top: 146px; position: absolute" Text="4%" OnClick="Calcular" />
            <asp:Button ID="btn21" runat="server" height="29px" style="z-index: 1; left: 149px; position: absolute" Text="21%" width="38px" OnClick="Calcular" CssClass="auto-style2" />
            <asp:Button ID="btn8" runat="server" Text="8%" OnClick="Calcular" CssClass="auto-style1" height="29px" />
     
        <asp:Button ID="btnh1" runat="server" style="z-index: 1; left: 27px; top: 211px; position: absolute" Text="H1"  OnClick="Marcar"/>
    
   
      
            <asp:Button ID="btnh2" runat="server" Text="H2" OnClick="Marcar" CssClass="auto-style3" height="29px" width="34px" />
       
            <asp:Button ID="btnh3" runat="server" Text="H3" OnClick="Marcar" CssClass="auto-style4" height="29px" width="34px" />
                 
            <asp:Button ID="btnh4" runat="server" Text="H4" OnClick="Marcar" CssClass="auto-style5" height="29px" width="34px" />
              
           <asp:Button ID="btnh5" runat="server" Text="H5"  OnClick="Marcar" CssClass="auto-style6" height="29px" width="34px"/>
                    
           <asp:Button ID="btnh6" runat="server" Text="H6" OnClick="Marcar" CssClass="auto-style7" height="29px" width="34px" />
          </asp:Panel>
        
       </div>  
       
    </form>
</body>
</html>
