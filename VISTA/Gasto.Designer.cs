
namespace Presupuesto.VISTA
{
    partial class Gasto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGastos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGastos
            // 
            this.dgvGastos.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGastos.Location = new System.Drawing.Point(0, 58);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGastos.Size = new System.Drawing.Size(730, 287);
            this.dgvGastos.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGastos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 58);
            this.panel1.TabIndex = 3;
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.ForeColor = System.Drawing.Color.Red;
            this.lblGastos.Location = new System.Drawing.Point(295, 15);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(141, 29);
            this.lblGastos.TabIndex = 0;
            this.lblGastos.Text = "total gastos.";
            this.lblGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.panel1);
            this.Name = "Gasto";
            this.Size = new System.Drawing.Size(730, 345);
            this.Load += new System.EventHandler(this.Gasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGastos;
    }
}
