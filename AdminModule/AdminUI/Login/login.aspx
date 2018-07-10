<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AdminUI.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <br /><br />
                <div class="form-group">
                <asp:Label ID="Label3" runat="server" ForeColor="#FF3300" Text=" "></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesion" />
                <br />
            </div>
        </div>

    </div>


</asp:Content>
