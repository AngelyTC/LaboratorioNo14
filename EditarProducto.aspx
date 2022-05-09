<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProducto.aspx.cs" Inherits="LaboratorioNo14.EditarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        ACTUALIZAR</p>
    <p>
        &nbsp;</p>
    <p>
        Ingrese Código de producto</p>
    <p>
        <asp:TextBox ID="txtCodigoPro" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnBuscarP" runat="server" OnClick="btnBuscarP_Click" Text="Buscar Producto" />
    </p>
    <p>
        Nombre Producto</p>
    <p>
        <asp:TextBox ID="txtNombrePro" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripcion Producto</p>
    <p>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio Compra</p>
    <p>
        <asp:TextBox ID="txtCompra" runat="server"></asp:TextBox>
    </p>
    <p>
        Precio Venta</p>
    <p>
        <asp:TextBox ID="txtVenta" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Vencimiento<asp:Calendar ID="CalendarVencimiento" runat="server"></asp:Calendar>
    </p>
    <p>
        Unidad de medida</p>
    <p>
        <asp:TextBox ID="txtUnidad" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
