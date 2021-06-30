
namespace Presupuesto
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnAhorros = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BarraLibre = new System.Windows.Forms.Panel();
            this.BarraAhorros = new System.Windows.Forms.Panel();
            this.BarraGastos = new System.Windows.Forms.Panel();
            this.BarraIngresos = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(177)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 2);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESUPUESTO.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnLibre);
            this.panel2.Controls.Add(this.btnAhorros);
            this.panel2.Controls.Add(this.btnGastos);
            this.panel2.Controls.Add(this.btnIngresos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 46);
            this.panel2.TabIndex = 1;
            // 
            // btnLibre
            // 
            this.btnLibre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLibre.FlatAppearance.BorderSize = 0;
            this.btnLibre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnLibre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibre.ForeColor = System.Drawing.Color.White;
            this.btnLibre.Location = new System.Drawing.Point(480, 0);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(160, 46);
            this.btnLibre.TabIndex = 3;
            this.btnLibre.Text = "Libre";
            this.btnLibre.UseVisualStyleBackColor = true;
            this.btnLibre.Click += new System.EventHandler(this.btnLibre_Click);
            // 
            // btnAhorros
            // 
            this.btnAhorros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAhorros.FlatAppearance.BorderSize = 0;
            this.btnAhorros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnAhorros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAhorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAhorros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAhorros.Location = new System.Drawing.Point(320, 0);
            this.btnAhorros.Name = "btnAhorros";
            this.btnAhorros.Size = new System.Drawing.Size(160, 46);
            this.btnAhorros.TabIndex = 2;
            this.btnAhorros.Text = "Ahorros";
            this.btnAhorros.UseVisualStyleBackColor = true;
            this.btnAhorros.Click += new System.EventHandler(this.btnAhorros_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Location = new System.Drawing.Point(160, 0);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(160, 46);
            this.btnGastos.TabIndex = 1;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Location = new System.Drawing.Point(0, 0);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(160, 46);
            this.btnIngresos.TabIndex = 0;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel5.Controls.Add(this.BarraLibre);
            this.panel5.Controls.Add(this.BarraAhorros);
            this.panel5.Controls.Add(this.BarraGastos);
            this.panel5.Controls.Add(this.BarraIngresos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 2);
            this.panel5.TabIndex = 4;
            // 
            // BarraLibre
            // 
            this.BarraLibre.BackColor = System.Drawing.Color.Aqua;
            this.BarraLibre.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLibre.Location = new System.Drawing.Point(480, 0);
            this.BarraLibre.Name = "BarraLibre";
            this.BarraLibre.Size = new System.Drawing.Size(160, 2);
            this.BarraLibre.TabIndex = 3;
            // 
            // BarraAhorros
            // 
            this.BarraAhorros.BackColor = System.Drawing.Color.Yellow;
            this.BarraAhorros.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraAhorros.Location = new System.Drawing.Point(320, 0);
            this.BarraAhorros.Name = "BarraAhorros";
            this.BarraAhorros.Size = new System.Drawing.Size(160, 2);
            this.BarraAhorros.TabIndex = 2;
            // 
            // BarraGastos
            // 
            this.BarraGastos.BackColor = System.Drawing.Color.Red;
            this.BarraGastos.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraGastos.Location = new System.Drawing.Point(160, 0);
            this.BarraGastos.Name = "BarraGastos";
            this.BarraGastos.Size = new System.Drawing.Size(160, 2);
            this.BarraGastos.TabIndex = 1;
            // 
            // BarraIngresos
            // 
            this.BarraIngresos.BackColor = System.Drawing.Color.Lime;
            this.BarraIngresos.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraIngresos.Location = new System.Drawing.Point(0, 0);
            this.BarraIngresos.Name = "BarraIngresos";
            this.BarraIngresos.Size = new System.Drawing.Size(160, 2);
            this.BarraIngresos.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 105);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(730, 290);
            this.pnlContenido.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel4.Controls.Add(this.btnVolver);
            this.panel4.Controls.Add(this.btnVolver2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 55);
            this.panel4.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Presupuesto.Properties.Resources.home;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(338, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(54, 47);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::Presupuesto.Properties.Resources.agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(640, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackgroundImage = global::Presupuesto.Properties.Resources.home;
            this.btnVolver2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver2.FlatAppearance.BorderSize = 0;
            this.btnVolver2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver2.Location = new System.Drawing.Point(343, 9);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(44, 37);
            this.btnVolver2.TabIndex = 1;
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.MouseEnter += new System.EventHandler(this.btnVolver_MouseEnter);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnAhorros;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel BarraLibre;
        private System.Windows.Forms.Panel BarraAhorros;
        private System.Windows.Forms.Panel BarraGastos;
        private System.Windows.Forms.Panel BarraIngresos;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolver2;
    }
}

