namespace IngenieriaSoftware.UI
{
    partial class FormBitacoraBusqueda
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
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.checkBoxBuscarPorArea = new System.Windows.Forms.CheckBox();
            this.dgvBitacora = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.SuspendLayout();
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRegistros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(658, 72);
            this.btnBuscarRegistros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(176, 57);
            this.btnBuscarRegistros.TabIndex = 3;
            this.btnBuscarRegistros.Tag = "1212";
            this.btnBuscarRegistros.Text = "Buscar";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Checked = false;
            this.desdeDateTimePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(64, 86);
            this.desdeDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(137, 32);
            this.desdeDateTimePicker.TabIndex = 4;
            this.desdeDateTimePicker.Value = new System.DateTime(2025, 4, 21, 1, 49, 32, 0);
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesde.Location = new System.Drawing.Point(93, 52);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(58, 21);
            this.lblDesde.TabIndex = 11;
            this.lblDesde.Tag = "1209";
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHasta.Location = new System.Drawing.Point(256, 52);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(54, 21);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Tag = "1210";
            this.lblHasta.Text = "Hasta";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(260, 86);
            this.hastaDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(137, 32);
            this.hastaDateTimePicker.TabIndex = 12;
            this.hastaDateTimePicker.Value = new System.DateTime(2025, 4, 21, 1, 49, 44, 0);
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArea.Location = new System.Drawing.Point(443, 52);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(46, 21);
            this.lblArea.TabIndex = 14;
            this.lblArea.Tag = "1211";
            this.lblArea.Text = "Area";
            // 
            // txtModulo
            // 
            this.txtModulo.BackColor = System.Drawing.Color.DarkGray;
            this.txtModulo.Enabled = false;
            this.txtModulo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModulo.Location = new System.Drawing.Point(447, 86);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(131, 29);
            this.txtModulo.TabIndex = 15;
            // 
            // checkBoxBuscarPorArea
            // 
            this.checkBoxBuscarPorArea.AutoSize = true;
            this.checkBoxBuscarPorArea.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuscarPorArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxBuscarPorArea.Location = new System.Drawing.Point(447, 119);
            this.checkBoxBuscarPorArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBuscarPorArea.Name = "checkBoxBuscarPorArea";
            this.checkBoxBuscarPorArea.Size = new System.Drawing.Size(144, 25);
            this.checkBoxBuscarPorArea.TabIndex = 16;
            this.checkBoxBuscarPorArea.Tag = "1213";
            this.checkBoxBuscarPorArea.Text = "Buscar por area?";
            this.checkBoxBuscarPorArea.UseVisualStyleBackColor = true;
            this.checkBoxBuscarPorArea.CheckedChanged += new System.EventHandler(this.checkBoxBuscarPorModulo_CheckedChanged);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.BackColor = System.Drawing.Color.Transparent;
            this.dgvBitacora.Location = new System.Drawing.Point(64, 188);
            this.dgvBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.Size = new System.Drawing.Size(1016, 282);
            this.dgvBitacora.TabIndex = 32;
            this.dgvBitacora.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // FormBitacoraBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1443, 692);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.checkBoxBuscarPorArea);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBitacoraBusqueda";
            this.Tag = "1215";
            this.Text = "FormBitacoraBusqueda";
            this.Load += new System.EventHandler(this.FormBitacoraBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.CheckBox checkBoxBuscarPorArea;
        private ControlesPersonalizados.DataGridViewConFiltros dgvBitacora;
    }
}