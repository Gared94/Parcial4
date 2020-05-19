using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Categorias_BLL
/// </summary>
public class Categorias_BLL
{
    public Categorias_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<CategoriasDTO> MostrarTodosCategorias()
    {
        List<CategoriasDTO> listaCategorias = new List<CategoriasDTO>();
        Categorias_DSTableAdapters.CategoriasTableAdapter adaptador = new Categorias_DSTableAdapters.CategoriasTableAdapter();
        Categorias_DS.CategoriasDataTable tabla = adaptador.MostrarCategorias();
        foreach (Categorias_DS.CategoriasRow filas in tabla)
        {
            listaCategorias.Add(filaDTOCategoria(filas));
        }
        return listaCategorias;
    }

    private static CategoriasDTO filaDTOCategoria(Categorias_DS.CategoriasRow filas)
    {
        CategoriasDTO objCate = new CategoriasDTO();
        objCate.id_categoria = filas.id_categoria;
        objCate.nombre_categoria = filas.nombre_categoria;
        objCate.descripcion = filas.descripcion;
        objCate.codigo = filas.codigo;

        return objCate;
    }

    public static CategoriasDTO MostrarCategoriaID(int cod_cate)
    {
        Categorias_DSTableAdapters.CategoriasTableAdapter adaptador = new Categorias_DSTableAdapters.CategoriasTableAdapter();
        Categorias_DS.CategoriasDataTable tabla = adaptador.MostrarCategoriaID(cod_cate);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOCategoria(tabla[0]);
    }

    public void InsertarCategoria(string nomCat, string descrip)
    {
        Categorias_DSTableAdapters.CategoriasTableAdapter adaptador = new Categorias_DSTableAdapters.CategoriasTableAdapter();
        adaptador.Insert(nomCat, descrip);
    }

    public void ActualizarCategoria(int idCat, string nomCat, string desCat)
    {
        Categorias_DSTableAdapters.CategoriasTableAdapter adaptador = new Categorias_DSTableAdapters.CategoriasTableAdapter();
        adaptador.Update(idCat, nomCat, desCat);
    }

    public void EliminarCategoria(int idCat)
    {
        Categorias_DSTableAdapters.CategoriasTableAdapter adaptador = new Categorias_DSTableAdapters.CategoriasTableAdapter();
        adaptador.Delete(idCat);
    }
}