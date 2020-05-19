<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MantoUsuarios.aspx.cs" Inherits="MantoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>ID USUARIO:</td>
            <td>
                <asp:TextBox ID="txtiduser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>USUARIO:</td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>CONTRASEÑA:</td>
            <td>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>ID ROL:</td>
            <td>
                <asp:TextBox ID="txtidrol" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>ESTADO:</td>
            <td>
                <asp:TextBox ID="txtestado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btninsertar" runat="server" OnClick="btninsertar_Click" Text="Insertar" />
                <asp:Button ID="btnactualizar" runat="server" OnClick="btnactualizar_Click" Text="Actualizar" />
                <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
            </td>
        </tr>
    </table>
</asp:Content>

