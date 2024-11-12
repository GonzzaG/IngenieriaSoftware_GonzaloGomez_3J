namespace IngenieriaSoftware.UI
{
    partial class FormGestionarMesas
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
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            this.lblMesas = new System.Windows.Forms.Label();
            this.btnAsignarMesa = new System.Windows.Forms.Button();
            this.btnRealizarComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMesas
            // 
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMesas.Location = new System.Drawing.Point(51, 84);
            this.dataGridViewMesas.MultiSelect = false;
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            this.dataGridViewMesas.RowHeadersVisible = false;
            this.dataGridViewMesas.RowHeadersWidth = 51;
            this.dataGridViewMesas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesas.Size = new System.Drawing.Size(391, 401);
            this.dataGridViewMesas.TabIndex = 12;
            this.dataGridViewMesas.Tag = "71";
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.Location = new System.Drawing.Point(58, 38);
            this.lblMesas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(81, 26);
            this.lblMesas.TabIndex = 13;
            this.lblMesas.Tag = "70";
            this.lblMesas.Text = "Mesas";
            // 
            // btnAsignarMesa
            // 
            this.btnAsignarMesa.Location = new System.Drawing.Point(489, 124);
            this.btnAsignarMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignarMesa.Name = "btnAsignarMesa";
            this.btnAsignarMesa.Size = new System.Drawing.Size(162, 45);
            this.btnAsignarMesa.TabIndex = 14;
            this.btnAsignarMesa.Tag = "72";
            this.btnAsignarMesa.Text = "Asignar Mesa";
            this.btnAsignarMesa.UseVisualStyleBackColor = true;
            this.btnAsignarMesa.Click += new System.EventHandler(this.btnAsignarMesa_Click);
            // 
            // btnRealizarComanda
            // 
            this.btnRealizarComanda.Location = new System.Drawing.Point(489, 200);
            this.btnRealizarComanda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRealizarComanda.Name = "btnRealizarComanda";
            this.btnRealizarComanda.Size = new System.Drawing.Size(162, 45);
            this.btnRealizarComanda.TabIndex = 15;
            this.btnRealizarComanda.Tag = "74";
            this.btnRealizarComanda.Text = "Realizar Comanda";
            this.btnRealizarComanda.UseVisualStyleBackColor = true;
            this.btnRealizarComanda.Click += new System.EventHandler(this.btnRealizarComanda_Click);
            // 
            // FormGestionarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 524);
            this.Controls.Add(this.btnRealizarComanda);
            this.Controls.Add(this.btnAsignarMesa);
            this.Controls.Add(this.lblMesas);
            this.Controls.Add(this.dataGridViewMesas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGestionarMesas";
            this.Tag = "73";
            this.Text = "FormGestionarMesas";
            this.Load += new System.EventHandler(this.FormGestionarMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMesas;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Button btnAsignarMesa;
        private System.Windows.Forms.Button btnRealizarComanda;
    }
}