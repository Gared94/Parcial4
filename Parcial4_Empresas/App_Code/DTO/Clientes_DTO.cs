using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Clientes_DTO
/// </summary>
public class Clientes_DTO
{
    public Clientes_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_cliente { get; set; }
    public string nombre_cliente { get; set; }
    public string nombre_contacto { get; set; }
    public string direccion { get; set; }
    public string ciudad { get; set; }
    public string region { get; set; }
    public string pais { get; set; }
    public string telefono { get; set; }
    public string fax { get; set; }
    public string email { get; set; }
    public string codigo { get; set; }
}