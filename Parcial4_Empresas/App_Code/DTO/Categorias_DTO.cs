using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriasDTO
/// </summary>
public class CategoriasDTO
{
    public CategoriasDTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_categoria { get; set; }
    public string nombre_categoria { get; set; }
    public string descripcion { get; set; }
    public string codigo { get; set; }

}