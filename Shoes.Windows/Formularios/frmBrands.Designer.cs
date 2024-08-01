namespace Shoes.Windows.Formularios
{
    partial class frmBrands
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			panelToolBar = new Panel();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsbConsulta = new ToolStripButton();
			tsbOrden = new ToolStripDropDownButton();
			aZToolStripMenuItem = new ToolStripMenuItem();
			zAToolStripMenuItem = new ToolStripMenuItem();
			tsbActualizar = new ToolStripButton();
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
			dgvDatos = new DataGridView();
			colBrand = new DataGridViewTextBoxColumn();
			panelGrilla = new Panel();
			panelToolBar.SuspendLayout();
			toolStrip1.SuspendLayout();
			panelNavegacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			panelGrilla.SuspendLayout();
			SuspendLayout();
			// 
			// panelToolBar
			// 
			panelToolBar.Controls.Add(toolStrip1);
			panelToolBar.Dock = DockStyle.Top;
			panelToolBar.Location = new Point(0, 0);
			panelToolBar.Margin = new Padding(6);
			panelToolBar.Name = "panelToolBar";
			panelToolBar.Size = new Size(1474, 126);
			panelToolBar.TabIndex = 13;
			// 
			// toolStrip1
			// 
			toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbConsulta, tsbOrden, tsbActualizar, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.RightToLeft = RightToLeft.No;
			toolStrip1.Size = new Size(1474, 119);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.icons8_agregar_archivo_64;
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(117, 113);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click_1;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = Properties.Resources.icons8_eliminar_archivo_641;
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(110, 113);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbBorrar.Click += tsbBorrar_Click_1;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = Properties.Resources.icons8_editar_archivo_64;
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
			// tsbConsulta
			// 
			tsbConsulta.BackColor = SystemColors.ControlLightLight;
			tsbConsulta.Image = Properties.Resources.icons8_letra_pequeña_641;
			tsbConsulta.ImageScaling = ToolStripItemImageScaling.None;
			tsbConsulta.ImageTransparentColor = Color.Magenta;
			tsbConsulta.Name = "tsbConsulta";
			tsbConsulta.Size = new Size(148, 113);
			tsbConsulta.Text = "Consulta";
			tsbConsulta.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbConsulta.Click += tsbConsulta_Click;
			// 
			// tsbOrden
			// 
			tsbOrden.DropDownItems.AddRange(new ToolStripItem[] { aZToolStripMenuItem, zAToolStripMenuItem });
			tsbOrden.Image = Properties.Resources.icons8_clasificación_descendente_64;
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
			aZToolStripMenuItem.Size = new Size(211, 54);
			aZToolStripMenuItem.Text = "A-Z";
			aZToolStripMenuItem.Click += aZToolStripMenuItem_Click_1;
			// 
			// zAToolStripMenuItem
			// 
			zAToolStripMenuItem.Name = "zAToolStripMenuItem";
			zAToolStripMenuItem.Size = new Size(211, 54);
			zAToolStripMenuItem.Text = "Z-A";
			zAToolStripMenuItem.Click += zAToolStripMenuItem_Click_1;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = Properties.Resources.icons8_renovar_suscripción_64;
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(162, 113);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbActualizar.Click += tsbActualizar_Click_1;
			// 
			// tsbCerrar
			// 
			tsbCerrar.Alignment = ToolStripItemAlignment.Right;
			tsbCerrar.Image = Properties.Resources.icons8_volver_64;
			tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbCerrar.ImageTransparentColor = Color.Magenta;
			tsbCerrar.Name = "tsbCerrar";
			tsbCerrar.Size = new Size(84, 113);
			tsbCerrar.Text = "Salir";
			tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbCerrar.Click += tsbCerrar_Click_1;
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
			panelNavegacion.Paint += panelNavegacion_Paint;
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
			label2.Location = new Point(259, 52);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(41, 32);
			label2.TabIndex = 1;
			label2.Text = "de";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(49, 49);
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
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.White;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colBrand });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.ControlLight;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.Margin = new Padding(6);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1495, 602);
			dgvDatos.TabIndex = 0;
			dgvDatos.CellContentClick += dgvDatos_CellContentClick;
			// 
			// colBrand
			// 
			colBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colBrand.HeaderText = "Brand";
			colBrand.MinimumWidth = 10;
			colBrand.Name = "colBrand";
			colBrand.ReadOnly = true;
			// 
			// panelGrilla
			// 
			panelGrilla.AutoSize = true;
			panelGrilla.Controls.Add(dgvDatos);
			panelGrilla.Location = new Point(0, 125);
			panelGrilla.Margin = new Padding(6);
			panelGrilla.Name = "panelGrilla";
			panelGrilla.Size = new Size(1495, 602);
			panelGrilla.TabIndex = 14;
			// 
			// frmBrands
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1474, 829);
			Controls.Add(panelGrilla);
			Controls.Add(panelToolBar);
			Controls.Add(panelNavegacion);
			Name = "frmBrands";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmBrands";
			Load += frmBrands_Load;
			panelToolBar.ResumeLayout(false);
			panelToolBar.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panelNavegacion.ResumeLayout(false);
			panelNavegacion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panelGrilla.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel panelToolBar;
        private Panel panelNavegacion;
        private Button btnSiguiente;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private Button btnUltimo;
        private Button btnAnterior;
        private Button btnPrimero;
		private TextBox txtCantidadRegistros;
		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colBrand;
		private Panel panelGrilla;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbNuevo;
		private ToolStripButton tsbBorrar;
		private ToolStripButton tsbEditar;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton tsbActualizar;
		private ToolStripDropDownButton tsbOrden;
		private ToolStripMenuItem aZToolStripMenuItem;
		private ToolStripMenuItem zAToolStripMenuItem;
		private ToolStripButton tsbCerrar;
		private ToolStripButton tsbConsulta;
	}
}