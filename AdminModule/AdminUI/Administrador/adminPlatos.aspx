<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="adminPlatos.aspx.cs" Inherits="AdminUI.adminPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <div class="container">




        <br />
        <br />

        <div class="row align-items-center">
            
            
            <div class="col-12">
                <asp:GridView ID="gvPlatos" runat="server" class="table table-striped table-bordered table-responsive" BorderStyle="None" BorderWidth="0px">
                </asp:GridView>
            </div>
           
        </div>
        <br />
        <div class="row align-items-center">
            
             <div class="col-sm-6 offset-sm-3 align-self-start">
                
                <div class="form-group">
                    <label for="exampleFormControlInput1">Buscar</label>
                    <asp:TextBox ID="txtBuscar" runat="server" class="form-control" placeholder="Codigo" ></asp:TextBox>
                    
                </div>
                <div class="col-sm-3 offset-md-4">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" type="button" class="btn btn-danger" OnClick="btnBuscar_Click" CausesValidation="False"/>
                </div>
                <br />
                

                <div class="form-group">
                    <label for="exampleFormControlInput1">Codigo</label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCod" ErrorMessage="Espacio necesario"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtCod" runat="server" class="form-control" placeholder="Codigo" Enabled="False" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlInput1">Nombre</label><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNom" ErrorMessage="Espacio necesario"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtNom" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlInput1">Descripcion</label><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDes" ErrorMessage="Espacio necesario"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtDes" runat="server" class="form-control" placeholder="Descripcion"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlInput1">Precio</label><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPre" ErrorMessage="Espacio necesario"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtPre" runat="server" class="form-control" placeholder="Precio"></asp:TextBox>
                </div>
                 


                 <div class="form-row">
                     <div class="form-group col-sm-6">
                        <label for="exampleFormControlInput1">Fotografia</label>
                        <asp:FileUpload ID="Foto" runat="server" class="form-control"/>
                    </div>
                     <div class="form-group col-sm-6">
                        <label for="exampleFormControlInput1">Foto</label>
                        <asp:Image ID="Image2" runat="server" Height="60px" Width="60px" />
                    </div>
                 </div>

                     



                
                <div class="form-group">
                    <label for="exampleFormControlInput1">Estado<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="rbEstado" ErrorMessage="Espacio necesario"></asp:RequiredFieldValidator>
                    </label>
                    &nbsp;<asp:RadioButtonList ID="rbEstado" runat="server" class="form-control">
                        <asp:ListItem Selected="True" Value="True">Activado</asp:ListItem>
                        <asp:ListItem Value="False">Desactivado</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>

        </div>
        <div class="row align-items-center">
            <div class="col-sm-4 offset-3 align-self-start">
                    <asp:Button ID="btnGuardarMod" runat="server" Text="Insertar/Modificar" type="button" class="btn btn-danger" OnClick="btnGuardarMod_Click"/>
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" type="button" class="btn btn-light" OnClick="btnBorrar_Click"/>

                    <br />
                    <br />
            </div>
        </div>


    </div>








































    </asp:Content>
