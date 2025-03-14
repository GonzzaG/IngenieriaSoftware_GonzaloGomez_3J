namespace IngenieriaSoftware.UI
{
    partial class FormGestionRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.lblTodosLosRoles = new System.Windows.Forms.Label();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.lblNombreNuevoRol = new System.Windows.Forms.Label();
            this.lblTodosLosPermisos = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.lblNombreDelRol = new System.Windows.Forms.Label();
            this.lblNuevoRol = new System.Windows.Forms.Label();
            this.lblAsignarRol = new System.Windows.Forms.Label();
            this.txtPermisoSeleccionado = new System.Windows.Forms.TextBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.usuarioBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeViewPermisoRol = new System.Windows.Forms.TreeView();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.BackColor = System.Drawing.Color.Teal;
            this.btnAsignarPermiso.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermiso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsignarPermiso.Location = new System.Drawing.Point(972, 590);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(296, 73);
            this.btnAsignarPermiso.TabIndex = 29;
            this.btnAsignarPermiso.Tag = "826";
            this.btnAsignarPermiso.Text = "Asignar";
            this.btnAsignarPermiso.UseVisualStyleBackColor = false;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblTodosLosRoles
            // 
            this.lblTodosLosRoles.AutoSize = true;
            this.lblTodosLosRoles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTodosLosRoles.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTodosLosRoles.Location = new System.Drawing.Point(75, 396);
            this.lblTodosLosRoles.Name = "lblTodosLosRoles";
            this.lblTodosLosRoles.Size = new System.Drawing.Size(143, 28);
            this.lblTodosLosRoles.TabIndex = 27;
            this.lblTodosLosRoles.Tag = "821";
            this.lblTodosLosRoles.Text = "Todos los roles";
            this.lblTodosLosRoles.Visible = false;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.BackColor = System.Drawing.Color.Teal;
            this.btnCrearRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearRol.Location = new System.Drawing.Point(76, 198);
            this.btnCrearRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(263, 86);
            this.btnCrearRol.TabIndex = 25;
            this.btnCrearRol.Tag = "814";
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = false;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombreNuevoRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNuevoRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(73, 105);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(205, 28);
            this.lblNombreNuevoRol.TabIndex = 24;
            this.lblNombreNuevoRol.Tag = "812";
            this.lblNombreNuevoRol.Text = "Nombre del nuevo rol";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTodosLosPermisos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosPermisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(959, 140);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(180, 28);
            this.lblTodosLosPermisos.TabIndex = 23;
            this.lblTodosLosPermisos.Tag = "823";
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.BackColor = System.Drawing.Color.Teal;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(76, 138);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(263, 30);
            this.txtNombreRol.TabIndex = 30;
            this.txtNombreRol.Tag = "813";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.BackColor = System.Drawing.Color.Teal;
            this.comboBoxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(461, 140);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(296, 33);
            this.comboBoxRoles.TabIndex = 34;
            this.comboBoxRoles.Tag = "818";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            this.comboBoxRoles.TextChanged += new System.EventHandler(this.comboBoxRoles_TextChanged);
            // 
            // lblNombreDelRol
            // 
            this.lblNombreDelRol.AutoSize = true;
            this.lblNombreDelRol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombreDelRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreDelRol.Location = new System.Drawing.Point(463, 98);
            this.lblNombreDelRol.Name = "lblNombreDelRol";
            this.lblNombreDelRol.Size = new System.Drawing.Size(146, 28);
            this.lblNombreDelRol.TabIndex = 35;
            this.lblNombreDelRol.Tag = "816";
            this.lblNombreDelRol.Text = "Nombre del rol";
            // 
            // lblNuevoRol
            // 
            this.lblNuevoRol.AutoSize = true;
            this.lblNuevoRol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoRol.Location = new System.Drawing.Point(69, 28);
            this.lblNuevoRol.Name = "lblNuevoRol";
            this.lblNuevoRol.Size = new System.Drawing.Size(155, 32);
            this.lblNuevoRol.TabIndex = 36;
            this.lblNuevoRol.Tag = "811";
            this.lblNuevoRol.Text = "Nuevo Rol";
            // 
            // lblAsignarRol
            // 
            this.lblAsignarRol.AutoSize = true;
            this.lblAsignarRol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAsignarRol.Location = new System.Drawing.Point(464, 28);
            this.lblAsignarRol.Name = "lblAsignarRol";
            this.lblAsignarRol.Size = new System.Drawing.Size(172, 32);
            this.lblAsignarRol.TabIndex = 37;
            this.lblAsignarRol.Tag = "815";
            this.lblAsignarRol.Text = "Asignar Rol";
            // 
            // txtPermisoSeleccionado
            // 
            this.txtPermisoSeleccionado.BackColor = System.Drawing.Color.Teal;
            this.txtPermisoSeleccionado.Enabled = false;
            this.txtPermisoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisoSeleccionado.Location = new System.Drawing.Point(971, 550);
            this.txtPermisoSeleccionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPermisoSeleccionado.Name = "txtPermisoSeleccionado";
            this.txtPermisoSeleccionado.Size = new System.Drawing.Size(296, 34);
            this.txtPermisoSeleccionado.TabIndex = 38;
            this.txtPermisoSeleccionado.Tag = "825";
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarRol.Location = new System.Drawing.Point(615, 90);
            this.btnEliminarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(144, 44);
            this.btnEliminarRol.TabIndex = 41;
            this.btnEliminarRol.Tag = "817";
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.Teal;
            this.btnDesasignar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesasignar.Location = new System.Drawing.Point(463, 590);
            this.btnDesasignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(296, 41);
            this.btnDesasignar.TabIndex = 42;
            this.btnDesasignar.Tag = "820";
            this.btnDesasignar.Text = "Desasignar rol o permiso";
            this.btnDesasignar.UseVisualStyleBackColor = false;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // usuarioBLLBindingSource
            // 
            this.usuarioBLLBindingSource.DataSource = typeof(IngenieriaSoftware.BLL.UsuarioBLL);
            // 
            // treeViewPermisoRol
            // 
            this.treeViewPermisoRol.BackColor = System.Drawing.Color.Teal;
            this.treeViewPermisoRol.Location = new System.Drawing.Point(463, 186);
            this.treeViewPermisoRol.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisoRol.Name = "treeViewPermisoRol";
            this.treeViewPermisoRol.Size = new System.Drawing.Size(298, 374);
            this.treeViewPermisoRol.TabIndex = 47;
            this.treeViewPermisoRol.Tag = "804";
            // 
            // dataGridViewRoles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRoles.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoles.EnableHeadersVisualStyles = false;
            this.dataGridViewRoles.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.Location = new System.Drawing.Point(78, 453);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoles.RowHeadersVisible = false;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(300, 339);
            this.dataGridViewRoles.TabIndex = 50;
            this.dataGridViewRoles.Tag = "166";
            this.dataGridViewRoles.Visible = false;
            this.dataGridViewRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_RowEnter_1);
            // 
            // dataGridViewPermisos
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPermisos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPermisos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPermisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPermisos.EnableHeadersVisualStyles = false;
            this.dataGridViewPermisos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(971, 198);
            this.dataGridViewPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPermisos.RowHeadersVisible = false;
            this.dataGridViewPermisos.RowHeadersWidth = 51;
            this.dataGridViewPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(296, 339);
            this.dataGridViewPermisos.TabIndex = 51;
            this.dataGridViewPermisos.Tag = "166";
            this.dataGridViewPermisos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_RowEnter_1);
            // 
            // FormGestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1763, 882);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.treeViewPermisoRol);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.txtPermisoSeleccionado);
            this.Controls.Add(this.lblAsignarRol);
            this.Controls.Add(this.lblNuevoRol);
            this.Controls.Add(this.lblNombreDelRol);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.lblTodosLosRoles);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.lblNombreNuevoRol);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGestionRoles";
            this.Tag = "827";
            this.Load += new System.EventHandler(this.FormGestionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Label lblTodosLosRoles;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Label lblNombreNuevoRol;
        private System.Windows.Forms.Label lblTodosLosPermisos;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.BindingSource usuarioBLLBindingSource;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label lblNombreDelRol;
        private System.Windows.Forms.Label lblNuevoRol;
        private System.Windows.Forms.Label lblAsignarRol;
        private System.Windows.Forms.TextBox txtPermisoSeleccionado;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.TreeView treeViewPermisoRol;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
    }
}