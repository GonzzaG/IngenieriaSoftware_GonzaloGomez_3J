namespace IngenieriaSoftware.UI
{
    partial class FormMDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasCocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasAEntregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTraduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutgestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.lblIdiomaActual = new System.Windows.Forms.Label();
            this.toolTipNotificacion = new System.Windows.Forms.ToolTip(this.components);
            this.facturasSolicitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesasToolStripMenuItem,
            this.cobrosToolStripMenuItem,
            this.comandasToolStripMenuItem,
            this.gestionUsuariosToolStripMenuItem,
            this.gestionIdiomasToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.LogOutgestionUsuariosToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMDI.Size = new System.Drawing.Size(1209, 24);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Tag = "1";
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMesasToolStripMenuItem,
            this.aBMMesasToolStripMenuItem});
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mesasToolStripMenuItem.Tag = "3";
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // gestionarMesasToolStripMenuItem
            // 
            this.gestionarMesasToolStripMenuItem.Name = "gestionarMesasToolStripMenuItem";
            this.gestionarMesasToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gestionarMesasToolStripMenuItem.Tag = "75";
            this.gestionarMesasToolStripMenuItem.Text = "Gestionar Mesas";
            this.gestionarMesasToolStripMenuItem.Click += new System.EventHandler(this.gestionarMesasToolStripMenuItem_Click);
            // 
            // aBMMesasToolStripMenuItem
            // 
            this.aBMMesasToolStripMenuItem.Name = "aBMMesasToolStripMenuItem";
            this.aBMMesasToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aBMMesasToolStripMenuItem.Tag = "76";
            this.aBMMesasToolStripMenuItem.Text = "ABM Mesas";
            this.aBMMesasToolStripMenuItem.Click += new System.EventHandler(this.aBMMesasToolStripMenuItem_Click);
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasSolicitToolStripMenuItem,
            this.fToolStripMenuItem});
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cobrosToolStripMenuItem.Tag = "4";
            this.cobrosToolStripMenuItem.Text = "Cobros";
            // 
            // comandasToolStripMenuItem
            // 
            this.comandasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandasCocinaToolStripMenuItem,
            this.comandasAEntregarToolStripMenuItem});
            this.comandasToolStripMenuItem.Name = "comandasToolStripMenuItem";
            this.comandasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.comandasToolStripMenuItem.Tag = "5";
            this.comandasToolStripMenuItem.Text = "Comandas";
            this.comandasToolStripMenuItem.Click += new System.EventHandler(this.comandasToolStripMenuItem_Click);
            // 
            // comandasCocinaToolStripMenuItem
            // 
            this.comandasCocinaToolStripMenuItem.Name = "comandasCocinaToolStripMenuItem";
            this.comandasCocinaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.comandasCocinaToolStripMenuItem.Text = "Comandas Cocina";
            this.comandasCocinaToolStripMenuItem.Click += new System.EventHandler(this.comandasCocinaToolStripMenuItem_Click);
            // 
            // comandasAEntregarToolStripMenuItem
            // 
            this.comandasAEntregarToolStripMenuItem.Name = "comandasAEntregarToolStripMenuItem";
            this.comandasAEntregarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.comandasAEntregarToolStripMenuItem.Text = "Comandas a entregar";
            this.comandasAEntregarToolStripMenuItem.Click += new System.EventHandler(this.comandasAEntregarToolStripMenuItem_Click);
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem});
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestionUsuariosToolStripMenuItem.Tag = "6";
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registrarUsuarioToolStripMenuItem.Tag = "7";
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarUsuarioToolStripMenuItem.Tag = "8";
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.asignarPermisosToolStripMenuItem.Tag = "9";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem_Click);
            // 
            // gestionIdiomasToolStripMenuItem
            // 
            this.gestionIdiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarEtiquetasToolStripMenuItem,
            this.agregarTraduccionToolStripMenuItem});
            this.gestionIdiomasToolStripMenuItem.Name = "gestionIdiomasToolStripMenuItem";
            this.gestionIdiomasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gestionIdiomasToolStripMenuItem.Tag = "10";
            this.gestionIdiomasToolStripMenuItem.Text = "Gestion Idiomas";
            this.gestionIdiomasToolStripMenuItem.Click += new System.EventHandler(this.gestionIdiomasToolStripMenuItem_Click);
            // 
            // actualizarEtiquetasToolStripMenuItem
            // 
            this.actualizarEtiquetasToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.actualizarEtiquetasToolStripMenuItem.Name = "actualizarEtiquetasToolStripMenuItem";
            this.actualizarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.actualizarEtiquetasToolStripMenuItem.Tag = "11";
            this.actualizarEtiquetasToolStripMenuItem.Text = "Actualizar Etiquetas";
            this.actualizarEtiquetasToolStripMenuItem.Click += new System.EventHandler(this.actualizarEtiquetasToolStripMenuItem_Click);
            // 
            // agregarTraduccionToolStripMenuItem
            // 
            this.agregarTraduccionToolStripMenuItem.Name = "agregarTraduccionToolStripMenuItem";
            this.agregarTraduccionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.agregarTraduccionToolStripMenuItem.Tag = "12";
            this.agregarTraduccionToolStripMenuItem.Text = "Agregar Traduccion";
            this.agregarTraduccionToolStripMenuItem.Click += new System.EventHandler(this.agregarTraduccionToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Tag = "13";
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // LogOutgestionUsuariosToolStripMenuItem
            // 
            this.LogOutgestionUsuariosToolStripMenuItem.Name = "LogOutgestionUsuariosToolStripMenuItem";
            this.LogOutgestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.LogOutgestionUsuariosToolStripMenuItem.Tag = "14";
            this.LogOutgestionUsuariosToolStripMenuItem.Text = "Cerrar Sesion";
            this.LogOutgestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.LogOutgestionUsuariosToolStripMenuItem_Click);
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(951, 3);
            this.comboBoxIdiomas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(157, 21);
            this.comboBoxIdiomas.TabIndex = 7;
            this.comboBoxIdiomas.Tag = "62";
            this.comboBoxIdiomas.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_SelectedIndexChanged_1);
            // 
            // lblIdiomaActual
            // 
            this.lblIdiomaActual.AutoSize = true;
            this.lblIdiomaActual.Location = new System.Drawing.Point(847, 6);
            this.lblIdiomaActual.Name = "lblIdiomaActual";
            this.lblIdiomaActual.Size = new System.Drawing.Size(71, 13);
            this.lblIdiomaActual.TabIndex = 9;
            this.lblIdiomaActual.Tag = "69";
            this.lblIdiomaActual.Text = "Idioma Actual";
            // 
            // facturasSolicitToolStripMenuItem
            // 
            this.facturasSolicitToolStripMenuItem.Name = "facturasSolicitToolStripMenuItem";
            this.facturasSolicitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.facturasSolicitToolStripMenuItem.Text = "Facturas pendientes de pago";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.fToolStripMenuItem.Text = "Ver Facturas";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 638);
            this.Controls.Add(this.lblIdiomaActual);
            this.Controls.Add(this.comboBoxIdiomas);
            this.Controls.Add(this.menuStripMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Name = "FormMDI";
            this.Tag = "2";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutgestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTraduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
        private System.Windows.Forms.Label lblIdiomaActual;
        private System.Windows.Forms.ToolStripMenuItem gestionarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasCocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasAEntregarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipNotificacion;
        private System.Windows.Forms.ToolStripMenuItem facturasSolicitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
    }
}