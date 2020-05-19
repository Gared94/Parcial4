using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PedidosDTO
/// </summary>
public class PedidosDTO
{
    public PedidosDTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_pedido { get; set; }
    public int id_cliente { get; set; }
    public int id_transportista { get; set; }
    public int id_empleado { get; set; }
    public DateTime fecha_ordenado { get; set; }
    public DateTime fecha_requerido { get; set; }
    public DateTime fecha_entregado { get; set; }
    public decimal costo_envio { get; set; }
    public string codigo { get; set; }
    public int MyProperty { get; set; }

}