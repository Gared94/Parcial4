using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Transportistas_BLL
/// </summary>
public class Transportistas_BLL
{
    public Transportistas_BLL()
    {
        
    }

    public static List<TransportistasDTO> MostrarTodosUsuarios()
    {
        List<TransportistasDTO> ListarTransportistas = new List<TransportistasDTO>();
        Transportistas_DSTableAdapters.TransportistasTableAdapter adaptador = new Transportistas_DSTableAdapters.TransportistasTableAdapter();
        Transportistas_DS.TransportistasDataTable tabla = adaptador.MostrarTransportistas();

        foreach (Transportistas_DS.TransportistasRow fila in tabla)
        {
            ListarTransportistas.Add(filaDTOTransportista(fila));
        }
        return ListarTransportistas;


    }

    private static TransportistasDTO filaDTOTransportista(Transportistas_DS.TransportistasRow fila)
    {
        TransportistasDTO objDTOTransportista = new TransportistasDTO();
        objDTOTransportista.id_transportista = fila.id_transportista;
        objDTOTransportista.nombre_empresa = fila.nombre_empresa;
        objDTOTransportista.direccion = fila.direccion;
        objDTOTransportista.ciudad = fila.ciudad;
        objDTOTransportista.region = fila.pais;
        objDTOTransportista.pais = fila.ciudad;
        objDTOTransportista.telefono = fila.telefono;
        objDTOTransportista.codigo = fila.codigo;

        return objDTOTransportista;
    }


    public static TransportistasDTO MostrarIDTransportista(int idTransportista)
    {
        Transportistas_DSTableAdapters.TransportistasTableAdapter adaptador = new Transportistas_DSTableAdapters.TransportistasTableAdapter();
        Transportistas_DS.TransportistasDataTable tabla = adaptador.BuscarTransportistaID(idTransportista);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOTransportista(tabla[0]);
    }

    //Metodos que me sirven para mi pagina de mantenimientos
    public void InsertarTransportista(string nEmpresa, string Direccion, string Ciudad, string Region,string Pais, string Telefono)
    {
        Transportistas_DSTableAdapters.TransportistasTableAdapter adaptador = new Transportistas_DSTableAdapters.TransportistasTableAdapter();
        adaptador.Insert(nEmpresa, Direccion, Ciudad, Region, Pais, Telefono);
    }

    public void ActualizarTransportista(int IdTransport, string nEmpresa, string Direccion, string Ciudad, string Region, string Pais, string Telefono)
    {
        Transportistas_DSTableAdapters.TransportistasTableAdapter adaptador = new Transportistas_DSTableAdapters.TransportistasTableAdapter();
        adaptador.Update(IdTransport,nEmpresa, Direccion, Ciudad, Region, Pais, Telefono);
    }

    public void EliminarTransportista(int IdTransport)
    {
        Transportistas_DSTableAdapters.TransportistasTableAdapter adaptador = new Transportistas_DSTableAdapters.TransportistasTableAdapter();
        adaptador.Delete(IdTransport);
    }


}