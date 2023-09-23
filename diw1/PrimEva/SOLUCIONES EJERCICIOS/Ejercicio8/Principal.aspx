<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 13px; top: 25px; position: absolute; height: 229px; width: 172px">
          
                <asp:RadioButton ID="RdbMasculino" runat="server" Text="Masculino" AutoPostBack="True" GroupName="Sexo" OnCheckedChanged="RdbMasculino_CheckedChanged" />
                <br />
                <asp:RadioButton ID="RdbFemenino" runat="server" Text="Femenino" AutoPostBack="True" GroupName="Sexo" OnCheckedChanged="RdbFemenino_CheckedChanged" />
            </asp:Panel>
          <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 292px; top: 22px; position: absolute; height: 154px; width: 146px">
              <asp:RadioButton ID="RdbSoltero" runat="server" AutoPostBack="True" GroupName="EstadoCivil" OnCheckedChanged="CambioEstado" Text="Soltero" />
                <br />
                <asp:RadioButton ID="RdbCasado" runat="server" AutoPostBack="True" GroupName="EstadoCivil" OnCheckedChanged="CambioEstado" Text="Casado" />
                <br />
                <asp:RadioButton ID="RdbViudo" runat="server" AutoPostBack="True" GroupName="EstadoCivil" OnCheckedChanged="CambioEstado" Text="Viudo" />
                <br />
                <asp:RadioButton ID="RdbDivoirciado" runat="server" AutoPostBack="True" GroupName="EstadoCivil" OnCheckedChanged="CambioEstado" Text="Divorciado" />
        </asp:Panel>
    
    </div>
        <asp:Label ID="LblEstado" runat="server" style="z-index: 1; left: 37px; top: 272px; position: absolute"></asp:Label>
    </form>
</body>
</html>
