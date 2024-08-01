namespace Shoes.Windows.Formularios
{
	partial class frmMostrarShoes
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
			colModel = new DataGridViewTextBoxColumn();
			colDescripcion = new DataGridViewTextBoxColumn();
			colPrice = new DataGridViewTextBoxColumn();
			colColor = new DataGridViewTextBoxColumn();
			colGenre = new DataGridViewTextBoxColumn();
			colBrand = new DataGridViewTextBoxColumn();
			colSport = new DataGridViewTextBoxColumn();
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colModel, colDescripcion, colPrice, colColor, colGenre, colBrand, colSport });
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
			dgvDatos.Size = new Size(924, 529);
			dgvDatos.TabIndex = 1;
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
			// frmMostrarShoes
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(924, 529);
			Controls.Add(dgvDatos);
			Name = "frmMostrarShoes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmMostrarShoes";
			Load += frmMostrarShoes_Load;
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colModel;
		private DataGridViewTextBoxColumn colDescripcion;
		private DataGridViewTextBoxColumn colPrice;
		private DataGridViewTextBoxColumn colColor;
		private DataGridViewTextBoxColumn colGenre;
		private DataGridViewTextBoxColumn colBrand;
		private DataGridViewTextBoxColumn colSport;
	}
}