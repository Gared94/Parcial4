<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MantoTransportistas.aspx.cs" Inherits="MantoTransportistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>ID TRANSPORTISTA:</td>
            <td>
                <asp:TextBox ID="txtidtra" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>NOMBRE EMPRESA:</td>
            <td>
                <asp:TextBox ID="txtnempresa" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>DIRECCION:</td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>CIUDAD:</td>
            <td>
                <asp:TextBox ID="txtciudad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>REGION:</td>
            <td>
                <asp:TextBox ID="txtregion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>PAIS:</td>
            <td>
                <asp:TextBox ID="txtpais" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>TELEFONO:</td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <asp:Button ID="btninsertar" runat="server" OnClick="btninsertar_Click" Text="Insertar" />
                <asp:Button ID="btnactualizar" runat="server" OnClick="btnactualizar_Click" Text="Actualizar" />
                <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
            </td>
        </tr>
    </table>
</asp:Content>

