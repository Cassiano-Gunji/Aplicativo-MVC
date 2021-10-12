<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tela.aspx.cs" Inherits="Tela_web.Tela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome: <asp:TextBox ID="txtNome" runat="server" Width="510px"></asp:TextBox>
            <br />
            Telefone:
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnConsulte" runat="server" Text="Consultar" OnClick="btnConsulte_Click" />
            <asp:Button ID="btnInsira" runat="server" Text="Inserir" OnClick="btnInsira_Click" />
            <asp:Button ID="btnAltere" runat="server" Text="Alterar" OnClick="btnAltere_Click" />
            <asp:Button ID="btnExclua" runat="server" Text="Excluir" OnClick="btnExclua_Click" />
            <br />
            <asp:ListBox ID="lbAgenda" runat="server" Height="301px" Width="559px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
