using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleados : System.Web.UI.Page
{
    Empleados_BLL objEmp = new Empleados_BLL();
    string nomEmp, apEmp, direc, ciud, reg, pais, telef, cod;
    int idEmp;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        nomEmp = TextBox2.Text;
        apEmp = TextBox3.Text;
        direc = TextBox4.Text;
        ciud = TextBox5.Text;
        reg = TextBox6.Text;
        pais = TextBox7.Text;
        telef = TextBox8.Text;

        objEmp.InsertarEmpleado(nomEmp, apEmp, direc, ciud, reg, pais, telef);
    }



    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        idEmp = int.Parse(TextBox1.Text);
        nomEmp = TextBox2.Text;
        apEmp = TextBox3.Text;
        direc = TextBox4.Text;
        ciud = TextBox5.Text;
        reg = TextBox6.Text;
        pais = TextBox7.Text;
        telef = TextBox8.Text;

        objEmp.ActualizarEmpleado(idEmp, nomEmp, apEmp, direc, ciud, reg, pais, telef);
    }


    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        idEmp = int.Parse(TextBox1.Text);
        objEmp.EliminarEmpleado(idEmp);
    }
}