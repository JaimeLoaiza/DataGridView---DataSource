namespace DataGridViewExample
{
    partial class Form1
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
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.lblpersonaid = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblprofesion = new System.Windows.Forms.Label();
            this.txtPersonaId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTabla
            // 
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Location = new System.Drawing.Point(15, 128);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTabla.Size = new System.Drawing.Size(509, 309);
            this.DgvTabla.TabIndex = 0;
            this.DgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellContentClick);
            // 
            // lblpersonaid
            // 
            this.lblpersonaid.AutoSize = true;
            this.lblpersonaid.Location = new System.Drawing.Point(36, 13);
            this.lblpersonaid.Name = "lblpersonaid";
            this.lblpersonaid.Size = new System.Drawing.Size(55, 13);
            this.lblpersonaid.TabIndex = 1;
            this.lblpersonaid.Text = "PersonaId";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(200, 13);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(365, 13);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // lblprofesion
            // 
            this.lblprofesion.AutoSize = true;
            this.lblprofesion.Location = new System.Drawing.Point(36, 62);
            this.lblprofesion.Name = "lblprofesion";
            this.lblprofesion.Size = new System.Drawing.Size(51, 13);
            this.lblprofesion.TabIndex = 4;
            this.lblprofesion.Text = "Profesion";
            // 
            // txtPersonaId
            // 
            this.txtPersonaId.Location = new System.Drawing.Point(39, 29);
            this.txtPersonaId.Name = "txtPersonaId";
            this.txtPersonaId.Size = new System.Drawing.Size(104, 20);
            this.txtPersonaId.TabIndex = 5;
            this.txtPersonaId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(203, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(368, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(104, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(39, 78);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(433, 20);
            this.txtProfesion.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 449);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPersonaId);
            this.Controls.Add(this.lblprofesion);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblpersonaid);
            this.Controls.Add(this.DgvTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.Label lblpersonaid;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblprofesion;
        private System.Windows.Forms.TextBox txtPersonaId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtProfesion;
    }
}

