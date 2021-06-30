using Presupuesto.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presupuesto.VISTA
{
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        public Retiro(string valor, string tabla)
        {
            InitializeComponent();
            this.valor = valor;
            opcion = tabla;
        }

        string valor = "";
        string opcion = "";

        private void Retiro_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = valor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DaoAgregar consulta = new DaoAgregar();
            double resta = double.Parse(valor, System.Globalization.NumberStyles.Currency) - Convert.ToDouble(txtRetiro.Text);
            if (resta >= 0)
            {
                DialogResult mensaje = MessageBox.Show("Se retirara. ¿Desea continuar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (mensaje == DialogResult.OK)
                {
                    if (consulta.retiro(opcion, txtRetiro.Text, txtConcepto.Text) == true)
                    {
                        MessageBox.Show("Retiro Exitoso.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Principal vista = new Principal();
                        vista.vistaPincipal();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Datos no validos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad a retirar excede sus fondos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
