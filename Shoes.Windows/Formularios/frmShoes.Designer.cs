namespace Shoes.Windows.Formularios
{
    partial class frmShoes
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			panelGrilla = new Panel();
			dgvDatos = new DataGridView();
			colModel = new DataGridViewTextBoxColumn();
			colDescripcion = new DataGridViewTextBoxColumn();
			colPrice = new DataGridViewTextBoxColumn();
			colColor = new DataGridViewTextBoxColumn();
			colGenre = new DataGridViewTextBoxColumn();
			colBrand = new DataGridViewTextBoxColumn();
			colSport = new DataGridViewTextBoxColumn();
			panelToolBar = new Panel();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsbFiltrar = new ToolStripDropDownButton();
			porMarca = new ToolStripMenuItem();
			tscMarca = new ToolStripComboBox();
			porColor = new ToolStripMenuItem();
			tscColor = new ToolStripComboBox();
			porGenero = new ToolStripMenuItem();
			tscGenero = new ToolStripComboBox();
			porDeporte = new ToolStripMenuItem();
			tscDeporte = new ToolStripComboBox();
			tsbActualizar = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			tsbOrden = new ToolStripDropDownButton();
			aZToolStripMenuItem = new ToolStripMenuItem();
			zAToolStripMenuItem = new ToolStripMenuItem();
			menorPrecioToolStripMenuItem = new ToolStripMenuItem();
			mayorPrecioToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator3 = new ToolStripSeparator();
			tsbCerrar = new ToolStripButton();
			panelNavegacion = new Panel();
			btnSiguiente = new Button();
			txtCantidadRegistros = new TextBox();
			cboPaginas = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			btnUltimo = new Button();
			btnAnterior = new Button();
			btnPrimero = new Button();
			panelGrilla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			panelToolBar.SuspendLayout();
			toolStrip1.SuspendLayout();
			panelNavegacion.SuspendLayout();
			SuspendLayout();
			// 
			// panelGrilla
			// 
			panelGrilla.Controls.Add(dgvDatos);
			panelGrilla.Location = new Point(0, 115);
			panelGrilla.Margin = new Padding(6);
			panelGrilla.Name = "panelGrilla";
			panelGrilla.Size = new Size(1474, 590);
			panelGrilla.TabIndex = 14;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colModel, colDescripcion, colPrice, colColor, colGenre, colBrand, colSport });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.HighlightText;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.Margin = new Padding(6);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1474, 590);
			dgvDatos.TabIndex = 0;
			// 
			// colModel
			// 
			colModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colModel.HeaderText = "Model";
			colModel.MinimumWidth = 10;
			colModel.Name = "colModel";
			colModel.ReadOnly = true;
			// 
			// colDescripcion
			// 
			colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colDescripcion.HeaderText = "Descripcion";
			colDescripcion.MinimumWidth = 10;
			colDescripcion.Name = "colDescripcion";
			colDescripcion.ReadOnly = true;
			// 
			// colPrice
			// 
			colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colPrice.HeaderText = "Price";
			colPrice.MinimumWidth = 10;
			colPrice.Name = "colPrice";
			colPrice.ReadOnly = true;
			// 
			// colColor
			// 
			colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colColor.HeaderText = "Color";
			colColor.MinimumWidth = 10;
			colColor.Name = "colColor";
			colColor.ReadOnly = true;
			// 
			// colGenre
			// 
			colGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colGenre.HeaderText = "Genre";
			colGenre.MinimumWidth = 10;
			colGenre.Name = "colGenre";
			colGenre.ReadOnly = true;
			// 
			// colBrand
			// 
			colBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colBrand.HeaderText = "Brand";
			colBrand.MinimumWidth = 10;
			colBrand.Name = "colBrand";
			colBrand.ReadOnly = true;
			// 
			// colSport
			// 
			colSport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colSport.HeaderText = "Sport";
			colSport.MinimumWidth = 10;
			colSport.Name = "colSport";
			colSport.ReadOnly = true;
			// 
			// panelToolBar
			// 
			panelToolBar.Controls.Add(toolStrip1);
			panelToolBar.Dock = DockStyle.Top;
			panelToolBar.Location = new Point(0, 0);
			panelToolBar.Margin = new Padding(6);
			panelToolBar.Name = "panelToolBar";
			panelToolBar.Size = new Size(1474, 115);
			panelToolBar.TabIndex = 13;
			// 
			// toolStrip1
			// 
			toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbOrden, tsbActualizar, toolStripSeparator2, toolStripSeparator3, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.Size = new Size(1474, 119);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.agregar_documento;
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(117, 113);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = Properties.Resources.eliminar_documento;
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(110, 113);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbBorrar.Click += tsbBorrar_Click;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = Properties.Resources.archivo_de_edicion;
			tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
			tsbEditar.ImageTransparentColor = Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new Size(105, 113);
			tsbEditar.Text = "Editar";
			tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbEditar.Click += tsbEditar_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 119);
			// 
			// tsbFiltrar
			// 
			tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porMarca, porColor, porGenero, porDeporte });
			tsbFiltrar.Image = Properties.Resources.ajustes_deslizadores__3_;
			tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbFiltrar.ImageTransparentColor = Color.Magenta;
			tsbFiltrar.Name = "tsbFiltrar";
			tsbFiltrar.Size = new Size(123, 113);
			tsbFiltrar.Text = "Filtrar";
			tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbFiltrar.Click += tsbFiltrar_Click;
			// 
			// porMarca
			// 
			porMarca.DropDownItems.AddRange(new ToolStripItem[] { tscMarca });
			porMarca.Name = "porMarca";
			porMarca.Size = new Size(359, 54);
			porMarca.Text = "Marca";
			// 
			// tscMarca
			// 
			tscMarca.DropDownStyle = ComboBoxStyle.DropDownList;
			tscMarca.Name = "tscMarca";
			tscMarca.Size = new Size(121, 40);
			tscMarca.SelectedIndexChanged += tscMarca_SelectedIndexChanged;
			// 
			// porColor
			// 
			porColor.DropDownItems.AddRange(new ToolStripItem[] { tscColor });
			porColor.Name = "porColor";
			porColor.Size = new Size(359, 54);
			porColor.Text = "Color";
			// 
			// tscColor
			// 
			tscColor.DropDownStyle = ComboBoxStyle.DropDownList;
			tscColor.Name = "tscColor";
			tscColor.Size = new Size(121, 40);
			tscColor.SelectedIndexChanged += tscColor_SelectedIndexChanged;
			// 
			// porGenero
			// 
			porGenero.DropDownItems.AddRange(new ToolStripItem[] { tscGenero });
			porGenero.Name = "porGenero";
			porGenero.Size = new Size(359, 54);
			porGenero.Text = "Genero";
			// 
			// tscGenero
			// 
			tscGenero.Name = "tscGenero";
			tscGenero.Size = new Size(359, 40);
			tscGenero.Text = " ";
			tscGenero.SelectedIndexChanged += tscGenero_SelectedIndexChanged;
			// 
			// porDeporte
			// 
			porDeporte.DropDownItems.AddRange(new ToolStripItem[] { tscDeporte });
			porDeporte.Name = "porDeporte";
			porDeporte.Size = new Size(359, 54);
			porDeporte.Text = "Deporte";
			// 
			// tscDeporte
			// 
			tscDeporte.Name = "tscDeporte";
			tscDeporte.Size = new Size(359, 40);
			tscDeporte.Text = " ";
			tscDeporte.SelectedIndexChanged += tscDeporte_SelectedIndexChanged;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = Properties.Resources.girar_cuadrado;
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(162, 113);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbActualizar.Click += tsbActualizar_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 119);
			// 
			// tsbOrden
			// 
			tsbOrden.DropDownItems.AddRange(new ToolStripItem[] { aZToolStripMenuItem, zAToolStripMenuItem, menorPrecioToolStripMenuItem, mayorPrecioToolStripMenuItem });
			tsbOrden.Image = Properties.Resources.ordenar_alt;
			tsbOrden.ImageScaling = ToolStripItemImageScaling.None;
			tsbOrden.ImageTransparentColor = Color.Magenta;
			tsbOrden.Name = "tsbOrden";
			tsbOrden.Size = new Size(131, 113);
			tsbOrden.Text = "Orden";
			tsbOrden.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// aZToolStripMenuItem
			// 
			aZToolStripMenuItem.Name = "aZToolStripMenuItem";
			aZToolStripMenuItem.Size = new Size(359, 54);
			aZToolStripMenuItem.Text = "A-Z";
			aZToolStripMenuItem.Click += aZToolStripMenuItem_Click;
			// 
			// zAToolStripMenuItem
			// 
			zAToolStripMenuItem.Name = "zAToolStripMenuItem";
			zAToolStripMenuItem.Size = new Size(359, 54);
			zAToolStripMenuItem.Text = "Z-A";
			zAToolStripMenuItem.Click += zAToolStripMenuItem_Click;
			// 
			// menorPrecioToolStripMenuItem
			// 
			menorPrecioToolStripMenuItem.Name = "menorPrecioToolStripMenuItem";
			menorPrecioToolStripMenuItem.Size = new Size(359, 54);
			menorPrecioToolStripMenuItem.Text = "Menor Precio";
			menorPrecioToolStripMenuItem.Click += menorPrecioToolStripMenuItem_Click;
			// 
			// mayorPrecioToolStripMenuItem
			// 
			mayorPrecioToolStripMenuItem.Name = "mayorPrecioToolStripMenuItem";
			mayorPrecioToolStripMenuItem.Size = new Size(359, 54);
			mayorPrecioToolStripMenuItem.Text = "Mayor Precio";
			mayorPrecioToolStripMenuItem.Click += mayorPrecioToolStripMenuItem_Click;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 119);
			// 
			// tsbCerrar
			// 
			tsbCerrar.Image = Properties.Resources.salida;
			tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbCerrar.ImageTransparentColor = Color.Magenta;
			tsbCerrar.Name = "tsbCerrar";
			tsbCerrar.Size = new Size(84, 113);
			tsbCerrar.Text = "Salir";
			tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbCerrar.Click += tsbCerrar_Click;
			// 
			// panelNavegacion
			// 
			panelNavegacion.Controls.Add(btnSiguiente);
			panelNavegacion.Controls.Add(txtCantidadRegistros);
			panelNavegacion.Controls.Add(cboPaginas);
			panelNavegacion.Controls.Add(label2);
			panelNavegacion.Controls.Add(label1);
			panelNavegacion.Controls.Add(btnUltimo);
			panelNavegacion.Controls.Add(btnAnterior);
			panelNavegacion.Controls.Add(btnPrimero);
			panelNavegacion.Dock = DockStyle.Bottom;
			panelNavegacion.Location = new Point(0, 705);
			panelNavegacion.Margin = new Padding(6);
			panelNavegacion.Name = "panelNavegacion";
			panelNavegacion.Size = new Size(1474, 124);
			panelNavegacion.TabIndex = 12;
			// 
			// btnSiguiente
			// 
			btnSiguiente.Image = Properties.Resources.angulo_derecho;
			btnSiguiente.Location = new Point(1163, 34);
			btnSiguiente.Margin = new Padding(6);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(129, 63);
			btnSiguiente.TabIndex = 4;
			btnSiguiente.UseVisualStyleBackColor = true;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// txtCantidadRegistros
			// 
			txtCantidadRegistros.Location = new Point(299, 46);
			txtCantidadRegistros.Margin = new Padding(6);
			txtCantidadRegistros.Name = "txtCantidadRegistros";
			txtCantidadRegistros.ReadOnly = true;
			txtCantidadRegistros.Size = new Size(154, 39);
			txtCantidadRegistros.TabIndex = 3;
			// 
			// cboPaginas
			// 
			cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPaginas.FormattingEnabled = true;
			cboPaginas.Location = new Point(108, 46);
			cboPaginas.Margin = new Padding(6);
			cboPaginas.Name = "cboPaginas";
			cboPaginas.Size = new Size(123, 40);
			cboPaginas.TabIndex = 2;
			cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(255, 52);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(41, 32);
			label2.TabIndex = 1;
			label2.Text = "de";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(48, 49);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(57, 32);
			label1.TabIndex = 1;
			label1.Text = "Pág.";
			// 
			// btnUltimo
			// 
			btnUltimo.Image = Properties.Resources.angulo_doble_derecha;
			btnUltimo.Location = new Point(1319, 34);
			btnUltimo.Margin = new Padding(6);
			btnUltimo.Name = "btnUltimo";
			btnUltimo.Size = new Size(125, 63);
			btnUltimo.TabIndex = 0;
			btnUltimo.UseVisualStyleBackColor = true;
			btnUltimo.Click += btnUltimo_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.Image = Properties.Resources.angulo_izquierdo;
			btnAnterior.Location = new Point(1022, 34);
			btnAnterior.Margin = new Padding(6);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(129, 63);
			btnAnterior.TabIndex = 0;
			btnAnterior.UseVisualStyleBackColor = true;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// btnPrimero
			// 
			btnPrimero.Image = Properties.Resources.angulo_doble_izquierda__1_;
			btnPrimero.Location = new Point(866, 34);
			btnPrimero.Margin = new Padding(6);
			btnPrimero.Name = "btnPrimero";
			btnPrimero.Size = new Size(129, 63);
			btnPrimero.TabIndex = 0;
			btnPrimero.UseVisualStyleBackColor = true;
			btnPrimero.Click += btnPrimero_Click;
			// 
			// frmShoes
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1474, 829);
			Controls.Add(panelGrilla);
			Controls.Add(panelToolBar);
			Controls.Add(panelNavegacion);
			Name = "frmShoes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmShoes";
			Load += frmShoes_Load;
			panelGrilla.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panelToolBar.ResumeLayout(false);
			panelToolBar.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panelNavegacion.ResumeLayout(false);
			panelNavegacion.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelGrilla;
        private DataGridView dgvDatos;
        private Panel panelToolBar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrden;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripMenuItem menorPrecioToolStripMenuItem;
        private ToolStripMenuItem mayorPrecioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbCerrar;
        private Panel panelNavegacion;
        private Button btnSiguiente;
        private TextBox txtCantidadRegistros;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private Button btnUltimo;
        private Button btnAnterior;
        private Button btnPrimero;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colBrand;
        private DataGridViewTextBoxColumn colSport;
		private ToolStripDropDownButton tsbFiltrar;
		private ToolStripMenuItem porMarca;
		private ToolStripComboBox tscMarca;
		private ToolStripMenuItem porColor;
		private ToolStripComboBox tscColor;
		private ToolStripMenuItem porDeporte;
		private ToolStripMenuItem porGenero;
		private ToolStripComboBox tscGenero;
		private ToolStripComboBox tscDeporte;
	}
}