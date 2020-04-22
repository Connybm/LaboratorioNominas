using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
   public class Logica
    {
        Sentencias sn = new Sentencias();
        /*OBTENER COD SIGUIENTE*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        //----Insertar Concepto
        public OdbcDataReader InsertarConcepto(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            return sn.InsertarConceptos(sCodigo, sNombre, sEfecto, sEstado);
        }

        //----Modificar Concepto
        public OdbcDataReader modificarConcepto(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            return sn.modificarConceptos(sCodigo, sNombre, sEfecto, sEstado);
        }

        //----Eliminar Concepto
        public OdbcDataReader eliminarConcepto(string sCodigo)
        {
            return sn.eliminarConceptos(sCodigo);
        }

        //-----Consultar Concepto
        public OdbcDataReader consultarConcepto()
        {
            return sn.consultaConcepto();
        }

        //----Insertar Puesto
        public OdbcDataReader InsertarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            return sn.InsertarPuesto(sCodigo, sNombre, sEstado);
        }

        //----Modificar Puesto
        public OdbcDataReader modificarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            return sn.modificarPuesto(sCodigo, sNombre, sEstado);
        }

        //----Eliminar Puesto
        public OdbcDataReader eliminarPuesto(string sCodigo)
        {
            return sn.eliminarPuesto(sCodigo);
        }

        //-----Consultar Puesto
        public OdbcDataReader consultarPuesto()
        {
            return sn.consultaPuesto();
        }

        //----Insertar Empleado
        public OdbcDataReader InsertarEmpleado(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            return sn.InsertarEmpleados(sCodigo, sNombre, sCP, sCD, sSueldo,sEstatus);
        }

        //----Modificar Empleado
        public OdbcDataReader modificarEmpleado(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            return sn.modificarEmpleados(sCodigo, sNombre, sCP, sCD, sSueldo, sEstatus);
        }

        //----Eliminar Empleado
        public OdbcDataReader eliminarEmpleado(string sCodigo)
        {
            return sn.eliminarEmpleados(sCodigo);
        }

        //-----Consultar Empleado
        public OdbcDataReader consultarEmpleado()
        {
            return sn.consultaEmpleados();
        }

        //------------------------------------------------------------------------------------------------------UPDATE DEPARTAMENTO------------------------------------------------------//
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            return sn.modificarDepartamento(sCodigo, sNombre, sEstado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR DEPARTAMENTO------------------------------------------------------//
        public OdbcDataReader insertarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            return sn.insertarDepartamento(sCodigo, sNombre, sEstado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR DEPARTAMENTO-----------------------------------------------------//
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            return sn.eliminarDepartamento(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------CONSULTA DEPARTAMENTO-------------------------------------------------------//
        public OdbcDataReader consultaDepartamento()
        {
            return sn.consultaDepartamento();
        }

        /*categoria*/
        //------------------------------------------------------------------------------------------------------UPDATE TIPO DE CATEGORIA------------------------------------------------------//
        public OdbcDataReader modificarCategoria(string sCodigo, string sNombre)
        {
            return sn.modificarCategoria(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR TIPO DE CATEGORIA------------------------------------------------------//
        public OdbcDataReader insertarCategoria(string sCodigo, string sNombre)
        {
            return sn.insertarCategoria(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR TIPO DE CATEGORIA----------------------------------------------------//
        public OdbcDataReader eliminarCategoria(string sCodigo)
        {
            return sn.eliminarCategoria(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------CONSULTA CATEGORIA------------------------------------------------------//

        public OdbcDataReader consultaCategoria()
        {
            return sn.consultaCategoria();
        }

        /*AUTOR*/
        //------------------------------------------------------------------------------------------------------UPDATE TIPO DE AUTOR-----------------------------------------------------//
        public OdbcDataReader modificarAutor(string sCodigo, string sNombre)
        {
            return sn.modificarAutor(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR TIPO DE AUTOR------------------------------------------------------//
        public OdbcDataReader insertarAutor(string sCodigo, string sNombre)
        {
            return sn.insertarAutor(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR TIPO DE AUTOR----------------------------------------------------//
        public OdbcDataReader eliminarAutor(string sCodigo)
        {
            return sn.eliminarAutor(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------CONSULTA AUTOR------------------------------------------------------//
        public OdbcDataReader consultaAutor()
        {
            return sn.consultaAutor();
        }

        public OdbcDataReader consultarproveedor()
        {
            return sn.consultarproveedor();
        }

        public OdbcDataReader insertarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            return sn.insertarproveedor(sCodigo, sNombre, sdireccion, stelefono, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            return sn.modficarproveedor(sCodigo, sNombre, sdireccion, stelefono, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarproveedor(string sCodigo)
        {
            return sn.eliminarproveedor(sCodigo);
        }
        //------------------------------------------------------------------------------------------------------sucursal-------------------------------------------------------//
        public OdbcDataReader consultasucursal()
        {
            return sn.consultasucursal();
        }
        public OdbcDataReader insertarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            return sn.insertarsucursal(sCodigo, sNombre, sdireccion, stelefono, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            return sn.modificarsucursal(sCodigo, sNombre, sdireccion, stelefono, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR-------------------------------------------------------//
        public OdbcDataReader eliminarsucursal(string sCodigo)
        {
            return sn.eliminarsucursal(sCodigo);
        }
        //------------------------------------------------------------------------------------------------------producto-------------------------------------------------------//
        public OdbcDataReader consultaproducto()
        {
            return sn.consultaproducto();
        }
        public OdbcDataReader insertarproducto(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            return sn.insertarproducto(sCodigo, sNombre, dprecio, idcategoria, sestado, idtipoprod, idautor, idproveedor);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarproductos(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            return sn.modificarproducto(sCodigo, sNombre, dprecio, idcategoria, sestado, idtipoprod, idautor, idproveedor);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarproducto(string sCodigo)
        {
            return sn.eliminarproducto(sCodigo);
        }

        //----------INSERTAR ENCABEZADO
        public OdbcDataReader insertarEncabezadoNomina(string sCodigo, string sFechaI, string sFechaF)
        {
            return sn.InsertarNominaEncabezado(sCodigo, sFechaI, sFechaF);
        }

        //----------INSERTAR DETALLE
        public OdbcDataReader insertarDetalleNomina(string sCodigo, string sEmpleado, string sConcepto, string sValor)
        {
            return sn.InsertarNominaDetalle(sCodigo, sEmpleado, sConcepto, sValor);
        }
    }
}
