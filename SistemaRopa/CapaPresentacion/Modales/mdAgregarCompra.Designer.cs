﻿namespace CapaPresentacion.Modales
{
    partial class mdAgregarCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdAgregarCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSimboloTotalAPagar = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxTotalAPagar = new System.Windows.Forms.TextBox();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInformacionProducto = new System.Windows.Forms.GroupBox();
            this.textBoxSimboloPrecioVenta = new System.Windows.Forms.TextBox();
            this.textBoxSimboloPrecioCompra = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.textBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.labelPrecioCompra = new System.Windows.Forms.Label();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxIdProveedor = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.buttonBuscarProveedor = new System.Windows.Forms.Button();
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.groupBoxInformacionCompra = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelFehca = new System.Windows.Forms.Label();
            this.labelRegistrarCompra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBoxInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInformacionProveedor.SuspendLayout();
            this.groupBoxInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.textBoxSimboloTotalAPagar);
            this.panel1.Controls.Add(this.buttonRegistrar);
            this.panel1.Controls.Add(this.textBoxTotalAPagar);
            this.panel1.Controls.Add(this.labelTotalAPagar);
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.dataGridViewData);
            this.panel1.Controls.Add(this.groupBoxInformacionProducto);
            this.panel1.Controls.Add(this.groupBoxInformacionProveedor);
            this.panel1.Controls.Add(this.groupBoxInformacionCompra);
            this.panel1.Controls.Add(this.labelRegistrarCompra);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 613);
            this.panel1.TabIndex = 1;
            // 
            // textBoxSimboloTotalAPagar
            // 
            this.textBoxSimboloTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSimboloTotalAPagar.Location = new System.Drawing.Point(688, 536);
            this.textBoxSimboloTotalAPagar.Name = "textBoxSimboloTotalAPagar";
            this.textBoxSimboloTotalAPagar.ReadOnly = true;
            this.textBoxSimboloTotalAPagar.Size = new System.Drawing.Size(13, 27);
            this.textBoxSimboloTotalAPagar.TabIndex = 104;
            this.textBoxSimboloTotalAPagar.Text = "$";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(688, 569);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(129, 30);
            this.buttonRegistrar.TabIndex = 14;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxTotalAPagar
            // 
            this.textBoxTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAPagar.Location = new System.Drawing.Point(707, 536);
            this.textBoxTotalAPagar.Name = "textBoxTotalAPagar";
            this.textBoxTotalAPagar.ReadOnly = true;
            this.textBoxTotalAPagar.Size = new System.Drawing.Size(110, 27);
            this.textBoxTotalAPagar.TabIndex = 13;
            this.textBoxTotalAPagar.Text = "0";
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(684, 514);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(81, 19);
            this.labelTotalAPagar.TabIndex = 4;
            this.labelTotalAPagar.Text = "Total a pagar:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregar.Location = new System.Drawing.Point(758, 152);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(59, 76);
            this.buttonAgregar.TabIndex = 12;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.buttonEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(19, 234);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.Size = new System.Drawing.Size(663, 365);
            this.dataGridViewData.TabIndex = 5;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            this.dataGridViewData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 230;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 120;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Subtotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 120;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.HeaderText = "";
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.ReadOnly = true;
            this.buttonEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonEliminar.Width = 30;
            // 
            // groupBoxInformacionProducto
            // 
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxSimboloPrecioVenta);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxSimboloPrecioCompra);
            this.groupBoxInformacionProducto.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.labelCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxPrecioVenta);
            this.groupBoxInformacionProducto.Controls.Add(this.labelPrecioVenta);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxPrecioCompra);
            this.groupBoxInformacionProducto.Controls.Add(this.labelPrecioCompra);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxIdProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.buttonBuscarProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.labelProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxCodigoProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.label2);
            this.groupBoxInformacionProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProducto.Location = new System.Drawing.Point(19, 141);
            this.groupBoxInformacionProducto.Name = "groupBoxInformacionProducto";
            this.groupBoxInformacionProducto.Size = new System.Drawing.Size(733, 87);
            this.groupBoxInformacionProducto.TabIndex = 4;
            this.groupBoxInformacionProducto.TabStop = false;
            this.groupBoxInformacionProducto.Text = "Información del producto";
            // 
            // textBoxSimboloPrecioVenta
            // 
            this.textBoxSimboloPrecioVenta.Location = new System.Drawing.Point(519, 45);
            this.textBoxSimboloPrecioVenta.Name = "textBoxSimboloPrecioVenta";
            this.textBoxSimboloPrecioVenta.ReadOnly = true;
            this.textBoxSimboloPrecioVenta.Size = new System.Drawing.Size(13, 27);
            this.textBoxSimboloPrecioVenta.TabIndex = 103;
            this.textBoxSimboloPrecioVenta.Text = "$";
            // 
            // textBoxSimboloPrecioCompra
            // 
            this.textBoxSimboloPrecioCompra.Location = new System.Drawing.Point(413, 45);
            this.textBoxSimboloPrecioCompra.Name = "textBoxSimboloPrecioCompra";
            this.textBoxSimboloPrecioCompra.ReadOnly = true;
            this.textBoxSimboloPrecioCompra.Size = new System.Drawing.Size(13, 27);
            this.textBoxSimboloPrecioCompra.TabIndex = 102;
            this.textBoxSimboloPrecioCompra.Text = "$";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(625, 44);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownCantidad.TabIndex = 11;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownCantidad_KeyDown);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(621, 22);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(59, 19);
            this.labelCantidad.TabIndex = 23;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(538, 45);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(81, 27);
            this.textBoxPrecioVenta.TabIndex = 10;
            this.textBoxPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrecioVenta_KeyDown);
            this.textBoxPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioVenta_KeyPress);
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(515, 23);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(93, 19);
            this.labelPrecioVenta.TabIndex = 21;
            this.labelPrecioVenta.Text = "Precio de venta:";
            // 
            // textBoxPrecioCompra
            // 
            this.textBoxPrecioCompra.Location = new System.Drawing.Point(432, 45);
            this.textBoxPrecioCompra.Name = "textBoxPrecioCompra";
            this.textBoxPrecioCompra.Size = new System.Drawing.Size(81, 27);
            this.textBoxPrecioCompra.TabIndex = 9;
            this.textBoxPrecioCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrecioCompra_KeyDown);
            this.textBoxPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioCompra_KeyPress);
            // 
            // labelPrecioCompra
            // 
            this.labelPrecioCompra.AutoSize = true;
            this.labelPrecioCompra.Location = new System.Drawing.Point(409, 23);
            this.labelPrecioCompra.Name = "labelPrecioCompra";
            this.labelPrecioCompra.Size = new System.Drawing.Size(103, 19);
            this.labelPrecioCompra.TabIndex = 19;
            this.labelPrecioCompra.Text = "Precio de compra:";
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(126, 19);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(34, 27);
            this.textBoxIdProducto.TabIndex = 101;
            this.textBoxIdProducto.Visible = false;
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.BackColor = System.Drawing.Color.Blue;
            this.buttonBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarProducto.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscarProducto.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarProducto.TabIndex = 7;
            this.buttonBuscarProducto.UseVisualStyleBackColor = false;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(207, 45);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.ReadOnly = true;
            this.textBoxProducto.Size = new System.Drawing.Size(200, 27);
            this.textBoxProducto.TabIndex = 8;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(203, 22);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(59, 19);
            this.labelProducto.TabIndex = 16;
            this.labelProducto.Text = "Producto:";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCodigoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(10, 45);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(150, 27);
            this.textBoxCodigoProducto.TabIndex = 6;
            this.textBoxCodigoProducto.TextChanged += new System.EventHandler(this.textBoxCodigoProducto_TextChanged);
            this.textBoxCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoProducto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del producto:";
            // 
            // groupBoxInformacionProveedor
            // 
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxCorreo);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxIdProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxRazonSocial);
            this.groupBoxInformacionProveedor.Controls.Add(this.buttonBuscarProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxCUIT);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelRazonSocial);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelCUIT);
            this.groupBoxInformacionProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProveedor.Location = new System.Drawing.Point(401, 48);
            this.groupBoxInformacionProveedor.Name = "groupBoxInformacionProveedor";
            this.groupBoxInformacionProveedor.Size = new System.Drawing.Size(416, 87);
            this.groupBoxInformacionProveedor.TabIndex = 4;
            this.groupBoxInformacionProveedor.TabStop = false;
            this.groupBoxInformacionProveedor.Text = "Información del proveedor";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(317, 15);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(42, 27);
            this.textBoxCorreo.TabIndex = 101;
            this.textBoxCorreo.Visible = false;
            // 
            // textBoxIdProveedor
            // 
            this.textBoxIdProveedor.Location = new System.Drawing.Point(365, 15);
            this.textBoxIdProveedor.Name = "textBoxIdProveedor";
            this.textBoxIdProveedor.Size = new System.Drawing.Size(42, 27);
            this.textBoxIdProveedor.TabIndex = 100;
            this.textBoxIdProveedor.Visible = false;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(207, 45);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.ReadOnly = true;
            this.textBoxRazonSocial.Size = new System.Drawing.Size(200, 27);
            this.textBoxRazonSocial.TabIndex = 5;
            // 
            // buttonBuscarProveedor
            // 
            this.buttonBuscarProveedor.BackColor = System.Drawing.Color.Blue;
            this.buttonBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProveedor.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarProveedor.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscarProveedor.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarProveedor.Name = "buttonBuscarProveedor";
            this.buttonBuscarProveedor.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarProveedor.TabIndex = 4;
            this.buttonBuscarProveedor.UseVisualStyleBackColor = false;
            this.buttonBuscarProveedor.Click += new System.EventHandler(this.buttonBuscarProveedor_Click);
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCUIT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCUIT.Location = new System.Drawing.Point(10, 45);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.Size = new System.Drawing.Size(150, 27);
            this.textBoxCUIT.TabIndex = 3;
            this.textBoxCUIT.TextChanged += new System.EventHandler(this.textBoxCUIT_TextChanged);
            this.textBoxCUIT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCUIT_KeyDown);
            this.textBoxCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCUIT_KeyPress);
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(203, 23);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(80, 19);
            this.labelRazonSocial.TabIndex = 1;
            this.labelRazonSocial.Text = "Razón social:";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(6, 23);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(33, 19);
            this.labelCUIT.TabIndex = 0;
            this.labelCUIT.Text = "CUIT";
            // 
            // groupBoxInformacionCompra
            // 
            this.groupBoxInformacionCompra.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxFecha);
            this.groupBoxInformacionCompra.Controls.Add(this.labelTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.labelFehca);
            this.groupBoxInformacionCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionCompra.Location = new System.Drawing.Point(19, 48);
            this.groupBoxInformacionCompra.Name = "groupBoxInformacionCompra";
            this.groupBoxInformacionCompra.Size = new System.Drawing.Size(376, 87);
            this.groupBoxInformacionCompra.TabIndex = 1;
            this.groupBoxInformacionCompra.TabStop = false;
            this.groupBoxInformacionCompra.Text = "Información de la compra";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(166, 45);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(200, 27);
            this.comboBoxTipoDocumento.TabIndex = 2;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(10, 45);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 27);
            this.textBoxFecha.TabIndex = 1;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(162, 23);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(109, 19);
            this.labelTipoDocumento.TabIndex = 1;
            this.labelTipoDocumento.Text = "Tipo de documento:";
            // 
            // labelFehca
            // 
            this.labelFehca.AutoSize = true;
            this.labelFehca.Location = new System.Drawing.Point(6, 23);
            this.labelFehca.Name = "labelFehca";
            this.labelFehca.Size = new System.Drawing.Size(44, 19);
            this.labelFehca.TabIndex = 0;
            this.labelFehca.Text = "Fecha:";
            // 
            // labelRegistrarCompra
            // 
            this.labelRegistrarCompra.AutoSize = true;
            this.labelRegistrarCompra.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F);
            this.labelRegistrarCompra.Location = new System.Drawing.Point(13, 12);
            this.labelRegistrarCompra.Name = "labelRegistrarCompra";
            this.labelRegistrarCompra.Size = new System.Drawing.Size(142, 32);
            this.labelRegistrarCompra.TabIndex = 0;
            this.labelRegistrarCompra.Text = "Registrar compra";
            // 
            // mdAgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(859, 636);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(875, 675);
            this.MinimumSize = new System.Drawing.Size(875, 675);
            this.Name = "mdAgregarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar compra";
            this.Load += new System.EventHandler(this.mdDetalleCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBoxInformacionProducto.ResumeLayout(false);
            this.groupBoxInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxInformacionProveedor.ResumeLayout(false);
            this.groupBoxInformacionProveedor.PerformLayout();
            this.groupBoxInformacionCompra.ResumeLayout(false);
            this.groupBoxInformacionCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxTotalAPagar;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.GroupBox groupBoxInformacionProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.TextBox textBoxPrecioCompra;
        private System.Windows.Forms.Label labelPrecioCompra;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxInformacionProveedor;
        private System.Windows.Forms.TextBox textBoxIdProveedor;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Button buttonBuscarProveedor;
        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.GroupBox groupBoxInformacionCompra;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelFehca;
        private System.Windows.Forms.Label labelRegistrarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEliminar;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxSimboloPrecioCompra;
        private System.Windows.Forms.TextBox textBoxSimboloTotalAPagar;
        private System.Windows.Forms.TextBox textBoxSimboloPrecioVenta;
    }
}