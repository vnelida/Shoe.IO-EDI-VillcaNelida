namespace Shoes.Windows.Formularios
{
	partial class frmDetalleTalles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleTalles));
			dgvDatos = new DataGridView();
			colSize = new DataGridViewTextBoxColumn();
			colStock = new DataGridViewTextBoxColumn();
			toolStrip1 = new ToolStrip();
			ModificarStock = new ToolStripButton();
			tsbAgregarStock = new ToolStripButton();
			tsbQuitarStock = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDatos
			// 
			dgvDatos.AccessibleRole = AccessibleRole.None;
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.White;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colSize, colStock });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.ControlLight;
			dgvDatos.Location = new Point(0, 106);
			dgvDatos.Margin = new Padding(6);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.ShowEditingIcon = false;
			dgvDatos.Size = new Size(1213, 610);
			dgvDatos.TabIndex = 1;
			dgvDatos.CellContentClick += dgvDatos_CellContentClick;
			// 
			// colSize
			// 
			colSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colSize.HeaderText = "Talle";
			colSize.MinimumWidth = 10;
			colSize.Name = "colSize";
			colSize.ReadOnly = true;
			// 
			// colStock
			// 
			colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colStock.HeaderText = "Stock";
			colStock.MinimumWidth = 10;
			colStock.Name = "colStock";
			colStock.ReadOnly = true;
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { ModificarStock, tsbAgregarStock, tsbQuitarStock });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1213, 106);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// ModificarStock
			// 
			ModificarStock.Alignment = ToolStripItemAlignment.Right;
			ModificarStock.Image = (Image)resources.GetObject("ModificarStock.Image");
			ModificarStock.ImageScaling = ToolStripItemImageScaling.None;
			ModificarStock.ImageTransparentColor = Color.Magenta;
			ModificarStock.Name = "ModificarStock";
			ModificarStock.Size = new Size(320, 100);
			ModificarStock.Text = "Modificar cantidad existente";
			ModificarStock.TextImageRelation = TextImageRelation.ImageAboveText;
			ModificarStock.Click += ModificarStock_Click;
			// 
			// tsbAgregarStock
			// 
			tsbAgregarStock.Image = (Image)resources.GetObject("tsbAgregarStock.Image");
			tsbAgregarStock.ImageScaling = ToolStripItemImageScaling.None;
			tsbAgregarStock.ImageTransparentColor = Color.Magenta;
			tsbAgregarStock.Name = "tsbAgregarStock";
			tsbAgregarStock.Size = new Size(102, 100);
			tsbAgregarStock.Text = "Agregar";
			tsbAgregarStock.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbAgregarStock.Click += tsbAgregarStock_Click;
			// 
			// tsbQuitarStock
			// 
			tsbQuitarStock.Image = (Image)resources.GetObject("tsbQuitarStock.Image");
			tsbQuitarStock.ImageScaling = ToolStripItemImageScaling.None;
			tsbQuitarStock.ImageTransparentColor = Color.Magenta;
			tsbQuitarStock.Name = "tsbQuitarStock";
			tsbQuitarStock.Size = new Size(84, 100);
			tsbQuitarStock.Text = "Quitar";
			tsbQuitarStock.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbQuitarStock.Click += tsbQuitarStock_Click;
			// 
			// frmDetalleTalles
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1213, 716);
			Controls.Add(dgvDatos);
			Controls.Add(toolStrip1);
			Name = "frmDetalleTalles";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmDetalleTalles";
			Load += frmDetalleTalles_Load;
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripStatusLabel toolStripStatusLabel2;
		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colSize;
		private DataGridViewTextBoxColumn colStock;
		private ToolStrip toolStrip1;
		private ToolStripButton ModificarStock;
		private ToolStripButton tsbAgregarStock;
		private ToolStripButton tsbQuitarStock;
	}
}