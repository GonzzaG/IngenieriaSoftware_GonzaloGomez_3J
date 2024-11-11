namespace IngenieriaSoftware.UI
{
    partial class FormABMMesas
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
            this.btnEliminarMesa = new System.Windows.Forms.Button();
            this.btnNuevaMesa = new System.Windows.Forms.Button();
            this.lblMesas = new System.Windows.Forms.Label();
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            this.btnModificarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMesa
            // 
            this.btnEliminarMesa.Location = new System.Drawing.Point(961, 247);
            this.btnEliminarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMesa.Name = "btnEliminarMesa";
            this.btnEliminarMesa.Size = new System.Drawing.Size(216, 55);
            this.btnEliminarMesa.TabIndex = 19;
            this.btnEliminarMesa.Tag = "80";
            this.btnEliminarMesa.Text = "Eliminar Mesa";
            this.btnEliminarMesa.UseVisualStyleBackColor = true;
            this.btnEliminarMesa.Click += new System.EventHandler(this.btnEliminarMesa_Click);
            // 
            // btnNuevaMesa
            // 
            this.btnNuevaMesa.Location = new System.Drawing.Point(961, 154);
            this.btnNuevaMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaMesa.Name = "btnNuevaMesa";
            this.btnNuevaMesa.Size = new System.Drawing.Size(216, 55);
            this.btnNuevaMesa.TabIndex = 18;
            this.btnNuevaMesa.Tag = "79";
            this.btnNuevaMesa.Text = "Nueva Mesa";
            this.btnNuevaMesa.UseVisualStyleBackColor = true;
            this.btnNuevaMesa.Click += new System.EventHandler(this.btnGuardarMesa_Click);
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.Location = new System.Drawing.Point(77, 32);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(102, 32);
            this.lblMesas.TabIndex = 17;
            this.lblMesas.Tag = "77";
            this.lblMesas.Text = "Mesas";
            // 
            // dataGridViewMesas
            // 
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMesas.Location = new System.Drawing.Point(31, 87);
            this.dataGridViewMesas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMesas.MultiSelect = false;
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            this.dataGridViewMesas.RowHeadersVisible = false;
            this.dataGridViewMesas.RowHeadersWidth = 51;
            this.dataGridViewMesas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesas.Size = new System.Drawing.Size(803, 404);
            this.dataGridViewMesas.TabIndex = 16;
            this.dataGridViewMesas.Tag = "78";
            // 
            // btnModificarMesa
            // 
            this.btnModificarMesa.Location = new System.Drawing.Point(961, 340);
            this.btnModificarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMesa.Name = "btnModificarMesa";
            this.btnModificarMesa.Size = new System.Drawing.Size(216, 55);
            this.btnModificarMesa.TabIndex = 20;
            this.btnModificarMesa.Tag = "81";
            this.btnModificarMesa.Text = "Modificar Mesa";
            this.btnModificarMesa.UseVisualStyleBackColor = true;
            this.btnModificarMesa.Click += new System.EventHandler(this.btnModificarMesa_Click);
            // 
            // FormABMMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 624);
            this.Controls.Add(this.btnModificarMesa);
            this.Controls.Add(this.btnEliminarMesa);
            this.Controls.Add(this.btnNuevaMesa);
            this.Controls.Add(this.lblMesas);
            this.Controls.Add(this.dataGridViewMesas);
            this.Name = "FormABMMesas";
            this.Tag = "82";
            this.Text = "ABM Mesas";
            this.Load += new System.EventHandler(this.FormABMMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMesa;
        private System.Windows.Forms.Button btnNuevaMesa;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.DataGridView dataGridViewMesas;
        private System.Windows.Forms.Button btnModificarMesa;
    }
}