using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedidos_BLL
/// </summary>
public class Pedidos_BLL
{
    public Pedidos_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static List<PedidosDTO> MostrarTodosPedidos()
    {
        List<PedidosDTO> ListarPedidos = new List<PedidosDTO>();
        PedidosTableAdapters.PedidosTableAdapter adaptador = new PedidosTableAdapters.PedidosTableAdapter();
        Pedidos.PedidosDataTable tabla = adaptador.MostrarPedidos();
        foreach (Pedidos.PedidosRow filas in tabla)
        {

            ListarPedidos.Add(filaDTOPedidos(filas));
        }
        return ListarPedidos;

    }

    private static PedidosDTO filaDTOPedidos(Pedidos.PedidosRow filas)
    {
        PedidosDTO objPedido = new PedidosDTO();
        objPedido.id_pedido = filas.id_pedido;
        objPedido.id_cliente = filas.id_cliente;
        objPedido.id_transportista = filas.id_transportista;
        objPedido.id_empleado = filas.id_empleado;
        objPedido.fecha_ordenado = filas.fecha_ordenado;
        objPedido.fecha_requerido = filas.fecha_requerido;
        objPedido.fecha_entregado = filas.fecha_entregado;
        objPedido.costo_envio = filas.costo_envio;
        //objPedido.codigo = filas;
        return objPedido;
    }

    public static PedidosDTO MostrarIDPedido(int id_pedido)
    {
        PedidosTableAdapters.PedidosTableAdapter adaptador = new PedidosTableAdapters.PedidosTableAdapter();
        Pedidos.PedidosDataTable tabla = adaptador.BuscarPedidoID(id_pedido);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOPedidos(tabla[0]);
    }

    public void InsertarPedido(int idcliente, int idtransportista, int idempleado, DateTime fechaO, DateTime fechaR, DateTime fechaE, int costo)
    {
        PedidosTableAdapters.PedidosTableAdapter adaptador = new PedidosTableAdapters.PedidosTableAdapter();
        adaptador.Insert(idcliente, idtransportista, idempleado, DateTime.Now, DateTime.Now, DateTime.Now, costo);

    }

    public void ActualizarPedido(int idpedido, int idcliente, int idtransportista, int idempleado, DateTime fechaO, DateTime fechaR, DateTime fechaE, int costo)
    {
        PedidosTableAdapters.PedidosTableAdapter adaptador = new PedidosTableAdapters.PedidosTableAdapter();
        adaptador.Update(idcliente, idtransportista, idempleado, DateTime.Now, DateTime.Now, DateTime.Now, costo, idpedido);
        //( idcliente,  idtransportista,  idempleado, fechaO, fechaR);

    }

    public void EliminarPedido(int idpedido)
    {
        PedidosTableAdapters.PedidosTableAdapter adaptador = new PedidosTableAdapters.PedidosTableAdapter();
        adaptador.Delete(idpedido);
    }

}
