using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleados_BLL
/// </summary>
public class Empleados_BLL
{
    public Empleados_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<Empleados_DTO> MostrarTodosEmpleados()
    {
        List<Empleados_DTO> listaEmpleados = new List<Empleados_DTO>();
        Empleados_DSTableAdapters.EmpleadosTableAdapter adaptador = new Empleados_DSTableAdapters.EmpleadosTableAdapter();
        Empleados_DS.EmpleadosDataTable tabla = adaptador.MostrarEmpleados();
        foreach (Empleados_DS.EmpleadosRow filas in tabla)
        {
            listaEmpleados.Add(filaDTOEmpleados(filas));
        }
        return listaEmpleados;
    }

    private static Empleados_DTO filaDTOEmpleados(Empleados_DS.EmpleadosRow filas)
    {
        Empleados_DTO objEmp = new Empleados_DTO();
        objEmp.id_empleado = filas.id_empleado;
        objEmp.nombre_empleado = filas.nombre_empleado;
        objEmp.apellido_empleado = filas.apellido_empleado;
        objEmp.direccion = filas.direccion;
        objEmp.ciudad = filas.ciudad;
        objEmp.region = filas.region;
        objEmp.pais = filas.pais;
        objEmp.telefono = filas.telefono;
        objEmp.codigo = filas.codigo;
        return objEmp;
    }

    public static Empleados_DTO BuscarEmpleadoID(int cod_emp)
    {
        Empleados_DSTableAdapters.EmpleadosTableAdapter adaptador = new Empleados_DSTableAdapters.EmpleadosTableAdapter();
        Empleados_DS.EmpleadosDataTable tabla = adaptador.BuscarEmpleadoID(cod_emp);

        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaDTOEmpleados(tabla[0]);
    }

    public void InsertarEmpleado(string nomEmp, string apEmp, string dir, string ciu, string reg, string pais, string telef)
    {
        Empleados_DSTableAdapters.EmpleadosTableAdapter adaptador = new Empleados_DSTableAdapters.EmpleadosTableAdapter();
        adaptador.Insert(nomEmp, apEmp, dir, ciu, reg, pais, telef);
    }

    public void ActualizarEmpleado(int idEmp, string nomEmp, string apEmp, string dir, string ciu, string reg, string pais, string telef)
    {
        Empleados_DSTableAdapters.EmpleadosTableAdapter adaptador = new Empleados_DSTableAdapters.EmpleadosTableAdapter();
        adaptador.Update(idEmp, nomEmp, apEmp, dir, ciu, reg, pais, telef);
    }

    public void EliminarEmpleado(int idEmp)
    {
        Empleados_DSTableAdapters.EmpleadosTableAdapter adaptador = new Empleados_DSTableAdapters.EmpleadosTableAdapter();
        adaptador.Delete(idEmp);
    }
}