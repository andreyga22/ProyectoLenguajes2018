<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="AdminPedidos.aspx.cs" Inherits="AdminUI.AdminPedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <br/>
        <div class="row align-items-center">
            <div class="col-12">
            <asp:GridView ID="GridView1" runat="server" class="table table-striped table-bordered table-responsive" BorderStyle="None" BorderWidth="0px">
            </asp:GridView>
        </div>
              </div>
        <br/>


        <div class="row align-items-center">
            <div class="col col-sm-md-6">
                <div class="row align-items-center">

                    <div class="col-sm-3">
                    <asp:Label ID="Label8" runat="server" Text="Email cliente"></asp:Label>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
</div>
                        <div class="col-sm-3">
                    <asp:Label ID="Label11" runat="server" Text="Fechas"></asp:Label>
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                            </div>
                            <div class="col-sm-3">
                    <asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
</div>
                    <div class="col-sm-3">
                    <asp:Button class="btn btn-danger" ID="Button5" runat="server" Text="filtrar lista" OnClick="Button5_Click" CausesValidation="False" />
                </div>
                </div>


                 <br/>
                <div class="col-sm-6 offset-sm-3 align-self-start">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                    </div>
                

                <br/>
                <div class="col-sm-6 offset-sm-3 align-self-start">
                <asp:Label ID="Label12" runat="server" Text="Fecha inicio"></asp:Label>
                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                <br />
                <asp:Label ID="Label13" runat="server" Text="Fecha fin"></asp:Label>
                <asp:Calendar ID="Calendar3" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                    </div>
                <br/>

                <div class="row align-items-center">
                    <div class="col-sm-6 offset-sm-3 align-self-start">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                            <asp:ListItem>A Tiempo</asp:ListItem>
                            <asp:ListItem>Sobre Tiempo</asp:ListItem>
                            <asp:ListItem>Demorado</asp:ListItem>
                            <asp:ListItem>Anulado</asp:ListItem>
                            <asp:ListItem>Entregado</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                </div>
            </div>
            <div class="col col-sm-md-6">

                <div class="row align-items-center">

                    <div class="col col-12 align-self-start">

                        <div class="form-group">
                            <asp:Label ID="Label14" runat="server" Text="Busqueda por email"></asp:Label>
                            <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row align-items-center">

                    <div class="col-sm-6 offset-4">


                        <asp:Button ID="Button2" class="btn btn-danger" runat="server" Text="Buscar" OnClick="Button2_Click" CausesValidation="False" />

                        <asp:Button ID="Button6" class="btn btn-ligh" runat="server" OnClick="Button6_Click" Text="Limpiar" CausesValidation="False" />



                    </div>
                </div>
                <br />

                <div class="row align-items-center">
                    <div class="col col-12 align-self-start">
                        
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Codigo"></asp:Label>
                            <asp:TextBox class="form-control" ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
                            <asp:TextBox class="form-control" ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Espacio vacio"></asp:RegularExpressionValidator>
                            <asp:TextBox class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Seleccione un estado"></asp:RequiredFieldValidator>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem>A Tiempo</asp:ListItem>
                                <asp:ListItem>Sobre Tiempo</asp:ListItem>
                                <asp:ListItem>Demorado</asp:ListItem>
                                <asp:ListItem>Anulado</asp:ListItem>
                                <asp:ListItem>Entregado</asp:ListItem>
                            </asp:RadioButtonList>
                            <br />
                        </div>
                    </div>
                </div>

                <div class="row align-items-center">
                    <div class="col-sm-6 offset-4">
                        <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Insertar/Modificar" OnClick="Button1_Click" />
                        <asp:Button class="btn btn-light" ID="Button4" runat="server" OnClick="Button4_Click" Text="eliminar" />
                        <br />
                        <br />
                    </div>
                </div>

            </div>
        </div>







    </div>

</asp:Content>
