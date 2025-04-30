namespace IngenieriaSoftware.UI
{
    partial class FormAuditoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRegistrosModificados = new System.Windows.Forms.DataGridView();
            this.lblDetallesDelCambio = new System.Windows.Forms.Label();
            this.comboBoxTablasAuditadas = new System.Windows.Forms.ComboBox();
            this.lblHistorialCambiosTabla = new System.Windows.Forms.Label();
            this.dataGridViewHistorialCambios = new System.Windows.Forms.DataGridView();
            this.lblSeleccioneTablas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDetallesRegistro = new System.Windows.Forms.Button();
            this.btnPeticionRestauracion = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosModificados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegistrosModificados
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegistrosModificados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRegistrosModificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewRegistrosModificados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRegistrosModificados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewRegistrosModificados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewRegistrosModificados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistrosModificados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRegistrosModificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegistrosModificados.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewRegistrosModificados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRegistrosModificados.EnableHeadersVisualStyles = false;
            this.dataGridViewRegistrosModificados.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewRegistrosModificados.Location = new System.Drawing.Point(140, 126);
            this.dataGridViewRegistrosModificados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRegistrosModificados.MultiSelect = false;
            this.dataGridViewRegistrosModificados.Name = "dataGridViewRegistrosModificados";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistrosModificados.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewRegistrosModificados.RowHeadersVisible = false;
            this.dataGridViewRegistrosModificados.RowHeadersWidth = 51;
            this.dataGridViewRegistrosModificados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegistrosModificados.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegistrosModificados.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistrosModificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegistrosModificados.Size = new System.Drawing.Size(1344, 395);
            this.dataGridViewRegistrosModificados.TabIndex = 32;
            this.dataGridViewRegistrosModificados.Tag = "1237";
            // 
            // lblDetallesDelCambio
            // 
            this.lblDetallesDelCambio.AutoSize = true;
            this.lblDetallesDelCambio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDetallesDelCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesDelCambio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetallesDelCambio.Location = new System.Drawing.Point(135, 545);
            this.lblDetallesDelCambio.Name = "lblDetallesDelCambio";
            this.lblDetallesDelCambio.Size = new System.Drawing.Size(202, 28);
            this.lblDetallesDelCambio.TabIndex = 33;
            this.lblDetallesDelCambio.Tag = "1236";
            this.lblDetallesDelCambio.Text = "Detalles del cambio";
            // 
            // comboBoxTablasAuditadas
            // 
            this.comboBoxTablasAuditadas.FormattingEnabled = true;
            this.comboBoxTablasAuditadas.Location = new System.Drawing.Point(969, 34);
            this.comboBoxTablasAuditadas.Name = "comboBoxTablasAuditadas";
            this.comboBoxTablasAuditadas.Size = new System.Drawing.Size(219, 24);
            this.comboBoxTablasAuditadas.TabIndex = 34;
            this.comboBoxTablasAuditadas.Tag = "1234";
            this.comboBoxTablasAuditadas.Text = "Seleccione...";
            // 
            // lblHistorialCambiosTabla
            // 
            this.lblHistorialCambiosTabla.AutoSize = true;
            this.lblHistorialCambiosTabla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHistorialCambiosTabla.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialCambiosTabla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistorialCambiosTabla.Location = new System.Drawing.Point(135, 84);
            this.lblHistorialCambiosTabla.Name = "lblHistorialCambiosTabla";
            this.lblHistorialCambiosTabla.Size = new System.Drawing.Size(318, 28);
            this.lblHistorialCambiosTabla.TabIndex = 35;
            this.lblHistorialCambiosTabla.Tag = "1238";
            this.lblHistorialCambiosTabla.Text = "Historial de cambios de la tabla";
            // 
            // dataGridViewHistorialCambios
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewHistorialCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewHistorialCambios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHistorialCambios.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewHistorialCambios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewHistorialCambios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewHistorialCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistorialCambios.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewHistorialCambios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewHistorialCambios.EnableHeadersVisualStyles = false;
            this.dataGridViewHistorialCambios.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewHistorialCambios.Location = new System.Drawing.Point(140, 583);
            this.dataGridViewHistorialCambios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistorialCambios.MultiSelect = false;
            this.dataGridViewHistorialCambios.Name = "dataGridViewHistorialCambios";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewHistorialCambios.RowHeadersVisible = false;
            this.dataGridViewHistorialCambios.RowHeadersWidth = 51;
            this.dataGridViewHistorialCambios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorialCambios.Size = new System.Drawing.Size(1344, 459);
            this.dataGridViewHistorialCambios.TabIndex = 36;
            this.dataGridViewHistorialCambios.Tag = "1239";
            // 
            // lblSeleccioneTablas
            // 
            this.lblSeleccioneTablas.AutoSize = true;
            this.lblSeleccioneTablas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeleccioneTablas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneTablas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccioneTablas.Location = new System.Drawing.Point(731, 34);
            this.lblSeleccioneTablas.Name = "lblSeleccioneTablas";
            this.lblSeleccioneTablas.Size = new System.Drawing.Size(215, 28);
            this.lblSeleccioneTablas.TabIndex = 37;
            this.lblSeleccioneTablas.Tag = "1235";
            this.lblSeleccioneTablas.Text = "Seleccione una tabla:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1099, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 39);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Tag = "1232";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDetallesRegistro
            // 
            this.btnDetallesRegistro.BackColor = System.Drawing.Color.Teal;
            this.btnDetallesRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallesRegistro.Location = new System.Drawing.Point(1272, 531);
            this.btnDetallesRegistro.Name = "btnDetallesRegistro";
            this.btnDetallesRegistro.Size = new System.Drawing.Size(212, 45);
            this.btnDetallesRegistro.TabIndex = 39;
            this.btnDetallesRegistro.Tag = "1233";
            this.btnDetallesRegistro.Text = "Ver Detalles";
            this.btnDetallesRegistro.UseVisualStyleBackColor = false;
            this.btnDetallesRegistro.Click += new System.EventHandler(this.btnDetallesRegistro_Click);
            // 
            // btnPeticionRestauracion
            // 
            this.btnPeticionRestauracion.BackColor = System.Drawing.Color.Crimson;
            this.btnPeticionRestauracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeticionRestauracion.Location = new System.Drawing.Point(1517, 400);
            this.btnPeticionRestauracion.Name = "btnPeticionRestauracion";
            this.btnPeticionRestauracion.Size = new System.Drawing.Size(236, 121);
            this.btnPeticionRestauracion.TabIndex = 40;
            this.btnPeticionRestauracion.Tag = "";
            this.btnPeticionRestauracion.Text = "Petición de Restauración";
            this.btnPeticionRestauracion.UseVisualStyleBackColor = false;
            this.btnPeticionRestauracion.Click += new System.EventHandler(this.btnPeticionRestauracion_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(1517, 126);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(236, 88);
            this.txtComentario.TabIndex = 41;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblComentario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComentario.Location = new System.Drawing.Point(1512, 84);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(125, 28);
            this.lblComentario.TabIndex = 42;
            this.lblComentario.Tag = "";
            this.lblComentario.Text = "Comentario";
            // 
            // FormAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnPeticionRestauracion);
            this.Controls.Add(this.btnDetallesRegistro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSeleccioneTablas);
            this.Controls.Add(this.dataGridViewHistorialCambios);
            this.Controls.Add(this.lblHistorialCambiosTabla);
            this.Controls.Add(this.comboBoxTablasAuditadas);
            this.Controls.Add(this.lblDetallesDelCambio);
            this.Controls.Add(this.dataGridViewRegistrosModificados);
            this.Name = "FormAuditoria";
            this.Tag = "1240";
            this.Text = "FormAuditoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosModificados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRegistrosModificados;
        private System.Windows.Forms.Label lblDetallesDelCambio;
        private System.Windows.Forms.ComboBox comboBoxTablasAuditadas;
        private System.Windows.Forms.Label lblHistorialCambiosTabla;
        private System.Windows.Forms.DataGridView dataGridViewHistorialCambios;
        private System.Windows.Forms.Label lblSeleccioneTablas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDetallesRegistro;
        private System.Windows.Forms.Button btnPeticionRestauracion;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
    }
}