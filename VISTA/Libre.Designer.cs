
namespace Presupuesto.VISTA
{
    partial class Libre
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
            this.dgvLibre = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLibre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibre)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibre
            // 
            this.dgvLibre.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvLibre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibre.Location = new System.Drawing.Point(0, 58);
            this.dgvLibre.Name = "dgvLibre";
            this.dgvLibre.Size = new System.Drawing.Size(730, 287);
            this.dgvLibre.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLibre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 58);
            this.panel1.TabIndex = 3;
            // 
            // lblLibre
            // 
            this.lblLibre.AutoSize = true;
            this.lblLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibre.ForeColor = System.Drawing.Color.Cyan;
            this.lblLibre.Location = new System.Drawing.Point(300, 15);
            this.lblLibre.Name = "lblLibre";
            this.lblLibre.Size = new System.Drawing.Size(130, 29);
            this.lblLibre.TabIndex = 0;
            this.lblLibre.Text = "total libres.";
            // 
            // Libre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.dgvLibre);
            this.Controls.Add(this.panel1);
            this.Name = "Libre";
            this.Size = new System.Drawing.Size(730, 345);
            this.Load += new System.EventHandler(this.Libre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibre)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLibre;
    }
}
