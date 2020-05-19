using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Clientes_BLL
/// </summary>
public class Clientes_BLL
{
    public Clientes_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<Clientes_DTO> MostrarTodosClientes()
    {
        List<Clientes_DTO> listaClientes = new List<Clientes_DTO>();
        Clientes_DSTableAdapters.ClientesTableAdapter adaptador = new Clientes_DSTableAdapters.ClientesTableAdapter();
        Clientes_DS.ClientesDataTable tabla = adaptador.MostrarClientes();
        foreach (Clientes_DS.ClientesRow filas in tabla)
        {
            listaClientes.Add(filaDTOClientes(filas));
        }
        return listaClientes;
    }

    private static Clientes_DTO filaDTOClientes(Clientes_DS.ClientesRow filas)
    {
        Clientes_DTO objCliente = new Clientes_DTO();
        objCliente.id_cliente = filas.id_cliente;
        objCliente.nombre_cliente = filas.nombre_cliente;
        objCliente.nombre_contacto = filas.nombre_contacto;
        objCliente.direccion = filas.direccion;
        objCliente.ciudad = filas.ciudad;
        objCliente.region = filas.region;
        objCliente.pais = filas.pais;
        objCliente.telefono = filas.telefono;
        objCliente.fax = filas.fax;
        objCliente.email = filas.email;
        objCliente.codigo = filas.codigo;
        return objCliente;
    }

    public static Clientes_DTO BuscarClienteID(int cod_clie)
    {
        Clientes_DSTableAdapters.ClientesTableAdapter adaptador = new Clientes_DSTableAdapters.ClientesTableAdapter();
        Clientes_DS.ClientesDataTable tabla = adaptador.BuscarClienteID(cod_clie);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOClientes(tabla[0]);
    }

    public void InsertarCliente(string nomClie, string nomCont, string dir, string ciu, string reg, string pais, string telef, string fax, string email)
    {
        Clientes_DSTableAdapters.ClientesTableAdapter adaptador = new Clientes_DSTableAdapters.ClientesTableAdapter();
        adaptador.Insert(nomClie, nomCont, dir, ciu, reg, pais, telef, fax, email);
    }

    public void ActualizarCliente(int idClie, string nomClie, string nomCont, string dir, string ciu, string reg, string pais, string telef, string fax, string email)
    {
        Clientes_DSTableAdapters.ClientesTableAdapter adaptador = new Clientes_DSTableAdapters.ClientesTableAdapter();
        adaptador.Update(idClie, nomClie, nomCont, dir, ciu, reg, pais, telef, fax, email);
    }

    public void EliminarCliente(int idClie)
    {
        Clientes_DSTableAdapters.ClientesTableAdapter adaptador = new Clientes_DSTableAdapters.ClientesTableAdapter();
        adaptador.Delete(idClie);
    }
}