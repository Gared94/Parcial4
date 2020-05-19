using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PedidosDetalle_BLL
/// </summary>
public class PedidosDetalle_BLL
{
    public PedidosDetalle_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<PedidosDetalle_DTO> MostrarTodosPedidos()
    {
        List<PedidosDetalle_DTO> ListarPedidosDetalle = new List<PedidosDetalle_DTO>();
        PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter adaptador = new PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter();
        PedidosDetalle_DS.PedidoDetallesDataTable tabla = adaptador.MostrarPedidoDetalle();
        foreach (PedidosDetalle_DS.PedidoDetallesRow filas in tabla)
        {

            ListarPedidosDetalle.Add(filaDTOPedidosDetalle(filas));
        }
        return ListarPedidosDetalle;

    }

    private static PedidosDetalle_DTO filaDTOPedidosDetalle(PedidosDetalle_DS.PedidoDetallesRow filas)
    {
        PedidosDetalle_DTO objPedidoD = new PedidosDetalle_DTO();
        objPedidoD.id_pedido = filas.id_pedido;
        objPedidoD.id_producto = filas.id_producto;
        objPedidoD.precio_unitario = filas.precio_unitario;
        objPedidoD.cantidad = filas.cantidad;
        objPedidoD.descuento = filas.descuento;

        return objPedidoD;

    }
    public static PedidosDetalle_DTO MostrarIDPedidoDetalle(int id_pedido)
    {
        PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter adaptador = new PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter();
        PedidosDetalle_DS.PedidoDetallesDataTable tabla = adaptador.BuscarPedidoDetalleID(id_pedido);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOPedidosDetalle(tabla[0]);
    }

    public void InsertarPedidoDetalle(int idpedido, int idproducto, decimal precio, int cantidad, decimal descuento)
    {
        PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter adaptador = new PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter();
        adaptador.Insert(idpedido, idproducto, precio, cantidad, descuento);

    }

    public void ActualizarPedidoDetalle(int idpedido, int idproducto, decimal precio, int cantidad, decimal descuento)
    {
        PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter adaptador = new PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter();
        adaptador.Update(precio, cantidad, descuento, idpedido, idproducto);

    }

    public void EliminarPedidoDetalle(int idpedido, int idproducto)
    {
        PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter adaptador = new PedidosDetalle_DSTableAdapters.PedidoDetallesTableAdapter();
        adaptador.Delete(idpedido, idproducto);
    }
}