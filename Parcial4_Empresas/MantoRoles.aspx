<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MantoRoles.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <table>
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>NOMBRE ROL:</td>
                    <td>
                        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>DESCRIPCION:</td>
                    <td>
                        <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
                     </td>
                </tr>
                 <tr>
                    <td colspan="2">
                        <asp:Button ID="btninsertar" runat="server" Text="INSERTAR" OnClick="btninsertar_Click" />
                        <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click1" />
                        <asp:Button ID="btnactualizar" runat="server" OnClick="btnactualizar_Click" Text="ACTUALIZAR" />
                     </td>
                    
                </tr>
            </table>
        </div>
</asp:Content>

