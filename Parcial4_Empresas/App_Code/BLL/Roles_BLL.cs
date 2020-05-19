using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Roles_BLL
/// </summary>
public class Roles_BLL
{
    public Roles_BLL()
    {
       
    }

    public static List<Roles_DTO> MostrarTodosRoles()
    {
        List<Roles_DTO> ListarRoles = new List<Roles_DTO>();
        Roles_DSTableAdapters.RolesTableAdapter adaptador = new Roles_DSTableAdapters.RolesTableAdapter();
        Roles_DS.RolesDataTable tabla = adaptador.MostrarRoles();
        foreach(Roles_DS.RolesRow filas in tabla)
        {
            ListarRoles.Add(filaDTOroles(filas));
        }
        return ListarRoles;

    }

    private static Roles_DTO filaDTOroles(Roles_DS.RolesRow filas)
    {
        Roles_DTO objRoles = new Roles_DTO();
        objRoles.id_rol = filas.id_rol;
        objRoles.rol = filas.rol;
        objRoles.descripcion = filas.descripcion;

        return objRoles;
    }

    public static Roles_DTO MostrarIDRoles(int id_rol)
    {
        Roles_DSTableAdapters.RolesTableAdapter adaptador = new Roles_DSTableAdapters.RolesTableAdapter();
        Roles_DS.RolesDataTable tabla = adaptador.MostrarRolesID(id_rol);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOroles(tabla[0]);
    }

    //Metodos que me sirven para mi pagina de mantenimientos
    public void InsertarRoles(string rol, string descripcion)
    {
        Roles_DSTableAdapters.RolesTableAdapter adaptador = new Roles_DSTableAdapters.RolesTableAdapter();
        adaptador.Insert(rol, descripcion);
    }

    public void ActualizarRoles(string rol, string descripcion,int id_rol)
    {   
        Roles_DSTableAdapters.RolesTableAdapter adaptador = new Roles_DSTableAdapters.RolesTableAdapter();
        adaptador.Update(rol, descripcion, id_rol, id_rol);
    }

    public void EliminarRoles(int idRol)
    {
        Roles_DSTableAdapters.RolesTableAdapter adaptador = new Roles_DSTableAdapters.RolesTableAdapter();
        adaptador.Delete(idRol);
    }


}