using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuarios_BLL
/// </summary>
public class Usuarios_BLL
{
    public Usuarios_BLL()
    {

    }

    public static List<Usuario_DTO> MostrarTodosUsuarios()
    {
        List<Usuario_DTO> ListarUsuarios = new List<Usuario_DTO>();
        Usuarios_DSTableAdapters.UsuariosTableAdapter adaptador = new Usuarios_DSTableAdapters.UsuariosTableAdapter();
        Usuarios_DS.UsuariosDataTable tabla = adaptador.MostrarUsuarios();

        foreach (Usuarios_DS.UsuariosRow fila in tabla)
        {
            ListarUsuarios.Add(filaDTOUsuario(fila));
        }
        return ListarUsuarios;


    }

    private static Usuario_DTO filaDTOUsuario(Usuarios_DS.UsuariosRow fila)
    {
        Usuario_DTO objDTOUser = new Usuario_DTO();
        objDTOUser.id_usuario = fila.id_usuario;
        objDTOUser.usuario = fila.usuario;
        objDTOUser.pass_user = fila.pass_user;
        objDTOUser.id_rol = fila.id_rol;
        objDTOUser.estado = fila.estado;

        return objDTOUser;
    }

    public static Usuario_DTO MostrarIDUsuarios(int id_user)
    {
        Usuarios_DSTableAdapters.UsuariosTableAdapter adaptador = new Usuarios_DSTableAdapters.UsuariosTableAdapter();
        Usuarios_DS.UsuariosDataTable tabla = adaptador.MostrarUsuariosID(id_user);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOUsuario(tabla[0]);
    }

    //Metodos que me sirven para mi pagina de mantenimientos
    public void InsertarUsuarios(string user, string pass, int idRol, string estado)
    {
        Usuarios_DSTableAdapters.UsuariosTableAdapter adaptador = new Usuarios_DSTableAdapters.UsuariosTableAdapter();
        adaptador.Insert(user, pass, idRol, estado);
    }

    public void ActualizarUsuarios(string User, string Pass, int idRol, string estado, int idUser)
    {
        Usuarios_DSTableAdapters.UsuariosTableAdapter adaptador = new Usuarios_DSTableAdapters.UsuariosTableAdapter();
        adaptador.Update(User, Pass, idRol, estado, idUser, idUser);
    }

    public void EliminarUsuarios(int idUser)
    {
        Usuarios_DSTableAdapters.UsuariosTableAdapter adaptador = new Usuarios_DSTableAdapters.UsuariosTableAdapter();
        adaptador.Delete(idUser);
    }



}

