﻿namespace Shoes.Windows.Formularios
{
	partial class frmAgregarTalle
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
			btnCancel = new Button();
			btnOk = new Button();
			label1 = new Label();
			cboTalles = new ComboBox();
			errorProvider1 = new ErrorProvider(components);
			label2 = new Label();
			stockUpDown = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)stockUpDown).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(415, 303);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(184, 73);
			btnCancel.TabIndex = 15;
			btnCancel.Text = "Cancelar";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(177, 303);
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
			label1.Location = new Point(192, 123);
			label1.Name = "label1";
			label1.Size = new Size(66, 32);
			label1.TabIndex = 16;
			label1.Text = "Talle:";
			// 
			// cboTalles
			// 
			cboTalles.FormattingEnabled = true;
			cboTalles.Location = new Point(295, 127);
			cboTalles.Name = "cboTalles";
			cboTalles.Size = new Size(324, 40);
			cboTalles.TabIndex = 17;
			cboTalles.SelectedIndexChanged += cboTalles_SelectedIndexChanged;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(149, 186);
			label2.Name = "label2";
			label2.Size = new Size(109, 32);
			label2.TabIndex = 18;
			label2.Text = "Cantidad";
			// 
			// stockUpDown
			// 
			stockUpDown.Location = new Point(295, 184);
			stockUpDown.Name = "stockUpDown";
			stockUpDown.Size = new Size(324, 39);
			stockUpDown.TabIndex = 19;
			stockUpDown.ValueChanged += stockUpDown_ValueChanged;
			// 
			// frmAgregarTalle
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(stockUpDown);
			Controls.Add(label2);
			Controls.Add(cboTalles);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Controls.Add(label1);
			Name = "frmAgregarTalle";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmAgregarTalle";
			Load += frmAgregarTalle_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)stockUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnCancel;
		private Button btnOk;
		private Label label1;
		private ComboBox cboTalles;
		private ErrorProvider errorProvider1;
		private NumericUpDown stockUpDown;
		private Label label2;
	}
}