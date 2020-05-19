using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Roles_BLL objtB = new Roles_BLL();
    string rol, desc;
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsertar_Click(object sender, EventArgs e)
    {
        rol = txtnombre.Text;
        desc = txtdesc.Text;
        objtB.InsertarRoles(rol, desc);
    }

    protected void btnEliminar_Click1(object sender, EventArgs e)
    {
        id = int.Parse(txtid.Text);
        objtB.EliminarRoles(id);
    }

    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        rol = txtnombre.Text;
        desc = txtdesc.Text;
        id = int.Parse(txtid.Text);
        objtB.ActualizarRoles(rol, desc, id);
    }
}