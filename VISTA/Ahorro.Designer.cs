
namespace Presupuesto.VISTA
{
    partial class Ahorro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAhorros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColchon = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblTituloColchon = new System.Windows.Forms.Label();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAhorros
            // 
            this.dgvAhorros.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAhorros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAhorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhorros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAhorros.Location = new System.Drawing.Point(0, 58);
            this.dgvAhorros.Name = "dgvAhorros";
            this.dgvAhorros.Size = new System.Drawing.Size(730, 287);
            this.dgvAhorros.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblColchon);
            this.panel1.Controls.Add(this.lblReserva);
            this.panel1.Controls.Add(this.lblTituloColchon);
            this.panel1.Controls.Add(this.lblTituloReserva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 58);
            this.panel1.TabIndex = 3;
            // 
            // lblColchon
            // 
            this.lblColchon.AutoSize = true;
            this.lblColchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColchon.ForeColor = System.Drawing.Color.Yellow;
            this.lblColchon.Location = new System.Drawing.Point(491, 15);
            this.lblColchon.Name = "lblColchon";
            this.lblColchon.Size = new System.Drawing.Size(154, 29);
            this.lblColchon.TabIndex = 1;
            this.lblColchon.Text = "total  colchon";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.Yellow;
            this.lblReserva.Location = new System.Drawing.Point(192, 15);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(144, 29);
            this.lblReserva.TabIndex = 0;
            this.lblReserva.Text = "total reserva";
            // 
            // lblTituloColchon
            // 
            this.lblTituloColchon.AutoSize = true;
            this.lblTituloColchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColchon.ForeColor = System.Drawing.Color.Yellow;
            this.lblTituloColchon.Location = new System.Drawing.Point(387, 15);
            this.lblTituloColchon.Name = "lblTituloColchon";
            this.lblTituloColchon.Size = new System.Drawing.Size(114, 29);
            this.lblTituloColchon.TabIndex = 3;
            this.lblTituloColchon.Text = "Colchon: ";
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.ForeColor = System.Drawing.Color.Yellow;
            this.lblTituloReserva.Location = new System.Drawing.Point(80, 15);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(114, 29);
            this.lblTituloReserva.TabIndex = 2;
            this.lblTituloReserva.Text = "Reserva: ";
            // 
            // Ahorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.dgvAhorros);
            this.Controls.Add(this.panel1);
            this.Name = "Ahorro";
            this.Size = new System.Drawing.Size(730, 345);
            this.Load += new System.EventHandler(this.Ahorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAhorros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblColchon;
        private System.Windows.Forms.Label lblTituloColchon;
        private System.Windows.Forms.Label lblTituloReserva;
    }
}
