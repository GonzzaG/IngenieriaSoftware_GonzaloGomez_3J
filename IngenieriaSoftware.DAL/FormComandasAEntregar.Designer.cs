namespace IngenieriaSoftware.DAL
{
    partial class FormComandasAEntregar
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
            this.btnComandaEnPreparacion = new System.Windows.Forms.Button();
            this.lblComandasAEntregar = new System.Windows.Forms.Label();
            this.dataGridViewComandasPendientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComandaEnPreparacion
            // 
            this.btnComandaEnPreparacion.Location = new System.Drawing.Point(44, 388);
            this.btnComandaEnPreparacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnComandaEnPreparacion.Name = "btnComandaEnPreparacion";
            this.btnComandaEnPreparacion.Size = new System.Drawing.Size(162, 45);
            this.btnComandaEnPreparacion.TabIndex = 31;
            this.btnComandaEnPreparacion.Tag = "74";
            this.btnComandaEnPreparacion.Text = "Marcar como entregado";
            this.btnComandaEnPreparacion.UseVisualStyleBackColor = true;
            this.btnComandaEnPreparacion.Click += new System.EventHandler(this.btnComandaEnPreparacion_Click);
            // 
            // lblComandasAEntregar
            // 
            this.lblComandasAEntregar.AutoSize = true;
            this.lblComandasAEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandasAEntregar.Location = new System.Drawing.Point(39, 19);
            this.lblComandasAEntregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComandasAEntregar.Name = "lblComandasAEntregar";
            this.lblComandasAEntregar.Size = new System.Drawing.Size(241, 26);
            this.lblComandasAEntregar.TabIndex = 30;
            this.lblComandasAEntregar.Tag = "70";
            this.lblComandasAEntregar.Text = "Comandas a entregar";
            // 
            // dataGridViewComandasPendientes
            // 
            this.dataGridViewComandasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandasPendientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandasPendientes.Location = new System.Drawing.Point(44, 65);
            this.dataGridViewComandasPendientes.MultiSelect = false;
            this.dataGridViewComandasPendientes.Name = "dataGridViewComandasPendientes";
            this.dataGridViewComandasPendientes.RowHeadersVisible = false;
            this.dataGridViewComandasPendientes.RowHeadersWidth = 51;
            this.dataGridViewComandasPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandasPendientes.Size = new System.Drawing.Size(609, 297);
            this.dataGridViewComandasPendientes.TabIndex = 29;
            this.dataGridViewComandasPendientes.Tag = "71";
            // 
            // FormComandasAEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnComandaEnPreparacion);
            this.Controls.Add(this.lblComandasAEntregar);
            this.Controls.Add(this.dataGridViewComandasPendientes);
            this.Name = "FormComandasAEntregar";
            this.Text = "Comandas a entregar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandaEnPreparacion;
        private System.Windows.Forms.Label lblComandasAEntregar;
        private System.Windows.Forms.DataGridView dataGridViewComandasPendientes;
    }
}