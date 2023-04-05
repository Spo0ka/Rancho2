namespace PresentacionPrototipo
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbBecerros = new System.Windows.Forms.ToolStripButton();
            this.TsbVacas = new System.Windows.Forms.ToolStripButton();
            this.TsbForraje = new System.Windows.Forms.ToolStripButton();
            this.TsbMedicamento = new System.Windows.Forms.ToolStripButton();
            this.TsbVacunacionBe = new System.Windows.Forms.ToolStripButton();
            this.TsbVacuncionVa = new System.Windows.Forms.ToolStripButton();
            this.TsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbBecerros,
            this.TsbVacas,
            this.TsbForraje,
            this.TsbMedicamento,
            this.TsbVacunacionBe,
            this.TsbVacuncionVa,
            this.TsbSalir});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(52, 605);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbBecerros
            // 
            this.TsbBecerros.AutoSize = false;
            this.TsbBecerros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBecerros.Image = global::PresentacionPrototipo.Properties.Resources.Becerro;
            this.TsbBecerros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBecerros.Name = "TsbBecerros";
            this.TsbBecerros.Size = new System.Drawing.Size(50, 50);
            this.TsbBecerros.Text = "Becerros";
            this.TsbBecerros.Click += new System.EventHandler(this.TsbBecerros_Click);
            // 
            // TsbVacas
            // 
            this.TsbVacas.AutoSize = false;
            this.TsbVacas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbVacas.Image = global::PresentacionPrototipo.Properties.Resources.vaca;
            this.TsbVacas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbVacas.Name = "TsbVacas";
            this.TsbVacas.Size = new System.Drawing.Size(50, 50);
            this.TsbVacas.Text = "toolStripButton1";
            this.TsbVacas.Click += new System.EventHandler(this.TsbVacas_Click);
            // 
            // TsbForraje
            // 
            this.TsbForraje.AutoSize = false;
            this.TsbForraje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbForraje.Image = global::PresentacionPrototipo.Properties.Resources.forraje;
            this.TsbForraje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbForraje.Name = "TsbForraje";
            this.TsbForraje.Size = new System.Drawing.Size(50, 50);
            this.TsbForraje.Text = "Forraje";
            this.TsbForraje.Click += new System.EventHandler(this.TsbForraje_Click);
            // 
            // TsbMedicamento
            // 
            this.TsbMedicamento.AutoSize = false;
            this.TsbMedicamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbMedicamento.Image = global::PresentacionPrototipo.Properties.Resources.medicamentos;
            this.TsbMedicamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbMedicamento.Name = "TsbMedicamento";
            this.TsbMedicamento.Size = new System.Drawing.Size(50, 50);
            this.TsbMedicamento.Text = "Medicamento";
            this.TsbMedicamento.Click += new System.EventHandler(this.TsbMedicamento_Click);
            // 
            // TsbVacunacionBe
            // 
            this.TsbVacunacionBe.AutoSize = false;
            this.TsbVacunacionBe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbVacunacionBe.Image = global::PresentacionPrototipo.Properties.Resources.Becerro_salud;
            this.TsbVacunacionBe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbVacunacionBe.Name = "TsbVacunacionBe";
            this.TsbVacunacionBe.Size = new System.Drawing.Size(50, 50);
            this.TsbVacunacionBe.Text = "Vacunacion Becerro";
            this.TsbVacunacionBe.Click += new System.EventHandler(this.TsbVacunacionBe_Click);
            // 
            // TsbVacuncionVa
            // 
            this.TsbVacuncionVa.AutoSize = false;
            this.TsbVacuncionVa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbVacuncionVa.Image = global::PresentacionPrototipo.Properties.Resources.Vaca_salud;
            this.TsbVacuncionVa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbVacuncionVa.Name = "TsbVacuncionVa";
            this.TsbVacuncionVa.Size = new System.Drawing.Size(50, 50);
            this.TsbVacuncionVa.Text = "Vacunacion vaca";
            this.TsbVacuncionVa.Click += new System.EventHandler(this.TsbVacuncionVa_Click);
            // 
            // TsbSalir
            // 
            this.TsbSalir.AutoSize = false;
            this.TsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSalir.Image = global::PresentacionPrototipo.Properties.Resources.cerrar1;
            this.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalir.Name = "TsbSalir";
            this.TsbSalir.Size = new System.Drawing.Size(50, 50);
            this.TsbSalir.Text = "Salir";
            this.TsbSalir.Click += new System.EventHandler(this.TsbSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 605);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbBecerros;
        private System.Windows.Forms.ToolStripButton TsbVacas;
        private System.Windows.Forms.ToolStripButton TsbForraje;
        private System.Windows.Forms.ToolStripButton TsbMedicamento;
        private System.Windows.Forms.ToolStripButton TsbVacunacionBe;
        private System.Windows.Forms.ToolStripButton TsbVacuncionVa;
        private System.Windows.Forms.ToolStripButton TsbSalir;
    }
}