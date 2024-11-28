namespace IngenieriaSoftware.UI
{
    partial class FormGenerarFacturas
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
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.lblMesasCerradas = new System.Windows.Forms.Label();
            this.dataGridViewMesasCerradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesasCerradas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(47, 479);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(216, 107);
            this.btnGenerarFactura.TabIndex = 19;
            this.btnGenerarFactura.Tag = "376";
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // lblMesasCerradas
            // 
            this.lblMesasCerradas.AutoSize = true;
            this.lblMesasCerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasCerradas.Location = new System.Drawing.Point(60, 26);
            this.lblMesasCerradas.Name = "lblMesasCerradas";
            this.lblMesasCerradas.Size = new System.Drawing.Size(228, 32);
            this.lblMesasCerradas.TabIndex = 18;
            this.lblMesasCerradas.Tag = "360";
            this.lblMesasCerradas.Text = "Mesas cerradas";
            // 
            // dataGridViewMesasCerradas
            // 
            this.dataGridViewMesasCerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesasCerradas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMesasCerradas.Location = new System.Drawing.Point(47, 80);
            this.dataGridViewMesasCerradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMesasCerradas.MultiSelect = false;
            this.dataGridViewMesasCerradas.Name = "dataGridViewMesasCerradas";
            this.dataGridViewMesasCerradas.RowHeadersVisible = false;
            this.dataGridViewMesasCerradas.RowHeadersWidth = 51;
            this.dataGridViewMesasCerradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMesasCerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesasCerradas.Size = new System.Drawing.Size(947, 369);
            this.dataGridViewMesasCerradas.TabIndex = 17;
            this.dataGridViewMesasCerradas.Tag = "361";
            // 
            // FormGenerarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 619);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.lblMesasCerradas);
            this.Controls.Add(this.dataGridViewMesasCerradas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGenerarFacturas";
            this.Tag = "362";
            this.Text = "FormGenerarFacturas";
            this.Load += new System.EventHandler(this.FormGenerarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesasCerradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Label lblMesasCerradas;
        private System.Windows.Forms.DataGridView dataGridViewMesasCerradas;
    }
}