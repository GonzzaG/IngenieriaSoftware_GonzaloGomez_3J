namespace IngenieriaSoftware.UI
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
            this.btnComandaEntregada = new System.Windows.Forms.Button();
            this.lblComandasAEntregar = new System.Windows.Forms.Label();
            this.dataGridViewComandasAEntregar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasAEntregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComandaEntregada
            // 
            this.btnComandaEntregada.Location = new System.Drawing.Point(32, 385);
            this.btnComandaEntregada.Margin = new System.Windows.Forms.Padding(2);
            this.btnComandaEntregada.Name = "btnComandaEntregada";
            this.btnComandaEntregada.Size = new System.Drawing.Size(162, 45);
            this.btnComandaEntregada.TabIndex = 31;
            this.btnComandaEntregada.Tag = "74";
            this.btnComandaEntregada.Text = "Marcar como entregado";
            this.btnComandaEntregada.UseVisualStyleBackColor = true;
            this.btnComandaEntregada.Click += new System.EventHandler(this.btnComandaEntregada_Click);
            // 
            // lblComandasAEntregar
            // 
            this.lblComandasAEntregar.AutoSize = true;
            this.lblComandasAEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandasAEntregar.Location = new System.Drawing.Point(27, 16);
            this.lblComandasAEntregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComandasAEntregar.Name = "lblComandasAEntregar";
            this.lblComandasAEntregar.Size = new System.Drawing.Size(275, 26);
            this.lblComandasAEntregar.TabIndex = 30;
            this.lblComandasAEntregar.Tag = "70";
            this.lblComandasAEntregar.Text = "Comandas para entregar";
            // 
            // dataGridViewComandasAEntregar
            // 
            this.dataGridViewComandasAEntregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandasAEntregar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandasAEntregar.Location = new System.Drawing.Point(32, 62);
            this.dataGridViewComandasAEntregar.MultiSelect = false;
            this.dataGridViewComandasAEntregar.Name = "dataGridViewComandasAEntregar";
            this.dataGridViewComandasAEntregar.RowHeadersVisible = false;
            this.dataGridViewComandasAEntregar.RowHeadersWidth = 51;
            this.dataGridViewComandasAEntregar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandasAEntregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandasAEntregar.Size = new System.Drawing.Size(566, 297);
            this.dataGridViewComandasAEntregar.TabIndex = 29;
            this.dataGridViewComandasAEntregar.Tag = "71";
            // 
            // FormComandasAEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComandaEntregada);
            this.Controls.Add(this.lblComandasAEntregar);
            this.Controls.Add(this.dataGridViewComandasAEntregar);
            this.Name = "FormComandasAEntregar";
            this.Text = "Comandas a entregar";
            this.Load += new System.EventHandler(this.FormComandasAEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasAEntregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandaEntregada;
        private System.Windows.Forms.Label lblComandasAEntregar;
        private System.Windows.Forms.DataGridView dataGridViewComandasAEntregar;
    }
}