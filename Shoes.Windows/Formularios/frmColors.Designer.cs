namespace Shoes.Windows.Formularios
{
    partial class frmColors
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
			dgvDatos = new DataGridView();
			colColor = new DataGridViewTextBoxColumn();
			btnSiguiente = new Button();
			txtCantidadRegistros = new TextBox();
			cboPaginas = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			btnUltimo = new Button();
			btnAnterior = new Button();
			btnPrimero = new Button();
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
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colColor });
			dgvDatos.GridColor = SystemColors.ControlLight;
			dgvDatos.Location = new Point(0, 122);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1474, 613);
			dgvDatos.TabIndex = 5;
			// 
			// colColor
			// 
			colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colColor.HeaderText = "Color";
			colColor.MinimumWidth = 10;
			colColor.Name = "colColor";
			colColor.ReadOnly = true;
			// 
			// btnSiguiente
			// 
			btnSiguiente.Image = Properties.Resources.angulo_derecho;
			btnSiguiente.Location = new Point(1158, 751);
			btnSiguiente.Margin = new Padding(6);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(129, 63);
			btnSiguiente.TabIndex = 13;
			btnSiguiente.UseVisualStyleBackColor = true;
			btnSiguiente.Click += btnSiguiente_Click_1;
			// 
			// txtCantidadRegistros
			// 
			txtCantidadRegistros.Location = new Point(294, 763);
			txtCantidadRegistros.Margin = new Padding(6);
			txtCantidadRegistros.Name = "txtCantidadRegistros";
			txtCantidadRegistros.ReadOnly = true;
			txtCantidadRegistros.Size = new Size(154, 39);
			txtCantidadRegistros.TabIndex = 12;
			// 
			// cboPaginas
			// 
			cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPaginas.FormattingEnabled = true;
			cboPaginas.Location = new Point(103, 763);
			cboPaginas.Margin = new Padding(6);
			cboPaginas.Name = "cboPaginas";
			cboPaginas.Size = new Size(123, 40);
			cboPaginas.TabIndex = 11;
			cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(252, 766);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(41, 32);
			label2.TabIndex = 9;
			label2.Text = "de";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(45, 769);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(57, 32);
			label1.TabIndex = 10;
			label1.Text = "Pag.";
			// 
			// btnUltimo
			// 
			btnUltimo.Image = Properties.Resources.angulo_doble_derecha;
			btnUltimo.Location = new Point(1314, 751);
			btnUltimo.Margin = new Padding(6);
			btnUltimo.Name = "btnUltimo";
			btnUltimo.Size = new Size(125, 63);
			btnUltimo.TabIndex = 6;
			btnUltimo.UseVisualStyleBackColor = true;
			btnUltimo.Click += btnUltimo_Click_1;
			// 
			// btnAnterior
			// 
			btnAnterior.Image = Properties.Resources.angulo_izquierdo;
			btnAnterior.Location = new Point(1017, 751);
			btnAnterior.Margin = new Padding(6);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(129, 63);
			btnAnterior.TabIndex = 7;
			btnAnterior.UseVisualStyleBackColor = true;
			btnAnterior.Click += btnAnterior_Click_1;
			// 
			// btnPrimero
			// 
			btnPrimero.Image = Properties.Resources.angulo_doble_izquierda__1_;
			btnPrimero.Location = new Point(861, 751);
			btnPrimero.Margin = new Padding(6);
			btnPrimero.Name = "btnPrimero";
			btnPrimero.Size = new Size(129, 63);
			btnPrimero.TabIndex = 8;
			btnPrimero.UseVisualStyleBackColor = true;
			btnPrimero.Click += btnPrimero_Click_1;
			// 
			// toolStrip1
			// 
			toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbConsulta, tsbOrden, tsbActualizar, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.Size = new Size(1474, 119);
			toolStrip1.TabIndex = 14;
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
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = Properties.Resources.icons8_eliminar_archivo_64;
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
			tsbConsulta.Image = Properties.Resources.icons8_letra_pequeña_64;
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
			tsbActualizar.Image = Properties.Resources.icons8_renovar_suscripción_641;
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(162, 113);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbActualizar.Click += tsbActualizar_Click;
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
			tsbCerrar.Click += tsbCerrar_Click;
			// 
			// frmColors
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1474, 829);
			Controls.Add(toolStrip1);
			Controls.Add(btnSiguiente);
			Controls.Add(txtCantidadRegistros);
			Controls.Add(cboPaginas);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnUltimo);
			Controls.Add(btnAnterior);
			Controls.Add(btnPrimero);
			Controls.Add(dgvDatos);
			Name = "frmColors";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Colors";
			Load += frmColors_Load;
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colColor;
		private Button btnSiguiente;
		private TextBox txtCantidadRegistros;
		private ComboBox cboPaginas;
		private Label label2;
		private Label label1;
		private Button btnUltimo;
		private Button btnAnterior;
		private Button btnPrimero;
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