using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presupuesto.DAO;
using Presupuesto.LOGICA;

namespace Presupuesto.VISTA
{
    public partial class NuevoPago : Form
    {
        public NuevoPago()
        {
            InitializeComponent();
        }
        private void NuevoPago_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CalcularReserva_Cochon();
        }

        public void CargarDatos()
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            DataTable tabla3 = new DataTable();
            DaoAgregar consulta = new DaoAgregar();

            consulta.CargarIngreso(ref tabla);
            txtIngresos.Text = String.Format("{0:C}", tabla.Rows[0][0]);
            txtOtrosIngresos.Text = String.Format("{0:C}", tabla.Rows[0][1]);

            consulta.CargarGasto(ref tabla2);
            txtSoat.Text = String.Format("{0:C}", tabla2.Rows[3][1]);
            txtTecno.Text = String.Format("{0:C}", tabla2.Rows[2][1]);
            txtAceite.Text = String.Format("{0:C}", tabla2.Rows[0][1]);
            txtGasolina.Text = String.Format("{0:C}", tabla2.Rows[1][1]);

            consulta.CargarAhorro(ref tabla3);
            txtIncentivo.Text = String.Format("{0:C}", tabla3.Rows[0][2]);
        }

        public void CalcularReserva_Cochon()
        {
            double ingresos = double.Parse(txtIngresos.Text, System.Globalization.NumberStyles.Currency) + double.Parse(txtOtrosIngresos.Text, System.Globalization.NumberStyles.Currency);
            double gastos = double.Parse(txtSoat.Text, System.Globalization.NumberStyles.Currency) + double.Parse(txtTecno.Text, System.Globalization.NumberStyles.Currency) + double.Parse(txtAceite.Text, System.Globalization.NumberStyles.Currency) + double.Parse(txtGasolina.Text, System.Globalization.NumberStyles.Currency);
            double reserva = (ingresos - gastos)*0.11;
            txtReserva.Text = String.Format("{0:C}", reserva);

            double cochon = ingresos - gastos - reserva - double.Parse(txtIncentivo.Text, System.Globalization.NumberStyles.Currency);
            txtColchon.Text = String.Format("{0:C}", cochon);
        }

        private void txtIngresos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularReserva_Cochon();
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<double> parametros = new List<double>();
            DaoAgregar consulta = new DaoAgregar();
            parametros.Add(double.Parse(txtIngresos.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtOtrosIngresos.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtSoat.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtTecno.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtAceite.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtGasolina.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtReserva.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtColchon.Text, System.Globalization.NumberStyles.Currency));
            parametros.Add(double.Parse(txtIncentivo.Text, System.Globalization.NumberStyles.Currency));

            DialogResult mensaje = MessageBox.Show("Se agregar un nuevo ingreso. ¿Desea continuar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (mensaje == DialogResult.OK)
            {
                if (consulta.agregar(parametros) == true)
                {
                    Principal vista = new Principal();
                    vista.vistaPincipal();
                    Close();
                }
                else
                {
                    MessageBox.Show("Datos no validos, por favor digite al menos un ingreso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void FormatoMoney(TextBox txt)
        {
            try
            {
                double valor = double.Parse(txt.Text, System.Globalization.NumberStyles.Currency);
                txt.Text = String.Format("{0:C}", valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtIngresos_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtIngresos);
        }
        private void txtOtrosIngresos_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtOtrosIngresos);
        }

        private void txtSoat_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtSoat);
        }

        private void txtTecno_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtTecno);
        }

        private void txtAceite_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtAceite);
        }

        private void txtGasolina_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtGasolina);
        }

        private void txtIncentivo_Validated(object sender, EventArgs e)
        {
            FormatoMoney(txtIncentivo);
        }
    }
}
