using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleados_DTO
/// </summary>
public class Empleados_DTO
{
    public Empleados_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_empleado { get; set; }
    public string nombre_empleado { get; set; }
    public string apellido_empleado { get; set; }
    public string direccion { get; set; }
    public string ciudad { get; set; }
    public string region { get; set; }
    public string pais { get; set; }
    public string telefono { get; set; }
    public string codigo { get; set; }
}