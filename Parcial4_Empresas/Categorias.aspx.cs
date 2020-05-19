using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Categorias : System.Web.UI.Page
{
    Categorias_BLL objC = new Categorias_BLL();
    string nomCat, descrip, cod;
    int idCat;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        nomCat = TextBox2.Text;
        descrip = TextBox3.Text;
        objC.InsertarCategoria(nomCat, descrip);
    }



    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        idCat = int.Parse(TextBox1.Text);
        nomCat = TextBox2.Text;
        descrip = TextBox3.Text;

        objC.ActualizarCategoria(idCat, nomCat, descrip);
    }



    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        idCat = int.Parse(TextBox1.Text);
        objC.EliminarCategoria(idCat);
    }
}