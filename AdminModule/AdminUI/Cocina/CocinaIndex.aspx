<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="CocinaIndex.aspx.cs" Inherits="AdminUI.Cocina.CocinaIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <br />
        <br />

        <asp:Button ID="btnEntregar" type="button" class="btn btn-primary" runat="server" Text="Entregar Pedido" OnClick="btnEntregar_Click" />
        <asp:literal runat="server" ID="fila1"></asp:literal>
        <asp:literal runat="server" ID="fila2"></asp:literal>
        <asp:label class="text-center" runat="server" text="4 mas en cola" ID="lblRestantes"></asp:label>
        <br />
        <br />
        <br />
        <div class="row align-items-center">
            <div class="col align-self-center">
                <asp:Button ID="btnDevolver" type="button" class="btn btn-danger" runat="server" Text="Devolver" />
            </div>
        </div>
        <br />
        </div>
        
</asp:Content>
