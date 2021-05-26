using Presupuesto.DAO;
using Presupuesto.LOGICA;
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
    public partial class Ahorro : UserControl
    {
        public Ahorro()
        {
            InitializeComponent();
        }

        private void Ahorro_Load(object sender, EventArgs e)
        {
            MostrarAhorros();
            TotalAhorros();
        }
        public void MostrarAhorros()
        {
            DataTable tabla = new DataTable();
            DaoAhorros consulta = new DaoAhorros();
            consulta.mostrarTable(ref tabla, "AhorroS");
            dgvAhorros.DataSource = tabla;
            Diseño.DiseñoDGV(ref dgvAhorros);
        }
        public void TotalAhorros()
        {
            DataTable tabla = new DataTable();
            DaoAhorros consulta = new DaoAhorros();
            consulta.TotalAhorros(ref tabla);
            lblReserva.Text = String.Format("{0:C}", tabla.Rows[2][1]);
            lblColchon.Text = String.Format("{0:C}", tabla.Rows[0][1]);
        }
    }
}
