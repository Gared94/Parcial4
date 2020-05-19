using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Productos : System.Web.UI.Page
{
    Productos_BLL objtpro = new Productos_BLL();
    string nombreproducto; int idcategoria; int preciounitario; string detalle; int idProd;

    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDEmpresaConnectionString"].ConnectionString);
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = @"select id_categoria, nombre_categoria from Produccion.Categorias";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        da.Fill(dt);

        ddlCategoria.DataSource = dt;
        ddlCategoria.DataTextField = "nombre_categoria";
        ddlCategoria.DataValueField = "id_categoria";
        ddlCategoria.DataBind();

        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        String dato = ddlCategoria.SelectedValue;
        nombreproducto = txtProducto.Text;
        idcategoria = int.Parse(dato);
        preciounitario = int.Parse(txtPrecio.Text);
        detalle = txtDetalles.Text;
        objtpro.InsertarProductos(nombreproducto, idcategoria, preciounitario, detalle);
       
        nombreproducto = "";
        idcategoria = 0;
        preciounitario = 0;
        detalle = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String dato = ddlCategoria.SelectedValue;
        idProd = int.Parse(txtId.Text);
        nombreproducto = txtProducto.Text;
        idcategoria = int.Parse(dato);
        preciounitario = int.Parse(txtPrecio.Text);
        detalle = txtDetalles.Text;
        objtpro.ActualizarProductos(nombreproducto, idcategoria, preciounitario, detalle, idProd);
        nombreproducto = "";
        idcategoria = 0;
        preciounitario = 0;
        detalle = "";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        idProd = int.Parse(txtId.Text);
        objtpro.EliminarProductos(idProd);
    }
}