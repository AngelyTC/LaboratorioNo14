<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LaboratorioNo14._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>VENTA DE ALIMENTOS </h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="Código del producto"></asp:Label>
            <br />
            <asp:TextBox ID="txtCodigoP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre del producto"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombreP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Descripción del producto"></asp:Label>
            <br />
            <asp:TextBox ID="txtDescripcionP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Precio de la Compra"></asp:Label>
            <br />
            <asp:TextBox ID="txtPrecioCompra" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Precio Venta"></asp:Label>
            <br />
            <asp:TextBox ID="txtPrecioVenta" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Fecha Vencimiento"></asp:Label>
            <br />
            <asp:Calendar ID="CalendarFechaV" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Unidad de medida de venta"></asp:Label>
            <br />
            <asp:TextBox ID="txtUnidad" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="btnIngresoP" runat="server" Height="40px" OnClick="btnIngresoP_Click" Text="Ingresar Producto" Width="179px" />
            <br />
            <br />
            <br />
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
