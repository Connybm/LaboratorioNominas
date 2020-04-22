using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //---------------Insertar Conceptos
        public OdbcDataReader InsertarConceptos(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + sCodigo + ", '" + sNombre + "' ,'" + sEfecto + "','" + sEstado + "')';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Conceptos
        public OdbcDataReader modificarConceptos(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set nombre_concepto='" + sNombre + "', efecto_concepto='" + sEfecto + "'" 
                    + ", estatus_concepto = " + sEstado + " where codigo_concepto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Conceptos
        public OdbcDataReader eliminarConceptos(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estatus_concepto='0' where codigo_concepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Conceptos
        public OdbcDataReader consultaConcepto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM concepto WHERE estatus_concepto = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Insertar Puesto
        public OdbcDataReader InsertarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into puesto values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Puesto
        public OdbcDataReader modificarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set nombre_puesto='" + sNombre + "', estatus_puesto='" + sEstado + "' where codigo_puesto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Puesto
        public OdbcDataReader eliminarPuesto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set estatus_puesto='0' where codigo_puesto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Puesto
        public OdbcDataReader consultaPuesto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM puesto WHERE estatus_puesto = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Insertar Empleados
        public OdbcDataReader InsertarEmpleados(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into empleado values(" + sCodigo + ", '" + sNombre + "' ,'" + sCP + "','" + sCD + "'," + sSueldo + ",'"+sEstatus+"');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Empleados
        public OdbcDataReader modificarEmpleados(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set nombre_empleado='" + sNombre + "', codigo_puesto='" + sCP + "'" + ", codigo_departamento = '" + sCD
                    + "', sueldo_empleado= " + sSueldo +"', estatus_empleado'" + sEstatus  + " where codigo_empleado = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Empleados
        public OdbcDataReader eliminarEmpleados(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set estatus_empleado='0' where codigo_empleado='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Empleados
        public OdbcDataReader consultaEmpleados()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM empleado WHERE estatus_empleado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------------OBTENER COD SIGUIENTE--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();

                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        //---------------------------------------------------------------UPDATE DEPARTAMENTO-----------------------------------------------------------------------------------------//
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set nombre_departamento='" + sNombre + "estado_departamento" + sEstado + "' where codigo_departamento = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT DEPARTAMENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader insertarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into departamento values(" + sCodigo + ", '" + sNombre + "' ," + sEstado + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR DEPARTAMENTO-----------------------------------------------------------------------------------------//
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set estatus_departamento='0' where codigo_departamento ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------CONSULTA DEPARTAMENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaDepartamento()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM departamento WHERE codigo_departamento = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    

        /*categoria*/

        //---------------------------------------------------------------UPDATE TIPO DE CATEGORIA----------------------------------------------------------------------------------------//
        public OdbcDataReader modificarCategoria(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE categoria set nombre='" + sNombre + "' where pkidcategoria = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT TIPO DE CATEGORIA------------------------------------------------------------------------------------------//
        public OdbcDataReader insertarCategoria(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into categoria values(" + sCodigo + ", '" + sNombre + "' ," + "1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR TIPO DE CATEGORIA-----------------------------------------------------------------------------------------//
        public OdbcDataReader eliminarCategoria(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE categoria set estado='0' where pkidcategoria ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        
        //---------------------------------------------------------------CONSULTA CATEGORIA------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaCategoria()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM categoria WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        /*AUTOR*/
        //---------------------------------------------------------------UPDATE TIPO DE AUTOR----------------------------------------------------------------------------------------//
        public OdbcDataReader modificarAutor(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE autor set nombre='" + sNombre + "' where pkidautor = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT TIPO DE AUTOR-----------------------------------------------------------------------------------------//
        public OdbcDataReader insertarAutor(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into autor values(" + sCodigo + ", '" + sNombre + "' ," + "1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR TIPO DE AUTOR-----------------------------------------------------------------------------------------//
        public OdbcDataReader eliminarAutor(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE autor set estado='0' where pkidautor ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        
        //---------------------------------------------------------------CONSULTA AUTOR------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaAutor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM autor WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------Formulario de proveedores----------------------------------------------------------
        public OdbcDataReader consultarproveedor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM proveedor;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into proveedor values(" + sCodigo + ", '" + sNombre + "' ,'" + sdireccion + "','" + stelefono + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader modficarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set nombre='" + sNombre + "',direccion='" + sdireccion + "',telefono='" + stelefono + "',estado='" + sestado + "' where pkidproveedor='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarproveedor(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set estado='0' where pkidproveedor='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------Formulario de sucursal----------------------------------------------------------
        public OdbcDataReader consultasucursal()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM sucursal;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into sucursal values(" + sCodigo + ", '" + sNombre + "' ,'" + sdireccion + "','" + stelefono + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sucursal set nombre='" + sNombre + "',direccion='" + sdireccion + "',telefono='" + stelefono + "',estado='" + sestado + "' where pkidsucursal='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarsucursal(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sucursal set estado='0' where pkidsucursal='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------Formulario de producto----------------------------------------------------------
        public OdbcDataReader consultaproducto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM productos;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertarproducto(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into productos values(" + sCodigo + ", '" + sNombre + "' ,'" + dprecio + "' ,'" + idcategoria + "' ,'" + sestado + "','" + idtipoprod + "','" + idautor + "','" + idproveedor + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarproducto(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set nombre='" + sNombre + "',precio='" + dprecio + "',fkidcategoria='" + idcategoria + "',estado='" + sestado + "',fkidtipoproducto='" + idtipoprod + "',fkidautor='" + idautor + "',fkidproveedor='" + idproveedor + "' where pkidproducto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarproducto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set estado='0' where pkidproducto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------Insertar Encabezado renta
        public OdbcDataReader InsertarRentaEncabezado(string sCodigo, string sMembresia, string sFechaA, string sFechaE, string sSucursal)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into renta_encabezado values(" + sCodigo + ", " + sMembresia + " ,'" + sFechaA + "','" + sFechaE + "'" + sSucursal + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
