using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presupuesto.LOGICA
{
    class Diseño
    {
        public static void DiseñoDGV(ref DataGridView tabla)
        {
         
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabla.RowHeadersVisible = false;
            tabla.ReadOnly = true;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AllowDrop = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToOrderColumns = false;
            tabla.AllowUserToResizeColumns = true;
            tabla.AllowUserToResizeRows = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.BorderStyle = BorderStyle.None;
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            tabla.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cabecera.BackColor = Color.FromArgb(24, 24, 24);
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle = cabecera;

            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            tabla.BackgroundColor = Color.FromArgb(34, 34, 34);
            tabla.DefaultCellStyle.BackColor = Color.FromArgb(29, 29, 29);
            tabla.DefaultCellStyle.ForeColor = Color.White;
            tabla.DefaultCellStyle.SelectionBackColor = Color.Black;
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;

            tabla.Columns["Valor"].DefaultCellStyle.Format = "C2";
        }
    }
}
