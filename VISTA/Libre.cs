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
    public partial class Libre : UserControl
    {
        public Libre()
        {
            InitializeComponent();
        }

        private void Libre_Load(object sender, EventArgs e)
        {
            MostrarLibre();
            TotalLibre();
        }
        public void MostrarLibre()
        {
            DataTable tabla = new DataTable();
            DaoAhorros consulta = new DaoAhorros();
            consulta.mostrarTable(ref tabla, "Libre");
            dgvLibre.DataSource = tabla;
            Diseño.DiseñoDGV(ref dgvLibre);
        }
        public void TotalLibre()
        {
            DataTable tabla = new DataTable();
            DaoAhorros consulta = new DaoAhorros();
            consulta.TotalAhorros(ref tabla);
            lblLibre.Text = String.Format("{0:C}", tabla.Rows[1][1]);
        }
    }
}
