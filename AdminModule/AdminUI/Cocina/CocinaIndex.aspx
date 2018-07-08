<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="CocinaIndex.aspx.cs" Inherits="AdminUI.Cocina.CocinaIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <br />
        <br />
        <%--<div class="row align-items-center">
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-success mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Success card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                      <a href="#" class="btn btn-primary">Go somewhere</a>
                  </div>
                </div>
            </div>
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-danger mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Danger card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                  </div>
                </div>
                </div>
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-warning mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Warning card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                  </div>
                </div>
            </div>
        </div>
        <div class="row align-items-center">
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-danger mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Danger card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                  </div>
                </div>
                </div>
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-warning mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Warning card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                  </div>
                </div>
            </div>
            <div class="col-lg-4 align-self-center">
                <div class="card text-white bg-danger mb-3" style="max-width: 18rem;">
                  <div class="card-header">Header</div>
                  <div class="card-body">
                    <h5 class="card-title">Danger card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                  </div>
                </div>
                </div>
        </div>--%>
        <asp:literal runat="server" ID="fila2"></asp:literal>
        <asp:literal runat="server" ID="fila1"></asp:literal>
        <asp:label class="text-center" runat="server" text="4 mas en cola"></asp:label>
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
