using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MantoTransportistas : System.Web.UI.Page
{
    Transportistas_BLL objtTransportista = new Transportistas_BLL();
    string nempresa, direccion, ciudad, region, pais, telefono;
    int idTransportista,Cod;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsertar_Click(object sender, EventArgs e)
    {
        nempresa = txtnempresa.Text;
        direccion = txtdireccion.Text;
        ciudad = txtciudad.Text;
        region = txtregion.Text;
        pais = txtpais.Text;
        telefono = txttelefono.Text;

        objtTransportista.InsertarTransportista(nempresa, direccion, ciudad, region, pais,telefono);
    }

    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        idTransportista = int.Parse(txtidtra.Text);
        nempresa = txtnempresa.Text;
        direccion = txtdireccion.Text;
        ciudad = txtciudad.Text;
        region = txtregion.Text;
        pais = txtpais.Text;
        telefono = txttelefono.Text;

        objtTransportista.ActualizarTransportista(idTransportista,nempresa, direccion, ciudad, region, pais, telefono);

    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        idTransportista = int.Parse(txtidtra.Text);
        objtTransportista.EliminarTransportista(idTransportista);
    }
}