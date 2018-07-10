<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="AdminUI.AdminClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <br />
            <br />        
        <div class="container">

        
        <div class="row align-items-center">
            
            
            <div class="col-sm-12">
                <asp:GridView ID="gvClientes" runat="server" class="table table-striped table-bordered table-responsive" BorderStyle="None" BorderWidth="0px">
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
                    <label for="txtNombre">Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Nombre" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtPriApe">Primer Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPriApe" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
                    </label>
                    &nbsp;<asp:TextBox ID="txtPriApe" runat="server" class="form-control" placeholder="Primer Apellido"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtSegApe">Segundo Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSegApe" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
                    </label>
                    &nbsp;<asp:TextBox ID="txtSegApe" runat="server" class="form-control" placeholder="Segundo Apellido"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtEmail">Correo Electronico&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Formato incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;<asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Correo Electronico"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtTelefono">Telefono
                    </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <label for="txtSegApe"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
                    </label>
                    <asp:TextBox ID="txtTelefono" runat="server" class="form-control" placeholder="Telefono" MaxLength="8"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtContrasena">Contraseña<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtContrasena" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
                    </label>
                    &nbsp;<asp:TextBox TextMode="Password" ID="txtContrasena" runat="server" class="form-control" placeholder="Contraseña"></asp:TextBox>
                </div> 
                   <div class="form-group">
                    <label for="txtrol">Rol<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtrol" ErrorMessage="Este Campo no puede estar vacio"></asp:RequiredFieldValidator>
                       </label>
                    &nbsp;<asp:TextBox  ID="txtrol" runat="server" class="form-control" placeholder="Rol"></asp:TextBox>
                </div> 

                 <div class="form-group">                    <label for="exampleFormControlInput1">Estado</label>
                    <asp:RadioButtonList ID="rbEstado" runat="server" class="form-control">
                        <asp:ListItem Selected="True" Value="True">Activado</asp:ListItem>
                        <asp:ListItem Value="False">Desactivado</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                 <div class="form-row">
                 </div>

        
        <div class="row align-items-center">
            <div class="col-sm-4 offset-3 align-self-start">
                    <asp:Button ID="btnGuardarMod" runat="server" Text="Insertar/Modificar" type="button" class="btn btn-danger" OnClick="btnGuardarMod_Click1"/>
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" type="button" class="btn btn-light" Enabled="False" EnableTheming="True" Visible="False" OnClick="btnBorrar_Click"/>

                    <br />
                    <br />
            </div>
        </div>

        </div>


    </div>
            </div>
    
</asp:Content>
