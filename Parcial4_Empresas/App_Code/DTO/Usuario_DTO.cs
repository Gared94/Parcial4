using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario_DTO
/// </summary>
public class Usuario_DTO
{
    public Usuario_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_usuario { get; set; }
    public string usuario { get; set; }
    public string pass_user { get; set; }
    public int id_rol { get; set; }
    public string estado { get; set; }
}