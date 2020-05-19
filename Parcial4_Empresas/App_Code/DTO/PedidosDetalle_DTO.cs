using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PedidosDetalle_DTO
/// </summary>
public class PedidosDetalle_DTO
{
    public PedidosDetalle_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int id_pedido { get; set; }
    public int id_producto { get; set; }
    public decimal precio_unitario { get; set; }
    public int cantidad { get; set; }
    public decimal descuento { get; set; }
}