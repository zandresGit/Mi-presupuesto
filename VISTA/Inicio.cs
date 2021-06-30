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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            double gasolina = 0;
            double aceite = 0;
            double dinero = 0;
            DaoInicio consulta = new DaoInicio();
            consulta.SaldoDisponible(ref gasolina, "Gasolina");
            lblGasolina.Text = String.Format("{0:C}", gasolina);
            consulta.SaldoDisponible(ref aceite, "Aceite");
            lblAceite.Text = String.Format("{0:C}", aceite);
            consulta.SaldoDisponible(ref dinero, "Incentivo");
            lblDinero.Text = String.Format("{0:C}", dinero);
            consulta.SaldoDisponible(ref dinero, "Reserva 11% ");
            lblEmergencia.Text = String.Format("{0:C}", dinero);
            consulta.SaldoDisponible(ref dinero, "Colchon (2.000.000)");
            lblAhorro.Text = String.Format("{0:C}", dinero);
        }

        private void imgGas2_MouseEnter(object sender, EventArgs e)
        {
            imgGas.Visible = true;
            imgGas2.Visible = false;
        }

        private void imgGas_MouseLeave(object sender, EventArgs e)
        {
            imgGas.Visible = false;
            imgGas2.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            imgAceite.Visible = true;
            imgAceite2.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            imgAceite.Visible = false;
            imgAceite2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            imgIncentivo.Visible = false;
            imgIncentivo2.Visible = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            imgIncentivo.Visible = true;
            imgIncentivo2.Visible = false;
        }

        private void imgAhorro2_MouseEnter(object sender, EventArgs e)
        {
            imgAhorro.Visible = true;
            imgAhorro2.Visible = false;
        }

        private void imgAhorro_MouseLeave(object sender, EventArgs e)
        {
            imgAhorro.Visible = false;
            imgAhorro2.Visible = true;
        }

        private void imgEmergencia2_MouseEnter(object sender, EventArgs e)
        {
            imgEmergencia.Visible = true;
            imgEmergencia2.Visible = false;
        }

        private void imgEmergencia_MouseLeave(object sender, EventArgs e)
        {
            imgEmergencia.Visible = false;
            imgEmergencia2.Visible = true;
        }

        private void imgGas_Click(object sender, EventArgs e)
        {
            Retiro vista = new Retiro(lblGasolina.Text,"Gasolina");
            vista.ShowDialog();
        }

        private void imgAceite_Click(object sender, EventArgs e)
        {
            Retiro vista = new Retiro(lblAceite.Text, "Aceite");
            vista.ShowDialog();
        }

        private void imgEmergencia_Click(object sender, EventArgs e)
        {
            Retiro vista = new Retiro(lblEmergencia.Text, "Reserva 11%");
            vista.ShowDialog();
        }

        private void imgIncentivo_Click(object sender, EventArgs e)
        {
            Retiro vista = new Retiro(lblDinero.Text, "Incentivo");
            vista.ShowDialog();
        }

        private void imgAhorro_Click(object sender, EventArgs e)
        {
            Retiro vista = new Retiro(lblAhorro.Text, "Colchon (2.000.000)");
            vista.ShowDialog();
        }
    }
}
