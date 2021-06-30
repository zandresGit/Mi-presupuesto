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
    public partial class Ingreso : UserControl
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            MostrarIngresos();
            TotalIngresos();
        }

        public void MostrarIngresos()
        {
            DataTable tabla = new DataTable();
            DaoIngresos consulta = new DaoIngresos();
            consulta.mostrarTable(ref tabla, "Ingresos");
            dgvIngresos.DataSource = tabla;
            Diseño.DiseñoDGV(ref dgvIngresos);
            
        }

        public void TotalIngresos()
        {
            DataTable tabla = new DataTable();
            DaoIngresos consulta = new DaoIngresos();
            consulta.TotalIngresos(ref tabla);
            lblIngresos.Text = String.Format("{0:C}", tabla.Rows[0][0]);
        }

    }
}
