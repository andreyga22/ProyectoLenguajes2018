<%@ Page Title="" Language="C#" MasterPageFile="~/AdminModule.Master" AutoEventWireup="true" CodeBehind="AdminPedidos.aspx.cs" Inherits="AdminUI.AdminPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 187px;
        }
        .auto-style2 {
            height: 151px;
        }
        .auto-style3 {
            height: 274px;
        }
        .auto-style4 {
            height: 274px;
            width: 241px;
        }
        .auto-style5 {
            height: 151px;
            width: 241px;
        }
        .auto-style6 {
            height: 187px;
            width: 241px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:100%;">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label14" runat="server" Text="Busqueda por email"></asp:Label>
                <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
                <br />
                <br />
                <br />
        <asp:Label ID="Label4" runat="server" Text="CODIGO: "></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Limpiar" />
                <br />
        <asp:Label ID="Label5" runat="server" Text="FECHA: "></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
    
        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
                <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
        <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
                <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
        <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="editar" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="eliminar" />
            </td>
            <td class="auto-style3">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style5">
        <asp:Label ID="Label8" runat="server" Text="Email cliente"></asp:Label>
                <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
        <asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>
                <br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Fechas"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="Fecha inicio"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Text="Fecha fin"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
        <asp:Button ID="Button5" runat="server" Text="filtrar lista" OnClick="Button5_Click" />
        <asp:GridView ID="GridView1" runat="server" Width="453px">
        </asp:GridView>
    
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
    </table>


</asp:Content>
