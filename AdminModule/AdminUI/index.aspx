<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AdminUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modulo Administracion</title>
    <style type="text/css">
        .auto-style1 {
            width: 205px;
        }
        .auto-style2 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnPlatos" runat="server" Text="Platos" Width="75px" OnClick="btnPlatos_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnPedidos" runat="server" Text="Pedidos" Width="75px" OnClick="btnPedidos_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnUsuarios" runat="server" Text="Usuarios" Width="75px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnEstados" runat="server" Text="Estados" Width="75px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnClientes" runat="server" Text="Clientes" Width="75px"/>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Salir" runat="server" Text="Salir" Width="75px"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
