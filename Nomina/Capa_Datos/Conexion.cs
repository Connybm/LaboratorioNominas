﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Conexion
    {
        public OdbcConnection conexionbd()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=Nomina"); // creacion de la conexion via ODBC

            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo realizar la conexión", ex);
            }
            return conn;
        }
    }
}
