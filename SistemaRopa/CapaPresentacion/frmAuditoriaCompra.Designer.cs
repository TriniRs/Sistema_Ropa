﻿namespace CapaPresentacion
{
    partial class frmAuditoriaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.menuVerDetalleAuditoriaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdAuditoriaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoUsuarioAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersonaUsuarioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoUsuarioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoUsuarioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLista.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(1374, 12);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDocumento.TabIndex = 106;
            this.textBoxNumeroDocumento.Visible = false;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Image = global::CapaPresentacion.Properties.Resources.Actualizar2;
            this.buttonActualizar.Location = new System.Drawing.Point(1248, 30);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(95, 30);
            this.buttonActualizar.TabIndex = 5;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.labelSubTitulo.Font = new System.Drawing.Font("Bodoni MT Condensed", 45F);
            this.labelSubTitulo.Location = new System.Drawing.Point(7, 6);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(390, 71);
            this.labelSubTitulo.TabIndex = 50;
            this.labelSubTitulo.Text = "Auditoria de compras";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.ItemHeight = 19;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(725, 32);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(174, 27);
            this.comboBoxBusqueda.TabIndex = 1;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(650, 36);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(69, 19);
            this.labelBuscarPor.TabIndex = 41;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.BackColor = System.Drawing.Color.Blue;
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpiar.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiar.Location = new System.Drawing.Point(1167, 30);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(905, 32);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(175, 27);
            this.textBoxBusqueda.TabIndex = 2;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(1268, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 105;
            this.textBoxId.Visible = false;
            // 
            // panelLista
            // 
            this.panelLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLista.Controls.Add(this.buttonActualizar);
            this.panelLista.Controls.Add(this.labelSubTitulo);
            this.panelLista.Controls.Add(this.comboBoxBusqueda);
            this.panelLista.Controls.Add(this.labelBuscarPor);
            this.panelLista.Controls.Add(this.buttonLimpiar);
            this.panelLista.Controls.Add(this.textBoxBusqueda);
            this.panelLista.Controls.Add(this.buttonBuscar);
            this.panelLista.Location = new System.Drawing.Point(12, 43);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(1346, 80);
            this.panelLista.TabIndex = 103;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(1086, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // menuVerDetalleAuditoriaCompra
            // 
            this.menuVerDetalleAuditoriaCompra.AutoSize = false;
            this.menuVerDetalleAuditoriaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menuVerDetalleAuditoriaCompra.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.menuVerDetalleAuditoriaCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuVerDetalleAuditoriaCompra.Name = "menuVerDetalleAuditoriaCompra";
            this.menuVerDetalleAuditoriaCompra.Size = new System.Drawing.Size(88, 30);
            this.menuVerDetalleAuditoriaCompra.Text = "Ver detalle";
            this.menuVerDetalleAuditoriaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVerDetalleAuditoriaCompra.Click += new System.EventHandler(this.menuVerDetalleAuditoriaCompra_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerDetalleAuditoriaCompra});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1370, 34);
            this.menu.TabIndex = 102;
            this.menu.Text = "menuStrip1";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonSeleccionar,
            this.IdAuditoriaCompra,
            this.IdUsuarioAuditoria,
            this.IdPersonaUsuarioAuditoria,
            this.NombreCompletoUsuarioAuditoria,
            this.DocumentoUsuarioAuditoria,
            this.DescripcionAuditoria,
            this.FechaAuditoria,
            this.IdCompra,
            this.IdUsuarioCompra,
            this.IdPersonaUsuarioCompra,
            this.NombreCompletoUsuarioCompra,
            this.DocumentoUsuarioCompra,
            this.IdProveedor,
            this.RazonSocial,
            this.CUIT,
            this.CorreoProveedor,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.FechaRegistro});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(12, 129);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1346, 526);
            this.dataGridView.TabIndex = 104;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // IdAuditoriaCompra
            // 
            this.IdAuditoriaCompra.HeaderText = "IdAuditoriaCompra";
            this.IdAuditoriaCompra.Name = "IdAuditoriaCompra";
            this.IdAuditoriaCompra.ReadOnly = true;
            this.IdAuditoriaCompra.Visible = false;
            // 
            // IdUsuarioAuditoria
            // 
            this.IdUsuarioAuditoria.HeaderText = "IdUsuarioAuditoria";
            this.IdUsuarioAuditoria.Name = "IdUsuarioAuditoria";
            this.IdUsuarioAuditoria.ReadOnly = true;
            this.IdUsuarioAuditoria.Visible = false;
            // 
            // IdPersonaUsuarioAuditoria
            // 
            this.IdPersonaUsuarioAuditoria.HeaderText = "IdPersonaUsuarioAuditoria";
            this.IdPersonaUsuarioAuditoria.Name = "IdPersonaUsuarioAuditoria";
            this.IdPersonaUsuarioAuditoria.ReadOnly = true;
            this.IdPersonaUsuarioAuditoria.Visible = false;
            // 
            // NombreCompletoUsuarioAuditoria
            // 
            this.NombreCompletoUsuarioAuditoria.HeaderText = "Último usuario";
            this.NombreCompletoUsuarioAuditoria.Name = "NombreCompletoUsuarioAuditoria";
            this.NombreCompletoUsuarioAuditoria.ReadOnly = true;
            this.NombreCompletoUsuarioAuditoria.Width = 120;
            // 
            // DocumentoUsuarioAuditoria
            // 
            this.DocumentoUsuarioAuditoria.HeaderText = "DocumentoUsuarioAuditoria";
            this.DocumentoUsuarioAuditoria.Name = "DocumentoUsuarioAuditoria";
            this.DocumentoUsuarioAuditoria.ReadOnly = true;
            this.DocumentoUsuarioAuditoria.Visible = false;
            // 
            // DescripcionAuditoria
            // 
            this.DescripcionAuditoria.HeaderText = "Descripción";
            this.DescripcionAuditoria.Name = "DescripcionAuditoria";
            this.DescripcionAuditoria.ReadOnly = true;
            this.DescripcionAuditoria.Width = 150;
            // 
            // FechaAuditoria
            // 
            this.FechaAuditoria.HeaderText = "Fecha de auditoría";
            this.FechaAuditoria.Name = "FechaAuditoria";
            this.FechaAuditoria.ReadOnly = true;
            this.FechaAuditoria.Width = 150;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "IdCompra";
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            // 
            // IdUsuarioCompra
            // 
            this.IdUsuarioCompra.HeaderText = "IdUsuarioCompra";
            this.IdUsuarioCompra.Name = "IdUsuarioCompra";
            this.IdUsuarioCompra.ReadOnly = true;
            this.IdUsuarioCompra.Visible = false;
            // 
            // IdPersonaUsuarioCompra
            // 
            this.IdPersonaUsuarioCompra.HeaderText = "IdPersonaUsuarioCompra";
            this.IdPersonaUsuarioCompra.Name = "IdPersonaUsuarioCompra";
            this.IdPersonaUsuarioCompra.ReadOnly = true;
            this.IdPersonaUsuarioCompra.Visible = false;
            // 
            // NombreCompletoUsuarioCompra
            // 
            this.NombreCompletoUsuarioCompra.HeaderText = "Usuario registro";
            this.NombreCompletoUsuarioCompra.Name = "NombreCompletoUsuarioCompra";
            this.NombreCompletoUsuarioCompra.ReadOnly = true;
            this.NombreCompletoUsuarioCompra.Width = 120;
            // 
            // DocumentoUsuarioCompra
            // 
            this.DocumentoUsuarioCompra.HeaderText = "DocumentoUsuarioCompra";
            this.DocumentoUsuarioCompra.Name = "DocumentoUsuarioCompra";
            this.DocumentoUsuarioCompra.ReadOnly = true;
            this.DocumentoUsuarioCompra.Visible = false;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Proveedor";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 120;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Width = 120;
            // 
            // CorreoProveedor
            // 
            this.CorreoProveedor.HeaderText = "CorreoProveedor";
            this.CorreoProveedor.Name = "CorreoProveedor";
            this.CorreoProveedor.ReadOnly = true;
            this.CorreoProveedor.Visible = false;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo de documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero de documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Visible = false;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 150;
            // 
            // frmAuditoriaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmAuditoriaCompra";
            this.Text = "Auditoria compra";
            this.Load += new System.EventHandler(this.frmAuditoriaCompra_Load);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ToolStripMenuItem menuVerDetalleAuditoriaCompra;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAuditoriaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoUsuarioAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersonaUsuarioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoUsuarioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoUsuarioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}