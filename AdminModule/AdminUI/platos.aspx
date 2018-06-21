<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="platos.aspx.cs" Inherits="AdminUI.platos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 389px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="nombre"></asp:Label>
                    <asp:TextBox ID="nombreT" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
                    <asp:TextBox ID="descripcionT" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
                    <asp:TextBox ID="precioT" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Foto"></asp:Label>
                    <asp:FileUpload ID="fotoT" runat="server" />
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="estado"></asp:Label>
                    <br />
                    <br />
                    <asp:RadioButtonList ID="estadoRb" runat="server" OnSelectedIndexChanged="estadoRb_SelectedIndexChanged">
                        <asp:ListItem Selected="True">activado</asp:ListItem>
                        <asp:ListItem>desactivado</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
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
    </form>
</body>
</html>
