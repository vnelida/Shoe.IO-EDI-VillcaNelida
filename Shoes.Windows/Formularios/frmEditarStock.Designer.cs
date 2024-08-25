namespace Shoes.Windows.Formularios
{
	partial class frmEditarStock
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
			stockUpDown = new NumericUpDown();
			label2 = new Label();
			btnCancel = new Button();
			btnOk = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)stockUpDown).BeginInit();
			SuspendLayout();
			// 
			// stockUpDown
			// 
			stockUpDown.Location = new Point(270, 88);
			stockUpDown.Name = "stockUpDown";
			stockUpDown.Size = new Size(324, 39);
			stockUpDown.TabIndex = 23;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(124, 90);
			label2.Name = "label2";
			label2.Size = new Size(109, 32);
			label2.TabIndex = 22;
			label2.Text = "Cantidad";
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(390, 207);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(184, 73);
			btnCancel.TabIndex = 21;
			btnCancel.Text = "Cancelar";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(152, 207);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(165, 73);
			btnOk.TabIndex = 20;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(230, 43);
			label1.Name = "label1";
			label1.Size = new Size(0, 32);
			label1.TabIndex = 24;
			// 
			// frmEditarStock
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(735, 382);
			Controls.Add(label1);
			Controls.Add(stockUpDown);
			Controls.Add(label2);
			Controls.Add(btnCancel);
			Controls.Add(btnOk);
			Name = "frmEditarStock";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmEditarStock";
			Load += frmEditarStock_Load;
			((System.ComponentModel.ISupportInitialize)stockUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown stockUpDown;
		private Label label2;
		private Button btnCancel;
		private Button btnOk;
		private Label label1;
	}
}