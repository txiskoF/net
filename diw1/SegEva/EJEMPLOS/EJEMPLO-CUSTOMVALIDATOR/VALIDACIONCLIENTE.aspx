<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VALIDACIONCLIENTE.aspx.cs" Inherits="VALIDACIONCLIENTE" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" >
        function calculopar(source, args) {
            if (args.Value % 2 == 0)
                args.IsValid = true;
            else
                args.IsValid = false;                         
        }
      </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>Número:</b><asp:TextBox ID="txtnumero" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="cvnumero" runat="server" 
            ClientValidationFunction="calculopar" ControlToValidate="txtnumero" 
            Display="Dynamic" ErrorMessage="Debe introducir un número par" ForeColor="Red"></asp:CustomValidator>
        <br />
        <asp:Button ID="btnmostrar" runat="server" Text="Mostrar" 
            onclick="btnmostrar_Click" /><br/>
        <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
