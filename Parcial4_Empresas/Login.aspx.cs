using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDEmpresaConnectionString"].ConnectionString);
    DataTable dt = new DataTable();
    public SqlDataReader sqldr;

    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String usuario = Request.Form["user"];
        String pwd = Request.Form["pass"];

        if (usuario != "" && pwd != "")
        { 
            string consulta = "SELECT* FROM Usuarios where usuario = '"+usuario+"' and pass_user = '"+pwd+"'";
            conectar(consulta);
            while (sqldr.Read())
            {
                Response.Write(@"<script>document.location.href = 'Index.aspx';</script>"); //hay algo malo en la consulta
            }
            con.Close();

            string validaruser = "";

            consulta = "SELECT* FROM Usuarios where usuario = '" + usuario + "'";
            conectar(consulta);
            while (sqldr.Read())
            {
                validaruser = usuario;
            }
            con.Close();

            if (validaruser != "")
            {
                usuario = "";
                string password = "";

                consulta = "SELECT* FROM Usuarios where usuario = '" + usuario + "'";
                conectar(consulta);
                while (sqldr.Read())
                {
                    usuario = "usuario";
                }
                con.Close();
                if (usuario != "")
                {
                    consulta = "SELECT* FROM Usuarios where usuario = '" + usuario + "' and pass_user = '" + pwd + "'')";
                    conectar(consulta);
                    while (sqldr.Read())
                    {
                        password = "password";
                    }
                    con.Close();
                    if (password == "")
                    {
                        Response.Write("<script>alert('Datos no validos');</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Contraseña incorrecta');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('El usuario ingresado no es valido');</script>");
            }

        }
        else
        {
            Response.Write("<script>alert('No pueden haber campos vacíos');</script>");
        }
    }

    public void conectar(String query)
    {
        con.Open();
        SqlCommand com = new SqlCommand(query, con); //:) es neta? 
        sqldr = com.ExecuteReader();

    }
}