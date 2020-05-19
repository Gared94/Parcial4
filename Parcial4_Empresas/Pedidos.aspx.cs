using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pedidos : System.Web.UI.Page
{
    Pedidos_BLL objtpedido = new Pedidos_BLL();
    int idcliente; int idtransportista; int idempleado; DateTime fechaO; DateTime fechaR; DateTime fechaE; int costo; int idpedido;

    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDEmpresaConnectionString"].ConnectionString);
    DataTable dt = new DataTable();
    DataTable dt1 = new DataTable();

    DataTable dt2 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = @"SELECT id_cliente, nombre_cliente from Ventas.Clientes";

        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        da.Fill(dt);

        ddlCliente.DataSource = dt;
        ddlCliente.DataTextField = "nombre_cliente";
        ddlCliente.DataValueField = "id_cliente";
        ddlCliente.DataBind();

        con.Close();
        string query2 = @"select id_transportista, nombre_empresa from Ventas.Transportistas";
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter(query2, con);
        da1.Fill(dt1);

        ddlTransportista.DataSource = dt1;
        ddlTransportista.DataTextField = "nombre_empresa";
        ddlTransportista.DataValueField = "id_transportista";
        ddlTransportista.DataBind();

        con.Close();
        string query3 = @"select id_empleado, nombre_empleado from RecursosHumanos.Empleados";
        con.Open();
        SqlDataAdapter da2 = new SqlDataAdapter(query3, con);
        da2.Fill(dt2);

        ddlEmpleado.DataSource = dt2;
        ddlEmpleado.DataTextField = "nombre_empleado";
        ddlEmpleado.DataValueField = "id_empleado";
        ddlEmpleado.DataBind();

        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Write(" < script>alert('Mensaje');</script>");
        //String dato = ddlCliente.DataValueField.ToString();
        String dato = ddlCliente.SelectedValue;
        String dato1 = ddlTransportista.SelectedValue;
        String dato2 = ddlEmpleado.SelectedValue;
        idcliente = int.Parse(dato);
        //idcliente = int.Parse(txtCliente.Text);
        idtransportista = int.Parse(dato1);
        idempleado = int.Parse(dato2);

        costo = int.Parse(txtCosto.Text);
        objtpedido.InsertarPedido(idcliente, idtransportista, idempleado, fechaO, fechaR, fechaE, costo);


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String dato = ddlCliente.SelectedValue;

        String dato1 = ddlTransportista.SelectedValue;

        String dato2 = ddlEmpleado.SelectedValue;
        idcliente = int.Parse(dato);
        idtransportista = int.Parse(dato1);
        idempleado = int.Parse(dato2);

        costo = int.Parse(txtCosto.Text);
        objtpedido.ActualizarPedido(idpedido, idcliente, idtransportista, idempleado, fechaO, fechaR, fechaE, costo);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        idpedido = int.Parse(txtID.Text);
        objtpedido.EliminarPedido(idpedido);
    }
}