<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="platos.aspx.cs" Inherits="AdminUI.platos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 258px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                </td>
                <td>
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
                <td>
                    <asp:Button ID="btnLista" runat="server" Text="Ver Todos" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
                </td>
                <td>
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
