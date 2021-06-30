using Presupuesto.LOGICA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presupuesto.DAO
{
    class DaoIngresos
    {
        public void mostrarTable(ref DataTable tabla ,string vista)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter comando = new SqlDataAdapter("mostrarTable", Conexion.conectar);
                comando.SelectCommand.CommandType = CommandType.StoredProcedure;
                comando.SelectCommand.Parameters.AddWithValue("@tabla", vista);
                comando.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void TotalIngresos(ref DataTable tabla)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter comando = new SqlDataAdapter("totalIngresos", Conexion.conectar);
                comando.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
