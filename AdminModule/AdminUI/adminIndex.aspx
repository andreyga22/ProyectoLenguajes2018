<%@ Page Title="" Language="C#" MasterPageFile="~/AdminModule.Master" AutoEventWireup="true" CodeBehind="adminIndex.aspx.cs" Inherits="AdminUI.adminIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
       <br />
       <br />
       <br />
       
       <div class ="row align-items-center">
           <div class ="col-sm-6 align-self-center" >
               <div class="card" style="width: 18rem;">
                  <img class="card-img-top" src="server_images/order.jpg" alt="Card image cap" height="200" width="200"/>
                  <div class="card-body">
                    <h5 class="card-title">Pedidos</h5>
                    <p class="card-text">Administre todos los pedidos</p>
                    <a href="AdminPedidos.aspx" class="btn btn-primary">Pedidos</a>
                  </div>
                </div>
           </div>
           
           <div class ="col-sm-6 align-self-center">
               <div class="card" style="width: 18rem;">
                  <img class="card-img-top" src="server_images/paella.jpg" alt="Card image cap" height="200" width="200"/>
                  <div class="card-body">
                    <h5 class="card-title">Platos</h5>
                    <p class="card-text">Administre todos los platos</p>
                    <a href="adminPlatos.aspx" class="btn btn-primary">Platos</a>
                  </div>
                </div>
           </div>
       </div>
       
       <div class ="row align-items-center">
           <div class ="col-sm-6 align-self-center">
               <div class="card" style="width: 18rem;">
                  <img class="card-img-top" src="server_images/client.jpg" alt="Card image cap" height="200" width="200"/>
                  <div class="card-body">
                    <h5 class="card-title">Clientes y usuarios</h5>
                    <p class="card-text">Ventana de administracion de cuentas de usuarios y clientes</p>
                    <a href="AdminClientes.aspx" class="btn btn-primary">Clientes y usuarios</a>
                  </div>
                </div>
           </div>
           
           <div class ="col-sm-6 align-self-center">
               <div class="card" style="width: 18rem;">
                  <img class="card-img-top" src="server_images/paella.jpg" alt="Card image cap" height="200" width="200"/>
                  <div class="card-body">
                    <h5 class="card-title">Alguna otra cosa</h5>
                    <p class="card-text">Administre alguna otra cosa</p>
                    <a href="#" class="btn btn-primary">Otros</a>
                  </div>
                </div>
           </div>
       </div>
       

   </div>
</asp:Content>


