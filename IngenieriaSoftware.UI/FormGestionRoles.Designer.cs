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
            this.btnAsignarPermiso.Location = new System.Drawing.Point(886, 479);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(222, 59);
            this.btnAsignarPermiso.TabIndex = 29;
            this.btnAsignarPermiso.Tag = "826";
            this.btnAsignarPermiso.Text = "Asignar";
            this.btnAsignarPermiso.UseVisualStyleBackColor = false;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblTodosLosRoles
            // 
            this.lblTodosLosRoles.AutoSize = true;
            this.lblTodosLosRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTodosLosRoles.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTodosLosRoles.Location = new System.Drawing.Point(1024, 112);
            this.lblTodosLosRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosRoles.Name = "lblTodosLosRoles";
            this.lblTodosLosRoles.Size = new System.Drawing.Size(114, 21);
            this.lblTodosLosRoles.TabIndex = 27;
            this.lblTodosLosRoles.Tag = "821";
            this.lblTodosLosRoles.Text = "Todos los roles";
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.BackColor = System.Drawing.Color.Teal;
            this.btnCrearRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearRol.Location = new System.Drawing.Point(57, 161);
            this.btnCrearRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(197, 70);
            this.btnCrearRol.TabIndex = 25;
            this.btnCrearRol.Tag = "814";
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = false;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreNuevoRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNuevoRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(55, 85);
            this.lblNombreNuevoRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(163, 21);
            this.lblNombreNuevoRol.TabIndex = 24;
            this.lblNombreNuevoRol.Tag = "812";
            this.lblNombreNuevoRol.Text = "Nombre del nuevo rol";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTodosLosPermisos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosPermisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(719, 114);
            this.lblTodosLosPermisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(144, 21);
            this.lblTodosLosPermisos.TabIndex = 23;
            this.lblTodosLosPermisos.Tag = "823";
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.BackColor = System.Drawing.Color.Teal;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(57, 112);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(198, 26);
            this.txtNombreRol.TabIndex = 30;
            this.txtNombreRol.Tag = "813";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.BackColor = System.Drawing.Color.Teal;
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(346, 114);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(223, 28);
            this.comboBoxRoles.TabIndex = 34;
            this.comboBoxRoles.Tag = "818";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            this.comboBoxRoles.TextChanged += new System.EventHandler(this.comboBoxRoles_TextChanged);
            // 
            // lblNombreDelRol
            // 
            this.lblNombreDelRol.AutoSize = true;
            this.lblNombreDelRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreDelRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreDelRol.Location = new System.Drawing.Point(347, 80);
            this.lblNombreDelRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDelRol.Name = "lblNombreDelRol";
            this.lblNombreDelRol.Size = new System.Drawing.Size(116, 21);
            this.lblNombreDelRol.TabIndex = 35;
            this.lblNombreDelRol.Tag = "816";
            this.lblNombreDelRol.Text = "Nombre del rol";
            // 
            // lblNuevoRol
            // 
            this.lblNuevoRol.AutoSize = true;
            this.lblNuevoRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoRol.Location = new System.Drawing.Point(52, 23);
            this.lblNuevoRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoRol.Name = "lblNuevoRol";
            this.lblNuevoRol.Size = new System.Drawing.Size(123, 26);
            this.lblNuevoRol.TabIndex = 36;
            this.lblNuevoRol.Tag = "811";
            this.lblNuevoRol.Text = "Nuevo Rol";
            // 
            // lblAsignarRol
            // 
            this.lblAsignarRol.AutoSize = true;
            this.lblAsignarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAsignarRol.Location = new System.Drawing.Point(348, 23);
            this.lblAsignarRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignarRol.Name = "lblAsignarRol";
            this.lblAsignarRol.Size = new System.Drawing.Size(136, 26);
            this.lblAsignarRol.TabIndex = 37;
            this.lblAsignarRol.Tag = "815";
            this.lblAsignarRol.Text = "Asignar Rol";
            // 
            // txtPermisoSeleccionado
            // 
            this.txtPermisoSeleccionado.BackColor = System.Drawing.Color.Teal;
            this.txtPermisoSeleccionado.Enabled = false;
            this.txtPermisoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisoSeleccionado.Location = new System.Drawing.Point(885, 447);
            this.txtPermisoSeleccionado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPermisoSeleccionado.Name = "txtPermisoSeleccionado";
            this.txtPermisoSeleccionado.Size = new System.Drawing.Size(223, 28);
            this.txtPermisoSeleccionado.TabIndex = 38;
            this.txtPermisoSeleccionado.Tag = "825";
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarRol.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarRol.Location = new System.Drawing.Point(461, 73);
            this.btnEliminarRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(108, 36);
            this.btnEliminarRol.TabIndex = 41;
            this.btnEliminarRol.Tag = "";
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.Teal;
            this.btnDesasignar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesasignar.Location = new System.Drawing.Point(347, 479);
            this.btnDesasignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(222, 33);
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
            this.treeViewPermisoRol.Location = new System.Drawing.Point(347, 151);
            this.treeViewPermisoRol.Name = "treeViewPermisoRol";
            this.treeViewPermisoRol.Size = new System.Drawing.Size(224, 305);
            this.treeViewPermisoRol.TabIndex = 47;
            this.treeViewPermisoRol.Tag = "804";
            // 
            // dataGridViewRoles
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRoles.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoles.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoles.EnableHeadersVisualStyles = false;
            this.dataGridViewRoles.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.Location = new System.Drawing.Point(1028, 161);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewRoles.RowHeadersVisible = false;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRoles.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(225, 275);
            this.dataGridViewRoles.TabIndex = 50;
            this.dataGridViewRoles.Tag = "166";
            this.dataGridViewRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_RowEnter_1);
            // 
            // dataGridViewPermisos
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPermisos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPermisos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewPermisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPermisos.EnableHeadersVisualStyles = false;
            this.dataGridViewPermisos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(728, 161);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewPermisos.RowHeadersVisible = false;
            this.dataGridViewPermisos.RowHeadersWidth = 51;
            this.dataGridViewPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPermisos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(222, 275);
            this.dataGridViewPermisos.TabIndex = 51;
            this.dataGridViewPermisos.Tag = "166";
            this.dataGridViewPermisos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_RowEnter_1);
            // 
            // FormGestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1322, 898);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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