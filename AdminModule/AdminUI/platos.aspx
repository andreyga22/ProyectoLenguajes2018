<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="platos.aspx.cs" Inherits="AdminUI.platos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 594px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            width: 100%;
            height: 142px;
        }
        .auto-style4 {
            width: 56px;
        }
        .auto-style5 {
            height: 30px;
            width: 56px;
        }
        .auto-style6 {
            width: 235px;
        }
        .auto-style7 {
            height: 30px;
            width: 235px;
        }
        .auto-style8 {
            width: 594px;
            height: 136px;
        }
        .auto-style9 {
            height: 136px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <table class="auto-style3">
                        <tr>
                            <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="nombre"></asp:Label>
                            </td>
                            <td class="auto-style6">
                    <asp:TextBox ID="nombreT" runat="server"></asp:TextBox>
                            </td>
                            <td>
                    <asp:Label ID="Label4" runat="server" Text="Foto"></asp:Label>
                    <asp:FileUpload ID="fotoT" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
                            </td>
                            <td class="auto-style6">
                    <asp:TextBox ID="descripcionT" runat="server"></asp:TextBox>
                            </td>
                            <td>
                    <asp:Label ID="Label5" runat="server" Text="estado"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
                            </td>
                            <td class="auto-style7">
                    <asp:TextBox ID="precioT" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style2">
                    <asp:RadioButtonList ID="estadoRb" runat="server" OnSelectedIndexChanged="estadoRb_SelectedIndexChanged">
                        <asp:ListItem Selected="True">activado</asp:ListItem>
                        <asp:ListItem>desactivado</asp:ListItem>
                    </asp:RadioButtonList>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                </td>
                <td>
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:TextBox ID="buscarTxt" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    <br />
                    <asp:TextBox ID="buscarTxt0" runat="server"></asp:TextBox>
                    <asp:TextBox ID="buscarTxt1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="buscarTxt2" runat="server"></asp:TextBox>
                    <asp:TextBox ID="buscarTxt3" runat="server"></asp:TextBox>
                            <asp:Image ID="Image1" runat="server" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnLista" runat="server" Text="Ver Todos" OnClick="btnLista_Click" />
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
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
