﻿namespace Shoes.Windows.Formularios
{
	partial class frmSizeAE
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
			txtSize = new TextBox();
			btnCancel = new Button();
			btnOk = new Button();
			label1 = new Label();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// txtSize
			// 
			txtSize.Location = new Point(297, 120);
			txtSize.Name = "txtSize";
			txtSize.Size = new Size(330, 39);
			txtSize.TabIndex = 9;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(419, 257);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(184, 73);
			btnCancel.TabIndex = 11;
			btnCancel.Text = "Cancelar";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click_1;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(173, 257);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(165, 73);
			btnOk.TabIndex = 10;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(192, 123);
			label1.Name = "label1";
			label1.Size = new Size(61, 32);
			label1.TabIndex = 12;
			label1.Text = "Talle";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmSizeAE
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtSize);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(label1);
			Name = "frmSizeAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmSizeAE";
			Load += frmSizeAE_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtSize;
		private Button btnCancel;
		private Button btnOk;
		private Label label1;
		private ErrorProvider errorProvider1;
	}
}