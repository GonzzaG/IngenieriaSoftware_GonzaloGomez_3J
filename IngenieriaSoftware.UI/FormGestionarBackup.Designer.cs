namespace IngenieriaSoftware.UI
{
    partial class FormGestionarBackup
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
            this.lblSeleccioneBackUp = new System.Windows.Forms.Label();
            this.comboBoxBackUps = new System.Windows.Forms.ComboBox();
            this.btnCopiaDeSeguridad = new System.Windows.Forms.Button();
            this.btnReestablecerBackUp = new System.Windows.Forms.Button();
            this.btnEliminarBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccioneBackUp
            // 
            this.lblSeleccioneBackUp.AutoSize = true;
            this.lblSeleccioneBackUp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeleccioneBackUp.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneBackUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccioneBackUp.Location = new System.Drawing.Point(574, 313);
            this.lblSeleccioneBackUp.Name = "lblSeleccioneBackUp";
            this.lblSeleccioneBackUp.Size = new System.Drawing.Size(192, 28);
            this.lblSeleccioneBackUp.TabIndex = 4;
            this.lblSeleccioneBackUp.Tag = "1217";
            this.lblSeleccioneBackUp.Text = "Seleccione BackUp";
            // 
            // comboBoxBackUps
            // 
            this.comboBoxBackUps.BackColor = System.Drawing.Color.Teal;
            this.comboBoxBackUps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBackUps.FormattingEnabled = true;
            this.comboBoxBackUps.Location = new System.Drawing.Point(436, 356);
            this.comboBoxBackUps.Name = "comboBoxBackUps";
            this.comboBoxBackUps.Size = new System.Drawing.Size(483, 36);
            this.comboBoxBackUps.TabIndex = 5;
            this.comboBoxBackUps.Tag = "1218";
            this.comboBoxBackUps.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCopiaDeSeguridad
            // 
            this.btnCopiaDeSeguridad.BackColor = System.Drawing.Color.Teal;
            this.btnCopiaDeSeguridad.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiaDeSeguridad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopiaDeSeguridad.Location = new System.Drawing.Point(534, 109);
            this.btnCopiaDeSeguridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopiaDeSeguridad.Name = "btnCopiaDeSeguridad";
            this.btnCopiaDeSeguridad.Size = new System.Drawing.Size(271, 116);
            this.btnCopiaDeSeguridad.TabIndex = 8;
            this.btnCopiaDeSeguridad.Tag = "1216";
            this.btnCopiaDeSeguridad.Text = "Realizar Copia de seguridad";
            this.btnCopiaDeSeguridad.UseVisualStyleBackColor = false;
            this.btnCopiaDeSeguridad.Click += new System.EventHandler(this.btnCopiaDeSeguridad_Click);
            // 
            // btnReestablecerBackUp
            // 
            this.btnReestablecerBackUp.BackColor = System.Drawing.Color.Orange;
            this.btnReestablecerBackUp.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecerBackUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReestablecerBackUp.Location = new System.Drawing.Point(346, 452);
            this.btnReestablecerBackUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReestablecerBackUp.Name = "btnReestablecerBackUp";
            this.btnReestablecerBackUp.Size = new System.Drawing.Size(246, 80);
            this.btnReestablecerBackUp.TabIndex = 9;
            this.btnReestablecerBackUp.Tag = "1219";
            this.btnReestablecerBackUp.Text = "Reestablecer Back Up";
            this.btnReestablecerBackUp.UseVisualStyleBackColor = false;
            this.btnReestablecerBackUp.Click += new System.EventHandler(this.btnReestablecerBackUp_Click);
            // 
            // btnEliminarBackup
            // 
            this.btnEliminarBackup.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarBackup.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBackup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarBackup.Location = new System.Drawing.Point(742, 452);
            this.btnEliminarBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarBackup.Name = "btnEliminarBackup";
            this.btnEliminarBackup.Size = new System.Drawing.Size(246, 80);
            this.btnEliminarBackup.TabIndex = 10;
            this.btnEliminarBackup.Tag = "1220";
            this.btnEliminarBackup.Text = "Eliminar Back Up";
            this.btnEliminarBackup.UseVisualStyleBackColor = false;
            this.btnEliminarBackup.Click += new System.EventHandler(this.btnEliminarBackup_Click);
            // 
            // FormGestionarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.btnEliminarBackup);
            this.Controls.Add(this.btnReestablecerBackUp);
            this.Controls.Add(this.btnCopiaDeSeguridad);
            this.Controls.Add(this.comboBoxBackUps);
            this.Controls.Add(this.lblSeleccioneBackUp);
            this.Name = "FormGestionarBackup";
            this.Tag = "1221";
            this.Text = "FormGestionarBackup";
            this.Load += new System.EventHandler(this.FormGestionarBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccioneBackUp;
        private System.Windows.Forms.ComboBox comboBoxBackUps;
        private System.Windows.Forms.Button btnCopiaDeSeguridad;
        private System.Windows.Forms.Button btnReestablecerBackUp;
        private System.Windows.Forms.Button btnEliminarBackup;
    }
}