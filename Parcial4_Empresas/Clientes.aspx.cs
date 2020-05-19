using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Clientes : System.Web.UI.Page
{
    Clientes_BLL objClie = new Clientes_BLL();
    string nomClie, nomCon, direc, ciud, reg, pais, telef, fax, email, cod;
    int idClie;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        nomClie = txtNomClie.Text;
        nomCon = txtNomContac.Text;
        direc = txtDirecc.Text;
        ciud = txtCiudad.Text;
        reg = txtRegion.Text;
        pais = txtPais.Text;
        telef = txtTelef.Text;
        fax = txtFax.Text;
        email = txtEmail.Text;

        objClie.InsertarCliente(nomClie, nomCon, direc, ciud, reg, pais, telef, fax, email);
    }


    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        idClie = int.Parse(txtIDCLiente.Text);
        nomClie = txtNomClie.Text;
        nomCon = txtNomContac.Text;
        direc = txtDirecc.Text;
        ciud = txtCiudad.Text;
        reg = txtRegion.Text;
        pais = txtPais.Text;
        telef = txtTelef.Text;
        fax = txtFax.Text;
        email = txtEmail.Text;

        objClie.ActualizarCliente(idClie, nomClie, nomCon, direc, ciud, reg, pais, telef, fax, email);
    }


    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        idClie = int.Parse(txtIDCLiente.Text);
        objClie.EliminarCliente(idClie);
    }
}