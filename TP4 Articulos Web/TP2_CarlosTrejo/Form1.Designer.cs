namespace TP2_CarlosTrejo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.ptbxArticulos = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDetalleart = new FontAwesome.Sharp.IconButton();
            this.btnEliminar2 = new FontAwesome.Sharp.IconButton();
            this.btnModificar2 = new FontAwesome.Sharp.IconButton();
            this.btnAgregar2 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMin = new FontAwesome.Sharp.IconButton();
            this.iconButtonMax = new FontAwesome.Sharp.IconButton();
            this.lblTitFormularioHijo = new System.Windows.Forms.Label();
            this.iconoFormHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxArticulos)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormHijoActual)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(28, 28);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(269, 447);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseClick);
            // 
            // ptbxArticulos
            // 
            this.ptbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ptbxArticulos.Location = new System.Drawing.Point(330, 28);
            this.ptbxArticulos.Name = "ptbxArticulos";
            this.ptbxArticulos.Size = new System.Drawing.Size(422, 506);
            this.ptbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxArticulos.TabIndex = 1;
            this.ptbxArticulos.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBusqueda.Location = new System.Drawing.Point(28, 514);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(269, 20);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(57, 547);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(205, 13);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Ingrese Nombre o Descripcion del Articulo";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnDetalleart);
            this.panelMenu.Controls.Add(this.btnEliminar2);
            this.panelMenu.Controls.Add(this.btnModificar2);
            this.panelMenu.Controls.Add(this.btnAgregar2);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 676);
            this.panelMenu.TabIndex = 8;
            // 
            // btnDetalleart
            // 
            this.btnDetalleart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetalleart.FlatAppearance.BorderSize = 0;
            this.btnDetalleart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleart.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDetalleart.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDetalleart.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnDetalleart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDetalleart.IconSize = 32;
            this.btnDetalleart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleart.Location = new System.Drawing.Point(0, 410);
            this.btnDetalleart.Name = "btnDetalleart";
            this.btnDetalleart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDetalleart.Rotation = 0D;
            this.btnDetalleart.Size = new System.Drawing.Size(220, 90);
            this.btnDetalleart.TabIndex = 3;
            this.btnDetalleart.Text = "Mostrar Detalle de Articulo";
            this.btnDetalleart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalleart.UseVisualStyleBackColor = true;
            this.btnDetalleart.Click += new System.EventHandler(this.btnDetalleart_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar2.FlatAppearance.BorderSize = 0;
            this.btnEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminar2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar2.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.btnEliminar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar2.IconSize = 32;
            this.btnEliminar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar2.Location = new System.Drawing.Point(0, 320);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEliminar2.Rotation = 0D;
            this.btnEliminar2.Size = new System.Drawing.Size(220, 90);
            this.btnEliminar2.TabIndex = 2;
            this.btnEliminar2.Text = "Eliminar Articulo";
            this.btnEliminar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar2.FlatAppearance.BorderSize = 0;
            this.btnModificar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModificar2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar2.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnModificar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificar2.IconSize = 32;
            this.btnModificar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar2.Location = new System.Drawing.Point(0, 230);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnModificar2.Rotation = 0D;
            this.btnModificar2.Size = new System.Drawing.Size(220, 90);
            this.btnModificar2.TabIndex = 1;
            this.btnModificar2.Text = "Modificar Articulo";
            this.btnModificar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar2.UseVisualStyleBackColor = true;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar2.FlatAppearance.BorderSize = 0;
            this.btnAgregar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar2.IconSize = 32;
            this.btnAgregar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar2.Location = new System.Drawing.Point(0, 140);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgregar2.Rotation = 0D;
            this.btnAgregar2.Size = new System.Drawing.Size(220, 90);
            this.btnAgregar2.TabIndex = 0;
            this.btnAgregar2.Text = "Agregar Articulo";
            this.btnAgregar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(21, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(185, 125);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitulo.Controls.Add(this.iconButtonClose);
            this.panelTitulo.Controls.Add(this.iconButtonMin);
            this.panelTitulo.Controls.Add(this.iconButtonMax);
            this.panelTitulo.Controls.Add(this.lblTitFormularioHijo);
            this.panelTitulo.Controls.Add(this.iconoFormHijoActual);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(777, 75);
            this.panelTitulo.TabIndex = 9;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonClose.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClose.IconSize = 32;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(703, 16);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonClose.Rotation = 0D;
            this.iconButtonClose.Size = new System.Drawing.Size(62, 40);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonMin
            // 
            this.iconButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMin.FlatAppearance.BorderSize = 0;
            this.iconButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMin.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMin.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMin.IconSize = 32;
            this.iconButtonMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMin.Location = new System.Drawing.Point(571, 16);
            this.iconButtonMin.Name = "iconButtonMin";
            this.iconButtonMin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMin.Rotation = 0D;
            this.iconButtonMin.Size = new System.Drawing.Size(62, 40);
            this.iconButtonMin.TabIndex = 6;
            this.iconButtonMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMin.UseVisualStyleBackColor = true;
            this.iconButtonMin.Click += new System.EventHandler(this.iconButtonMin_Click);
            // 
            // iconButtonMax
            // 
            this.iconButtonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMax.FlatAppearance.BorderSize = 0;
            this.iconButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMax.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconButtonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMax.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMax.IconSize = 32;
            this.iconButtonMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMax.Location = new System.Drawing.Point(639, 16);
            this.iconButtonMax.Name = "iconButtonMax";
            this.iconButtonMax.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMax.Rotation = 0D;
            this.iconButtonMax.Size = new System.Drawing.Size(62, 40);
            this.iconButtonMax.TabIndex = 5;
            this.iconButtonMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMax.UseVisualStyleBackColor = true;
            this.iconButtonMax.Click += new System.EventHandler(this.iconButtonMax_Click);
            // 
            // lblTitFormularioHijo
            // 
            this.lblTitFormularioHijo.AutoSize = true;
            this.lblTitFormularioHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitFormularioHijo.Location = new System.Drawing.Point(57, 27);
            this.lblTitFormularioHijo.Name = "lblTitFormularioHijo";
            this.lblTitFormularioHijo.Size = new System.Drawing.Size(32, 13);
            this.lblTitFormularioHijo.TabIndex = 1;
            this.lblTitFormularioHijo.Text = "Inicio";
            // 
            // iconoFormHijoActual
            // 
            this.iconoFormHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconoFormHijoActual.ForeColor = System.Drawing.Color.Violet;
            this.iconoFormHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconoFormHijoActual.IconColor = System.Drawing.Color.Violet;
            this.iconoFormHijoActual.IconSize = 44;
            this.iconoFormHijoActual.Location = new System.Drawing.Point(6, 12);
            this.iconoFormHijoActual.Name = "iconoFormHijoActual";
            this.iconoFormHijoActual.Size = new System.Drawing.Size(44, 44);
            this.iconoFormHijoActual.TabIndex = 0;
            this.iconoFormHijoActual.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(777, 9);
            this.panelShadow.TabIndex = 10;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Controls.Add(this.ptbxArticulos);
            this.panelEscritorio.Controls.Add(this.dgvArticulos);
            this.panelEscritorio.Controls.Add(this.txtBusqueda);
            this.panelEscritorio.Controls.Add(this.lblFiltro);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 84);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(777, 592);
            this.panelEscritorio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(997, 676);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1013, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa de Gestion de Articulos ¡BIENVENIDO!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxArticulos)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormHijoActual)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox ptbxArticulos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDetalleart;
        private FontAwesome.Sharp.IconButton btnEliminar2;
        private FontAwesome.Sharp.IconButton btnModificar2;
        private FontAwesome.Sharp.IconButton btnAgregar2;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconoFormHijoActual;
        private System.Windows.Forms.Label lblTitFormularioHijo;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton iconButtonMax;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonMin;
    }
}

