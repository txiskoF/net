<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ESTILOS/Estilo.css" rel="stylesheet" type="text/css" />
    <script src="SCRIPT/JScript.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
    <div class="cabecera">
    <h1>Redireccionamientos</h1>
    </div>
    <div class="contenido">
    <fieldset class="field1">
    <legend>Periodicos</legend>
        <asp:Button ID="btnCorreo" class="btn" runat="server" Text="El correo" 
            onclick="btnCorreo_Click" />
       
        <asp:Button ID="btnConfidencial" class="btn" runat="server" Text="El confidencial" 
            onclick="btnConfidencial_Click" />
     
        <asp:Button ID="btnMundo" runat="server" class="btn" Text="El mundo" 
            onclick="btnMundo_Click" />
      
        <asp:Button ID="btnMarca" runat="server" class="btn" Text="El marca" 
            onclick="btnMarca_Click" />
    </fieldset>
       <fieldset class="field2">
        <legend>Buscadores</legend>
        <asp:Button ID="btnGoogle" runat="server" class="btn" Text="Google" 
               onclick="btnGoogle_Click" />
    
        <asp:Button ID="btnYahoo" runat="server" Text="Yahoo" class="btn" onclick="btnYahoo_Click" />
     
        <asp:Button ID="btnBing" runat="server" Text="Bing" class="btn" onclick="btnBing_Click" />
         
        <asp:Button ID="btnHakia" runat="server" Text="Hakia" class="btn" onclick="btnHaxia_Click" />
    </fieldset>
    </div>
    </div>
  
    </form>
</body>
</html>
