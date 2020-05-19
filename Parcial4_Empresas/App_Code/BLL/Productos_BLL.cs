using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Productos_BLL
/// </summary>
public class Productos_BLL
{
    public Productos_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<ProductosDTO> MostrarTodosProductos()
    {
        List<ProductosDTO> ListarProductos = new List<ProductosDTO>();
        Producto_DSTableAdapters.ProductosTableAdapter adaptador = new Producto_DSTableAdapters.ProductosTableAdapter();
        Producto_DS.ProductosDataTable tabla = adaptador.MostrarProductos();
        foreach (Producto_DS.ProductosRow filas in tabla)
        {

            ListarProductos.Add(filaDTOProductos(filas));
        }
        return ListarProductos;

    }

    private static ProductosDTO filaDTOProductos(Producto_DS.ProductosRow filas)
    {
        ProductosDTO objProd = new ProductosDTO();
        objProd.id_producto = filas.id_producto;
        objProd.nombre_producto = filas.nombre_producto;
        objProd.id_categoria = filas.id_categoria;
        objProd.precio_unitario = filas.precio_unitario;
        objProd.detalles = filas.detalles;
        objProd.codigo = filas.codigo;

        return objProd;
    }

    public static ProductosDTO MostrarIDProductos(int id_producto)
    {
        Producto_DSTableAdapters.ProductosTableAdapter adaptador = new Producto_DSTableAdapters.ProductosTableAdapter();
        Producto_DS.ProductosDataTable tabla = adaptador.BuscarProductoID(id_producto);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOProductos(tabla[0]);
    }

    //Metodos que me sirven para mi pagina de mantenimientos
    public void InsertarProductos(string nombreproducto, int idcategoria, int preciounitario, string detalle)
    {
        Producto_DSTableAdapters.ProductosTableAdapter adaptador = new Producto_DSTableAdapters.ProductosTableAdapter();
        adaptador.Insert(nombreproducto, idcategoria, preciounitario, detalle);

    }

    public void ActualizarProductos(string nombreproducto, int idcategoria, int preciounitario, string detalle, int idProd)
    {
        Producto_DSTableAdapters.ProductosTableAdapter adaptador = new Producto_DSTableAdapters.ProductosTableAdapter();
        adaptador.Update(nombreproducto, idcategoria, preciounitario, detalle, idProd);

    }

    public void EliminarProductos(int idProd)
    {
        Producto_DSTableAdapters.ProductosTableAdapter adaptador = new Producto_DSTableAdapters.ProductosTableAdapter();
        adaptador.Delete(idProd);
    }
}