namespace Shoes.Windows.Formularios
{
	partial class frmSizes
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
			panelGrilla = new Panel();
			dgvDatos = new DataGridView();
			colSize = new DataGridViewTextBoxColumn();
			panelToolBar = new Panel();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
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
			panelGrilla.Dock = DockStyle.Fill;
			panelGrilla.Location = new Point(0, 131);
			panelGrilla.Margin = new Padding(6);
			panelGrilla.Name = "panelGrilla";
			panelGrilla.Size = new Size(1474, 574);
			panelGrilla.TabIndex = 14;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.White;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colSize });
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
			dgvDatos.Size = new Size(1474, 574);
			dgvDatos.TabIndex = 0;
			// 
			// colSize
			// 
			colSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colSize.HeaderText = "Talle";
			colSize.MinimumWidth = 10;
			colSize.Name = "colSize";
			colSize.ReadOnly = true;
			// 
			// panelToolBar
			// 
			panelToolBar.Controls.Add(toolStrip1);
			panelToolBar.Dock = DockStyle.Top;
			panelToolBar.Location = new Point(0, 0);
			panelToolBar.Margin = new Padding(6);
			panelToolBar.Name = "panelToolBar";
			panelToolBar.Size = new Size(1474, 131);
			panelToolBar.TabIndex = 13;
			// 
			// toolStrip1
			// 
			toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.Size = new Size(1474, 119);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.icons8_agregar_archivo_641;
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
			label2.Location = new Point(257, 49);
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
			// frmSizes
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1474, 829);
			Controls.Add(panelGrilla);
			Controls.Add(panelToolBar);
			Controls.Add(panelNavegacion);
			Name = "frmSizes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmSizes";
			Load += frmSizes_Load;
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
		private DataGridViewTextBoxColumn colSize;
	}
}