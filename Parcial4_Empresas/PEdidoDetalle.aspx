<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PedidoDetalle.aspx.cs" Inherits="PedidoDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    ID
    <asp:textbox runat="server" ID="txtID"></asp:textbox>
    <br />
    producto
    <asp:dropdownlist runat="server" ID="ddlPedidoD"></asp:dropdownlist>
    <br />
    Precio
    <asp:textbox runat="server" ID="txtPrecio"></asp:textbox>
    <br />
    Cantidad
    <asp:textbox runat="server" ID="txtCantidad"></asp:textbox>
    <br />
    Descuento
    <asp:textbox runat="server" ID="txtDescuento"></asp:textbox>
    <br />
    <br />
    <asp:button runat="server" text="Insertar" OnClick="Unnamed1_Click" />
    <asp:button runat="server" text="Actualizar" OnClick="Unnamed2_Click" />
    <asp:button runat="server" text="Eliminar" OnClick="Unnamed3_Click" />
</asp:Content>


