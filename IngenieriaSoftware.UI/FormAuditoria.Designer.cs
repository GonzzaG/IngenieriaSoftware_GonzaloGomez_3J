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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHistorialCambiosRegistro = new System.Windows.Forms.Label();
            this.dataGridViewHistorialCambios = new System.Windows.Forms.DataGridView();
            this.btnDetallesRegistro = new System.Windows.Forms.Button();
            this.btnPeticionRestauracion = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorialCambiosRegistro
            // 
            this.lblHistorialCambiosRegistro.AutoSize = true;
            this.lblHistorialCambiosRegistro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHistorialCambiosRegistro.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialCambiosRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistorialCambiosRegistro.Location = new System.Drawing.Point(126, 63);
            this.lblHistorialCambiosRegistro.Name = "lblHistorialCambiosRegistro";
            this.lblHistorialCambiosRegistro.Size = new System.Drawing.Size(328, 28);
            this.lblHistorialCambiosRegistro.TabIndex = 35;
            this.lblHistorialCambiosRegistro.Tag = "1238";
            this.lblHistorialCambiosRegistro.Text = "Historial de cambios del registro";
            // 
            // dataGridViewHistorialCambios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistorialCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewHistorialCambios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHistorialCambios.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewHistorialCambios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewHistorialCambios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistorialCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistorialCambios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistorialCambios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewHistorialCambios.EnableHeadersVisualStyles = false;
            this.dataGridViewHistorialCambios.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewHistorialCambios.Location = new System.Drawing.Point(67, 95);
            this.dataGridViewHistorialCambios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistorialCambios.MultiSelect = false;
            this.dataGridViewHistorialCambios.Name = "dataGridViewHistorialCambios";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHistorialCambios.RowHeadersVisible = false;
            this.dataGridViewHistorialCambios.RowHeadersWidth = 51;
            this.dataGridViewHistorialCambios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistorialCambios.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorialCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorialCambios.Size = new System.Drawing.Size(1344, 351);
            this.dataGridViewHistorialCambios.TabIndex = 36;
            this.dataGridViewHistorialCambios.Tag = "1239";
            // 
            // btnDetallesRegistro
            // 
            this.btnDetallesRegistro.BackColor = System.Drawing.Color.Teal;
            this.btnDetallesRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallesRegistro.Location = new System.Drawing.Point(1528, 543);
            this.btnDetallesRegistro.Name = "btnDetallesRegistro";
            this.btnDetallesRegistro.Size = new System.Drawing.Size(212, 45);
            this.btnDetallesRegistro.TabIndex = 39;
            this.btnDetallesRegistro.Tag = "1233";
            this.btnDetallesRegistro.Text = "Ver Detalles";
            this.btnDetallesRegistro.UseVisualStyleBackColor = false;
            this.btnDetallesRegistro.Visible = false;
            this.btnDetallesRegistro.Click += new System.EventHandler(this.btnDetallesRegistro_Click);
            // 
            // btnPeticionRestauracion
            // 
            this.btnPeticionRestauracion.BackColor = System.Drawing.Color.Crimson;
            this.btnPeticionRestauracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeticionRestauracion.Location = new System.Drawing.Point(1504, 262);
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
            this.txtComentario.Location = new System.Drawing.Point(1504, 117);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(236, 111);
            this.txtComentario.TabIndex = 41;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblComentario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComentario.Location = new System.Drawing.Point(1499, 75);
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
            this.Controls.Add(this.dataGridViewHistorialCambios);
            this.Controls.Add(this.lblHistorialCambiosRegistro);
            this.Name = "FormAuditoria";
            this.Tag = "1240";
            this.Text = "FormAuditoria";
            this.Load += new System.EventHandler(this.FormAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorialCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHistorialCambiosRegistro;
        private System.Windows.Forms.DataGridView dataGridViewHistorialCambios;
        private System.Windows.Forms.Button btnDetallesRegistro;
        private System.Windows.Forms.Button btnPeticionRestauracion;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
    }
}