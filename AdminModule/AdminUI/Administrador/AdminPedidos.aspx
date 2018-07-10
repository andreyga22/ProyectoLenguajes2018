<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="AdminPedidos.aspx.cs" Inherits="AdminUI.AdminPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 151px;
        }
        .auto-style7 {
            width: 147%;
        }
        .auto-style9 {
            height: 151px;
            width: 527px;
        }
        .auto-style12 {
            height: 151px;
            width: 211px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row align-items-center">
            <div class="col-sm-6 offset-sm-3 align-self-start">

                <div class="form-group">
      <asp:Label ID="Label14" runat="server" Text="Busqueda por email"></asp:Label>
       <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
       </div>

                 <div class="col-sm-3 offset-md-4">
                     <asp:Button ID="Button2" class="btn btn-danger" runat="server" Text="Buscar" OnClick="Button2_Click" CausesValidation="False" />
                    &nbsp;
                    <asp:Button ID="Button6" class="btn btn-danger" runat="server" OnClick="Button6_Click" Text="Limpiar" CausesValidation="False" />
   
                 </div>

                <br />

                <div class="form-group">
        <asp:Label ID="Label4" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox  class="form-control" ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
                 </div>
                    <div class="form-group">
        <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
        <asp:TextBox  class="form-control" ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
                </div>

       <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Espacio vacio"></asp:RegularExpressionValidator>
        <asp:TextBox  class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
       </div>
        <div class="form-group">   
        <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>A Tiempo</asp:ListItem>
                    <asp:ListItem>Sobre Tiempo</asp:ListItem>
                    <asp:ListItem>Demorado</asp:ListItem>
                    <asp:ListItem>Anulado</asp:ListItem>
                    <asp:ListItem>Entregado</asp:ListItem>
                </asp:RadioButtonList>
            <br />
               </div>

                 <div class="row align-items-center">
            <div class="col-sm-4 offset-3 align-self-start">
        <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Insertar/Modificar" OnClick="Button1_Click" />
        <asp:Button class="btn btn-light" ID="Button4" runat="server" OnClick="Button4_Click" Text="eliminar" />
               <br />
                    <br />
            </div>
                      </div>



    
            </div>
        </div>
    </div>

    <table class="auto-style7">
        <tr>
            <td class="auto-style12">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button class="btn btn-danger" ID="Button5" runat="server" Text="filtrar lista" OnClick="Button5_Click" CausesValidation="False" />
                <br />
                <br />
                <br />
                <br />
        &nbsp;<br />
        <asp:Label ID="Label8" runat="server" Text="Email cliente"></asp:Label>
                <asp:CheckBox ID="CheckBox2" runat="server" />
                <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
                <br />
        <asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <br />
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>A Tiempo</asp:ListItem>
                    <asp:ListItem>Sobre Tiempo</asp:ListItem>
                    <asp:ListItem>Demorado</asp:ListItem>
                    <asp:ListItem>Anulado</asp:ListItem>
                    <asp:ListItem>Entregado</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
            </td>
            <td class="auto-style9">
        &nbsp;<asp:GridView ID="GridView1" runat="server" Width="502px" Height="532px">
        </asp:GridView>
    
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
    
            </td>
            <td class="auto-style2">
                <asp:Label ID="Label11" runat="server" Text="Fechas"></asp:Label>
                <asp:CheckBox ID="CheckBox3" runat="server" />
                <br />
                <br />
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
            </td>
        </tr>
      
    </table>


</asp:Content>
