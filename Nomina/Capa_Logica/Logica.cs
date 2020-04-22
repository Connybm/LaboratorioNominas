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
        public OdbcDataReader modificarConcepto(string sCodigo, string sNombre, string sDescripcion, string sValor, string sTipoOp)
        {
            return sn.modificarConceptos(sCodigo, sNombre, sDescripcion, sValor, sTipoOp);
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

        //----Insertar Membresia
        public OdbcDataReader InsertarMembresia(string sCodigo, string sNombre, string sFechaE, string sFechaV)
        {
            return sn.InsertarEmpleados(sCodigo, sNombre, sFechaE, sFechaV);
        }

        //----Modificar Membresia
        public OdbcDataReader modificarMembresia(string sCodigo, string sNombre, string sFechaE, string sFechaV)
        {
            return sn.modificarMembresia(sCodigo, sNombre,sFechaE, sFechaV);
        }

        //----Eliminar Concepto
        public OdbcDataReader eliminarMembresia(string sCodigo)
        {
            return sn.eliminarMembresia(sCodigo);
        }

        //-----Consultar Concepto
        public OdbcDataReader consultarMembresia()
        {
            return sn.consultaMembresia();
        }

        //----Insertar Cliente
        public OdbcDataReader InsertarCliente(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sCMembresia, string sFecha)
        {
            return sn.InsertarCliente(sCodigo, sNombre, sDireccion, sTelefono, sCMembresia,sFecha);
        }

        //----Modificar Cliente
        public OdbcDataReader modificarCliente(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sCMembresia)
        {
            return sn.modificarCliente(sCodigo, sNombre, sDireccion, sTelefono, sCMembresia);
        }

        //----Eliminar Concepto
        public OdbcDataReader eliminarCliente(string sCodigo)
        {
            return sn.eliminarCliente(sCodigo);
        }

        //-----Consultar Concepto
        public OdbcDataReader consultarCliente()
        {
            return sn.consultaCliente();
        }
      
        //------------------------------------------------------------------------------------------------------UPDATE TIPO DE PRODUCTO------------------------------------------------------//
        public OdbcDataReader modificarTipo(string sCodigo, string sNombre)
        {
            return sn.modificarTipo(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR TIPO DE PRODUCTO------------------------------------------------------//
        public OdbcDataReader insertarTipo(string sCodigo, string sNombre)
        {
            return sn.insertarTipo(sCodigo, sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR TIPO DE PRODUCTO-----------------------------------------------------//
        public OdbcDataReader eliminarTipo(string sCodigo)
        {
            return sn.eliminarTipo(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------CONSULTA TIPO-------------------------------------------------------//
        public OdbcDataReader consultaTipo()
        {
            return sn.consultaTipo();
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
        public OdbcDataReader insertarEncabezadoRenta(string sCodigo, string sMembresia, string sFechaA, string sFechaE, string sSucursal)
        {
            return sn.InsertarRentaEncabezado(sCodigo, sMembresia, sFechaA, sFechaE, sSucursal);
        }
    }
}
