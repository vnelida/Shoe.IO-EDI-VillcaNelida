namespace Shoes.Windows.Formularios
{
    partial class frmBrandAE
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
			txtBrand = new TextBox();
			btnCancel = new Button();
			btnOk = new Button();
			label1 = new Label();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// txtBrand
			// 
			txtBrand.Location = new Point(284, 109);
			txtBrand.Name = "txtBrand";
			txtBrand.Size = new Size(330, 39);
			txtBrand.TabIndex = 13;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(406, 246);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(184, 73);
			btnCancel.TabIndex = 15;
			btnCancel.Text = "Cancelar";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(160, 246);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(165, 73);
			btnOk.TabIndex = 14;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(179, 112);
			label1.Name = "label1";
			label1.Size = new Size(81, 32);
			label1.TabIndex = 16;
			label1.Text = "Brand:";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBrandAE
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(774, 429);
			Controls.Add(txtBrand);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(label1);
			Name = "frmBrandAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = " ";
			Load += frmBrandAE_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBrand;
        private Button btnCancel;
        private Button btnOk;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}