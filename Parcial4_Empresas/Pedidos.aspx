<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Pedidos.aspx.cs" Inherits="Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Id
    <asp:TextBox ID="txtID" runat="server" placeholder="Campo a utilizar para actualizar y borrar (debe conocer ID del dato a borrar"></asp:TextBox> 
    <br />
Cliente
    
    <asp:DropDownList ID="ddlCliente" runat="server">
    </asp:DropDownList>
    <br />
    transportista
    <asp:DropDownList ID="ddlTransportista" runat="server"></asp:DropDownList>

    <br />
    Empleado
    <asp:DropDownList ID="ddlEmpleado" runat="server"></asp:DropDownList>

   <br />
   
    Costo
    <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>

     <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />

</asp:Content>

