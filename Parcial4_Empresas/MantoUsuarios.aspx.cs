using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MantoUsuarios : System.Web.UI.Page
{
    Usuarios_BLL objtUsuarios = new Usuarios_BLL();
    int iduser,idRol;
    string nombre, pass, estado;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsertar_Click(object sender, EventArgs e)
    {
        nombre = txtnombre.Text;
        pass = txtpass.Text;
        idRol = int.Parse(txtidrol.Text);
        estado = txtestado.Text;
        objtUsuarios.InsertarUsuarios(nombre, pass, idRol, estado);

    }

    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        nombre = txtnombre.Text;
        pass = txtpass.Text;
        idRol = int.Parse(txtidrol.Text);
        estado = txtestado.Text;
        iduser = int.Parse(txtiduser.Text);
        objtUsuarios.ActualizarUsuarios(nombre, pass, idRol, estado, iduser);

    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        iduser = int.Parse(txtiduser.Text);
        objtUsuarios.EliminarUsuarios(iduser);
    }
}