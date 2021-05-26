using Presupuesto.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presupuesto
{
    public partial class Principal : Form
    {
        int ctrlbotonHome = 0;

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            vistaPincipal();
        }

        public void vistaPincipal()
        {
            pnlContenido.Controls.Clear();
            Inicio vista = new Inicio();
            vista.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(vista);
            BarraIngresos.BackColor = Color.FromArgb(29, 29, 29);
            BarraGastos.BackColor = Color.FromArgb(29, 29, 29);
            BarraAhorros.BackColor = Color.FromArgb(29, 29, 29);
            BarraLibre.BackColor = Color.FromArgb(29, 29, 29);
            ctrlbotonHome = 1;
            btnVolver.Visible = false;
            btnVolver2.Visible = false;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Ingreso vista = new Ingreso();
            pnlContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            BarraIngresos.BackColor = Color.Green;
            BarraGastos.BackColor = Color.FromArgb(29, 29, 29);
            BarraAhorros.BackColor = Color.FromArgb(29, 29, 29);
            BarraLibre.BackColor = Color.FromArgb(29, 29, 29); 
            pnlContenido.Controls.Add(vista);
            btnVolver2.Visible = true;
            ctrlbotonHome = 0;
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            Gasto vista = new Gasto();
            pnlContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            BarraIngresos.BackColor = Color.FromArgb(29, 29, 29);
            BarraGastos.BackColor = Color.Red;
            BarraAhorros.BackColor = Color.FromArgb(29, 29, 29);
            BarraLibre.BackColor = Color.FromArgb(29, 29, 29);
            pnlContenido.Controls.Add(vista);
            ctrlbotonHome = 0;
            btnVolver2.Visible = true;
        }

        private void btnAhorros_Click(object sender, EventArgs e)
        {
            Ahorro vista = new Ahorro();
            pnlContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            BarraIngresos.BackColor = Color.FromArgb(29, 29, 29);
            BarraGastos.BackColor = Color.FromArgb(29, 29, 29);
            BarraAhorros.BackColor = Color.Yellow;
            BarraLibre.BackColor = Color.FromArgb(29, 29, 29);
            pnlContenido.Controls.Add(vista);
            ctrlbotonHome = 0;
            btnVolver2.Visible = true;
        }

        private void btnLibre_Click(object sender, EventArgs e)
        {
            Libre vista = new Libre();
            pnlContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            BarraIngresos.BackColor = Color.FromArgb(29, 29, 29);
            BarraGastos.BackColor = Color.FromArgb(29, 29, 29);
            BarraAhorros.BackColor = Color.FromArgb(29, 29, 29);
            BarraLibre.BackColor = Color.Cyan; 
            pnlContenido.Controls.Add(vista);
            ctrlbotonHome = 0;
            btnVolver2.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoPago vista = new NuevoPago();
            vista.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            vistaPincipal();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            if(ctrlbotonHome!=1)
            {
                btnVolver2.Visible = false;
                btnVolver.Visible = true;
            }
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            if (ctrlbotonHome != 1)
            {
                btnVolver.Visible = false;
                btnVolver2.Visible = true;
            }
        }
    }
}
