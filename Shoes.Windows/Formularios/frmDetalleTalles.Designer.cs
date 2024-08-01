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
			dgvDatos = new DataGridView();
			colSize = new DataGridViewTextBoxColumn();
			colStock = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.White;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colSize, colStock });
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
			dgvDatos.Size = new Size(800, 450);
			dgvDatos.TabIndex = 1;
			// 
			// colSize
			// 
			colSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			colSize.HeaderText = "Talle";
			colSize.MinimumWidth = 10;
			colSize.Name = "colSize";
			colSize.ReadOnly = true;
			colSize.Width = 597;
			// 
			// colStock
			// 
			colStock.HeaderText = "Stock";
			colStock.MinimumWidth = 10;
			colStock.Name = "colStock";
			colStock.ReadOnly = true;
			colStock.Width = 200;
			// 
			// frmDetalleTalles
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgvDatos);
			Name = "frmDetalleTalles";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmDetalleTalles";
			Load += frmDetalleTalles_Load;
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colSize;
		private DataGridViewTextBoxColumn colStock;
	}
}