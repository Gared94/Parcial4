using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TransportistasDTO
/// </summary>
public class TransportistasDTO
{
    public TransportistasDTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_transportista { get; set; }
    public string nombre_empresa { get; set; }
    public string direccion { get; set; }
    public string ciudad { get; set; }
    public string region { get; set; }
    public string pais { get; set; }
    public string telefono { get; set; }
    public string codigo { get; set; }
}