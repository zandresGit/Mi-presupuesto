using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace Presupuesto.DAO
{
    class Conexion
    {
        public static string conexion = @"Data source=DESKTOP-SG3PCER\SQLEXPRESS; Initial Catalog=Presupuesto; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if(conectar.State==ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
