using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PedidoDetalle : System.Web.UI.Page
{
    PedidosDetalle_BLL objtpedido = new PedidosDetalle_BLL();
    int idpedido; int idproducto; decimal precio; int cantidad; decimal descuento;

    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDEmpresaConnectionString"].ConnectionString);
    DataTable dt = new DataTable();
    DataTable dt1 = new DataTable();

    DataTable dt2 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = @"select id_producto, nombre_producto from Produccion.Productos";

        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        da.Fill(dt);

        ddlPedidoD.DataSource = dt;
        ddlPedidoD.DataTextField = "nombre_producto";
        ddlPedidoD.DataValueField = "id_producto";
        ddlPedidoD.DataBind();
        

        con.Close();
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        String dato1 = ddlPedidoD.SelectedValue;
        idpedido = int.Parse(txtID.Text);
        //idcliente = int.Parse(txtCliente.Text);
        idproducto = int.Parse(dato1);
        precio = int.Parse(txtPrecio.Text);
        cantidad = int.Parse(txtCantidad.Text);
        descuento = int.Parse(txtDescuento.Text);
        objtpedido.InsertarPedidoDetalle(idpedido, idproducto, precio, cantidad, descuento);
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        String dato1 = ddlPedidoD.SelectedValue;
        idpedido = int.Parse(txtID.Text);
        //idcliente = int.Parse(txtCliente.Text);
        idproducto = int.Parse(dato1);
        precio = int.Parse(txtPrecio.Text);
        cantidad = int.Parse(txtCantidad.Text);
        descuento = int.Parse(txtDescuento.Text);
        objtpedido.ActualizarPedidoDetalle(idpedido, idproducto, precio, cantidad, descuento);
    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        String dato1 = ddlPedidoD.SelectedValue;
        idpedido = int.Parse(txtID.Text);
        idproducto = int.Parse(dato1);
        objtpedido.EliminarPedidoDetalle(idpedido, idproducto);
    }
}