<%@ Page Title="" Language="C#" MasterPageFile="~/AdminModule.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AdminUI.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" ForeColor="#FF3300" Text=" "></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesion" />
    <br />
</asp:Content>
