<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Productos.aspx.cs" Inherits="Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
  
    
    
    Id
    <asp:TextBox ID="txtId" runat="server" placeholder="Campo exclusivo para actualizar y eliminar"></asp:TextBox>
   <br />
    Producto
    <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
    <br />
    Categoria
    <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
    <br />
    Precio
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
    <br />
    Detalles
    <asp:TextBox ID="txtDetalles" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />
</asp:Content>
