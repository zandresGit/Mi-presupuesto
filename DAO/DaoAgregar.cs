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
    class DaoAgregar
    {
        public void CargarIngreso(ref DataTable tabla)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter comando = new SqlDataAdapter("cargarUltIngreso", Conexion.conectar);
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

        public void CargarGasto(ref DataTable tabla)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter comando = new SqlDataAdapter("cargarUltGasto", Conexion.conectar);
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

        public void CargarAhorro(ref DataTable tabla)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter comando = new SqlDataAdapter("cargarUltReserva", Conexion.conectar);
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

        public bool agregar(List<double> paramertros)
        {
            try
            {
                Conexion.abrir();
                if (paramertros[0] == 0 && paramertros[1] != 0)
                {
                    SqlCommand comando = new SqlCommand("agregarOtroingreso", Conexion.conectar);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@otroingreso", paramertros[1]);
                    comando.ExecuteNonQuery();
                    return true;
                }
                else if (paramertros[0] != 0)
                {
                    SqlCommand comando = new SqlCommand("agregar", Conexion.conectar);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@ingreso", paramertros[0]);
                    comando.Parameters.AddWithValue("@otroingreso", paramertros[1]);
                    comando.Parameters.AddWithValue("@soat", paramertros[2]);
                    comando.Parameters.AddWithValue("@tecno", paramertros[3]);
                    comando.Parameters.AddWithValue("@aceite", paramertros[4]);
                    comando.Parameters.AddWithValue("@gasolina", paramertros[5]);
                    comando.Parameters.AddWithValue("@reserva", paramertros[6]);
                    comando.Parameters.AddWithValue("@ahorro", paramertros[7]);
                    comando.Parameters.AddWithValue("@incentivo", paramertros[8]);
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public bool retiro(string tabla, string valor, string concepto)
        {
            try
            {

                Conexion.abrir();
                SqlCommand comando = new SqlCommand("retirar", Conexion.conectar);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tabla", tabla);
                comando.Parameters.AddWithValue("@valor", double.Parse(valor, System.Globalization.NumberStyles.Currency));
                comando.Parameters.AddWithValue("@concepto", concepto);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }

}
