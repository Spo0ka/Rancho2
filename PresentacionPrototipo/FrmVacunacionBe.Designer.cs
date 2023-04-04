namespace PresentacionPrototipo
{
    partial class FrmVacunacionBe
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtgMostrar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMostrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(30, 112);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(868, 31);
            this.TxtBuscar.TabIndex = 10;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DtgMostrar
            // 
            this.DtgMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMostrar.Location = new System.Drawing.Point(30, 152);
            this.DtgMostrar.Margin = new System.Windows.Forms.Padding(6);
            this.DtgMostrar.Name = "DtgMostrar";
            this.DtgMostrar.Size = new System.Drawing.Size(934, 429);
            this.DtgMostrar.TabIndex = 8;
            this.DtgMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMostrar_CellClick);
            this.DtgMostrar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMostrar_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 100);
            this.panel1.TabIndex = 9;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::PresentacionPrototipo.Properties.Resources.cerrar;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(913, 34);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(51, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacunacion Becerros";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::PresentacionPrototipo.Properties.Resources.anadir;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.Location = new System.Drawing.Point(904, 109);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(51, 36);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmVacunacionBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 605);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DtgMostrar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVacunacionBe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacunacionBe";
            ((System.ComponentModel.ISupportInitialize)(this.DtgMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtgMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}