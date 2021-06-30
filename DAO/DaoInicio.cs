using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presupuesto.DAO
{
    class DaoInicio
    {
        public void SaldoDisponible(ref double valor, string consulta)
        {
            try
            {
                Conexion.abrir();
                SqlCommand comando = new SqlCommand("saldoDisponible", Conexion.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@consulta", consulta);
                valor = Convert.ToDouble(comando.ExecuteScalar());
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
