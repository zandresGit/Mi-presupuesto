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
    public partial class Gasto : UserControl
    {
        public Gasto()
        {
            InitializeComponent();
            
        }
        private void Gasto_Load(object sender, EventArgs e)
        {
            MostrarGastos();
            TotalGastos();
        }
        public void MostrarGastos()
        {
            DataTable tabla = new DataTable();
            DaoGastos consulta = new DaoGastos();
            consulta.mostrarTable(ref tabla, "Gastos");
            dgvGastos.DataSource = tabla;
            Diseño.DiseñoDGV(ref dgvGastos);
        }
        public void TotalGastos()
        {
            DataTable tabla = new DataTable();
            DaoGastos consulta = new DaoGastos();
            consulta.TotalGastos(ref tabla);
            lblGastos.Text = String.Format("{0:C}", tabla.Rows[0][0]);
        }
    }
}
