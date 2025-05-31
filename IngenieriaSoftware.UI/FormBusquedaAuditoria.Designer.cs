namespace IngenieriaSoftware.UI
{
    partial class FormBusquedaAuditoria
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
            this.lblRegistros = new System.Windows.Forms.Label();
            this.comboBoxRegistros = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSeleccioneTablas = new System.Windows.Forms.Label();
            this.comboBoxTablasAuditadas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegistros.Location = new System.Drawing.Point(290, 205);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(215, 28);
            this.lblRegistros.TabIndex = 51;
            this.lblRegistros.Tag = "";
            this.lblRegistros.Text = "Seleccione una tabla:";
            // 
            // comboBoxRegistros
            // 
            this.comboBoxRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegistros.FormattingEnabled = true;
            this.comboBoxRegistros.Location = new System.Drawing.Point(536, 205);
            this.comboBoxRegistros.Name = "comboBoxRegistros";
            this.comboBoxRegistros.Size = new System.Drawing.Size(219, 33);
            this.comboBoxRegistros.TabIndex = 50;
            this.comboBoxRegistros.Tag = "";
            this.comboBoxRegistros.Text = "Seleccione...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(437, 310);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 71);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSeleccioneTablas
            // 
            this.lblSeleccioneTablas.AutoSize = true;
            this.lblSeleccioneTablas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeleccioneTablas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneTablas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccioneTablas.Location = new System.Drawing.Point(290, 122);
            this.lblSeleccioneTablas.Name = "lblSeleccioneTablas";
            this.lblSeleccioneTablas.Size = new System.Drawing.Size(215, 28);
            this.lblSeleccioneTablas.TabIndex = 48;
            this.lblSeleccioneTablas.Tag = "";
            this.lblSeleccioneTablas.Text = "Seleccione una tabla:";
            // 
            // comboBoxTablasAuditadas
            // 
            this.comboBoxTablasAuditadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTablasAuditadas.FormattingEnabled = true;
            this.comboBoxTablasAuditadas.Location = new System.Drawing.Point(536, 122);
            this.comboBoxTablasAuditadas.Name = "comboBoxTablasAuditadas";
            this.comboBoxTablasAuditadas.Size = new System.Drawing.Size(219, 33);
            this.comboBoxTablasAuditadas.TabIndex = 47;
            this.comboBoxTablasAuditadas.Tag = "";
            this.comboBoxTablasAuditadas.Text = "Seleccione...";
            this.comboBoxTablasAuditadas.SelectedValueChanged += new System.EventHandler(this.comboBoxTablasAuditadas_SelectedValueChanged);
            // 
            // FormBusquedaAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1194, 560);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.comboBoxRegistros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSeleccioneTablas);
            this.Controls.Add(this.comboBoxTablasAuditadas);
            this.Name = "FormBusquedaAuditoria";
            this.Text = "FormBusquedaAuditoria";
            this.Load += new System.EventHandler(this.FormBusquedaAuditoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.ComboBox comboBoxRegistros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSeleccioneTablas;
        private System.Windows.Forms.ComboBox comboBoxTablasAuditadas;
    }
}