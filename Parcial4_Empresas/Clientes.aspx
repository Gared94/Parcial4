<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Clientes.aspx.cs" Inherits="Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>ID Cliente:</td>
            <td>
                <asp:TextBox ID="txtIDCLiente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre Cliente:</td>
            <td>
                <asp:TextBox ID="txtNomClie" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre Contacto:</td>
            <td>
                <asp:TextBox ID="txtNomContac" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Direccion:</td>
            <td>
                <asp:TextBox ID="txtDirecc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Ciudad:</td>
            <td>
                <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Region:</td>
            <td>
                <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Pais:</td>
            <td>
                <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefono:</td>
            <td>
                <asp:TextBox ID="txtTelef" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fax:</td>
            <td>
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Codigo:</td>
            <td>
                <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" />
&nbsp;<asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
&nbsp;<asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            </td>
        </tr>
    </table>
</asp:Content>

