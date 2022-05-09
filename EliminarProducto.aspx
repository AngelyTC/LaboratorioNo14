<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="LaboratorioNo14.EliminarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Eliminar</p>
    <p>
        Código Producto</p>
    <p>
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Producto" />
    </p>
    <p>
        Nombre Producto</p>
    <p>
        <asp:TextBox ID="txtNombreProducto" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripcion Producto</p>
    <p>
        <asp:TextBox ID="txtNombreDescrip" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar producto" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
