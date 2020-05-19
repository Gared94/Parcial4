using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de FechasLookup_DTO
/// </summary>
public class FechasLookup_DTO
{
    public FechasLookup_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Fecha { get; set; }
    public string Año { get; set; }
    public string NombreMes { get; set; }
    public int NumeroMes { get; set; }
}