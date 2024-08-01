namespace Shoes.Windows.Formularios
{
    partial class frmShoesAE
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoesAE));
			errorProvider1 = new ErrorProvider(components);
			btnNuevoBrand = new Button();
			btnCancelar = new Button();
			cboColors = new ComboBox();
			label4 = new Label();
			cboBrands = new ComboBox();
			label3 = new Label();
			txtDescripcion = new TextBox();
			label5 = new Label();
			txtModel = new TextBox();
			label2 = new Label();
			txtPrecio = new TextBox();
			cboGenres = new ComboBox();
			label6 = new Label();
			btnNuevoColor = new Button();
			btnOk = new Button();
			label1 = new Label();
			cboSports = new ComboBox();
			label7 = new Label();
			lblMarca = new Label();
			lblColor = new Label();
			lblDeporte = new Label();
			lblGenero = new Label();
			btnNuevoDeporte = new Button();
			btnNuevoGenero = new Button();
			label8 = new Label();
			clstTalles = new CheckedListBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// btnNuevoBrand
			// 
			btnNuevoBrand.AutoSize = true;
			btnNuevoBrand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnNuevoBrand.BackColor = SystemColors.Window;
			btnNuevoBrand.Image = (Image)resources.GetObject("btnNuevoBrand.Image");
			btnNuevoBrand.Location = new Point(367, 356);
			btnNuevoBrand.Margin = new Padding(6);
			btnNuevoBrand.Name = "btnNuevoBrand";
			btnNuevoBrand.Size = new Size(38, 38);
			btnNuevoBrand.TabIndex = 55;
			btnNuevoBrand.TextImageRelation = TextImageRelation.ImageAboveText;
			btnNuevoBrand.UseVisualStyleBackColor = false;
			btnNuevoBrand.Click += btnNuevoBrand_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(480, 785);
			btnCancelar.Margin = new Padding(6);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(196, 94);
			btnCancelar.TabIndex = 53;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// cboColors
			// 
			cboColors.DropDownStyle = ComboBoxStyle.DropDownList;
			cboColors.FormattingEnabled = true;
			cboColors.Location = new Point(150, 476);
			cboColors.Margin = new Padding(6);
			cboColors.Name = "cboColors";
			cboColors.Size = new Size(205, 40);
			cboColors.TabIndex = 51;
			cboColors.SelectedIndexChanged += cboColors_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(62, 479);
			label4.Margin = new Padding(6, 0, 6, 0);
			label4.Name = "label4";
			label4.Size = new Size(71, 32);
			label4.TabIndex = 49;
			label4.Text = "Color";
			// 
			// cboBrands
			// 
			cboBrands.DropDownStyle = ComboBoxStyle.DropDownList;
			cboBrands.FormattingEnabled = true;
			cboBrands.Location = new Point(150, 356);
			cboBrands.Margin = new Padding(6);
			cboBrands.Name = "cboBrands";
			cboBrands.Size = new Size(205, 40);
			cboBrands.TabIndex = 52;
			cboBrands.SelectedIndexChanged += cboBrands_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(54, 359);
			label3.Margin = new Padding(6, 0, 6, 0);
			label3.Name = "label3";
			label3.Size = new Size(79, 32);
			label3.TabIndex = 50;
			label3.Text = "Marca";
			// 
			// txtDescripcion
			// 
			txtDescripcion.Location = new Point(150, 175);
			txtDescripcion.Margin = new Padding(6);
			txtDescripcion.Name = "txtDescripcion";
			txtDescripcion.Size = new Size(787, 39);
			txtDescripcion.TabIndex = 46;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(0, 178);
			label5.Margin = new Padding(6, 0, 6, 0);
			label5.Name = "label5";
			label5.Size = new Size(138, 32);
			label5.TabIndex = 43;
			label5.Text = "Descripcion";
			// 
			// txtModel
			// 
			txtModel.Location = new Point(150, 88);
			txtModel.Margin = new Padding(6);
			txtModel.Name = "txtModel";
			txtModel.Size = new Size(787, 39);
			txtModel.TabIndex = 47;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 88);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(97, 32);
			label2.TabIndex = 44;
			label2.Text = "Modelo";
			// 
			// txtPrecio
			// 
			txtPrecio.Location = new Point(150, 257);
			txtPrecio.Margin = new Padding(6);
			txtPrecio.Name = "txtPrecio";
			txtPrecio.Size = new Size(787, 39);
			txtPrecio.TabIndex = 60;
			// 
			// cboGenres
			// 
			cboGenres.DropDownStyle = ComboBoxStyle.DropDownList;
			cboGenres.FormattingEnabled = true;
			cboGenres.Location = new Point(607, 356);
			cboGenres.Margin = new Padding(6);
			cboGenres.Name = "cboGenres";
			cboGenres.Size = new Size(229, 40);
			cboGenres.TabIndex = 62;
			cboGenres.SelectedIndexChanged += cboGenres_SelectedIndexChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(503, 359);
			label6.Margin = new Padding(6, 0, 6, 0);
			label6.Name = "label6";
			label6.Size = new Size(92, 32);
			label6.TabIndex = 61;
			label6.Text = "Genero";
			// 
			// btnNuevoColor
			// 
			btnNuevoColor.AutoSize = true;
			btnNuevoColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnNuevoColor.Image = (Image)resources.GetObject("btnNuevoColor.Image");
			btnNuevoColor.Location = new Point(367, 476);
			btnNuevoColor.Margin = new Padding(6);
			btnNuevoColor.Name = "btnNuevoColor";
			btnNuevoColor.Size = new Size(38, 38);
			btnNuevoColor.TabIndex = 64;
			btnNuevoColor.TextImageRelation = TextImageRelation.ImageAboveText;
			btnNuevoColor.UseVisualStyleBackColor = true;
			btnNuevoColor.Click += btnNuevoColor_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(244, 785);
			btnOk.Margin = new Padding(6);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(196, 94);
			btnOk.TabIndex = 65;
			btnOk.Text = "Ok";
			btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(62, 260);
			label1.Name = "label1";
			label1.Size = new Size(79, 32);
			label1.TabIndex = 66;
			label1.Text = "Precio";
			// 
			// cboSports
			// 
			cboSports.DropDownStyle = ComboBoxStyle.DropDownList;
			cboSports.FormattingEnabled = true;
			cboSports.Location = new Point(607, 479);
			cboSports.Margin = new Padding(6);
			cboSports.Name = "cboSports";
			cboSports.Size = new Size(229, 40);
			cboSports.TabIndex = 68;
			cboSports.SelectedIndexChanged += cboSports_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(494, 482);
			label7.Margin = new Padding(6, 0, 6, 0);
			label7.Name = "label7";
			label7.Size = new Size(101, 32);
			label7.TabIndex = 67;
			label7.Text = "Deporte";
			// 
			// lblMarca
			// 
			lblMarca.AutoSize = true;
			lblMarca.Location = new Point(162, 402);
			lblMarca.Name = "lblMarca";
			lblMarca.Size = new Size(177, 32);
			lblMarca.TabIndex = 70;
			lblMarca.Text = "NUEVA MARCA";
			lblMarca.Visible = false;
			// 
			// lblColor
			// 
			lblColor.AutoSize = true;
			lblColor.Location = new Point(162, 522);
			lblColor.Name = "lblColor";
			lblColor.Size = new Size(173, 32);
			lblColor.TabIndex = 71;
			lblColor.Text = "NUEVO COLOR";
			lblColor.Visible = false;
			// 
			// lblDeporte
			// 
			lblDeporte.AutoSize = true;
			lblDeporte.Location = new Point(626, 525);
			lblDeporte.Name = "lblDeporte";
			lblDeporte.Size = new Size(197, 32);
			lblDeporte.TabIndex = 72;
			lblDeporte.Text = "NUEVO DEPORTE";
			lblDeporte.Visible = false;
			// 
			// lblGenero
			// 
			lblGenero.AutoSize = true;
			lblGenero.Location = new Point(626, 402);
			lblGenero.Name = "lblGenero";
			lblGenero.Size = new Size(189, 32);
			lblGenero.TabIndex = 73;
			lblGenero.Text = "NUEVO GENERO";
			lblGenero.Visible = false;
			// 
			// btnNuevoDeporte
			// 
			btnNuevoDeporte.AutoSize = true;
			btnNuevoDeporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnNuevoDeporte.Image = (Image)resources.GetObject("btnNuevoDeporte.Image");
			btnNuevoDeporte.Location = new Point(848, 482);
			btnNuevoDeporte.Margin = new Padding(6);
			btnNuevoDeporte.Name = "btnNuevoDeporte";
			btnNuevoDeporte.Size = new Size(38, 38);
			btnNuevoDeporte.TabIndex = 75;
			btnNuevoDeporte.TextImageRelation = TextImageRelation.ImageAboveText;
			btnNuevoDeporte.UseVisualStyleBackColor = true;
			btnNuevoDeporte.Click += btnNuevoDeporte_Click;
			// 
			// btnNuevoGenero
			// 
			btnNuevoGenero.AutoSize = true;
			btnNuevoGenero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnNuevoGenero.BackColor = SystemColors.Window;
			btnNuevoGenero.Image = (Image)resources.GetObject("btnNuevoGenero.Image");
			btnNuevoGenero.Location = new Point(848, 354);
			btnNuevoGenero.Margin = new Padding(6);
			btnNuevoGenero.Name = "btnNuevoGenero";
			btnNuevoGenero.Size = new Size(38, 38);
			btnNuevoGenero.TabIndex = 74;
			btnNuevoGenero.TextImageRelation = TextImageRelation.ImageAboveText;
			btnNuevoGenero.UseVisualStyleBackColor = false;
			btnNuevoGenero.Click += btnNuevoGenero_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(143, 608);
			label8.Name = "label8";
			label8.Size = new Size(71, 32);
			label8.TabIndex = 77;
			label8.Text = "Talles";
			// 
			// clstTalles
			// 
			clstTalles.FormattingEnabled = true;
			clstTalles.Location = new Point(223, 608);
			clstTalles.Margin = new Padding(6);
			clstTalles.Name = "clstTalles";
			clstTalles.Size = new Size(490, 112);
			clstTalles.TabIndex = 78;
			// 
			// frmShoesAE
			// 
			AcceptButton = btnOk;
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancelar;
			ClientSize = new Size(974, 894);
			Controls.Add(clstTalles);
			Controls.Add(label8);
			Controls.Add(btnNuevoDeporte);
			Controls.Add(btnNuevoGenero);
			Controls.Add(lblGenero);
			Controls.Add(lblDeporte);
			Controls.Add(lblColor);
			Controls.Add(lblMarca);
			Controls.Add(cboSports);
			Controls.Add(label7);
			Controls.Add(label1);
			Controls.Add(btnOk);
			Controls.Add(btnNuevoColor);
			Controls.Add(cboGenres);
			Controls.Add(label6);
			Controls.Add(txtPrecio);
			Controls.Add(btnNuevoBrand);
			Controls.Add(btnCancelar);
			Controls.Add(cboColors);
			Controls.Add(label4);
			Controls.Add(cboBrands);
			Controls.Add(label3);
			Controls.Add(txtDescripcion);
			Controls.Add(label5);
			Controls.Add(txtModel);
			Controls.Add(label2);
			Name = "frmShoesAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = " ";
			Load += frmShoesAe_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ErrorProvider errorProvider1;
        private Button btnNuevoBrand;
        private Button btnCancelar;
        private ComboBox cboColors;
        private Label label4;
        private ComboBox cboBrands;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtPrecio;
        private ComboBox cboGenres;
        private Label label6;
        private Button btnNuevoColor;
        private Button btnOk;
        private ComboBox cboSports;
        private Label label7;
        private Label label1;
		private Label lblMarca;
		private Label lblGenero;
		private Label lblDeporte;
		private Label lblColor;
		private Button btnNuevoDeporte;
		private Button btnNuevoGenero;
		private CheckedListBox clstTalles;
		private Label label8;
	}
}