<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteMenu.aspx.cs" Inherits="AdminUI.ClienteMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="primer apellido"></asp:Label>
        <asp:TextBox ID="txtPri" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="segundo apellido"></asp:Label>
        <asp:TextBox ID="txtSeg" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="telefono"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="contraseña"></asp:Label>
        <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="rol"></asp:Label>
        <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Estado"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Selected="True">Activado</asp:ListItem>
            <asp:ListItem>Desactivado</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar" />
        <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="eliminar" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar" Height="26px" />
        <br />
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
