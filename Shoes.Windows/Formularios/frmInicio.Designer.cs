namespace Shoes.Windows
{
    partial class frmInicio
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
            btnColor = new Button();
            btnGenre = new Button();
            btnSport = new Button();
            btnShoes = new Button();
            btnBrand = new Button();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Location = new Point(625, 224);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(150, 96);
            btnColor.TabIndex = 11;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnGenre
            // 
            btnGenre.Location = new Point(250, 379);
            btnGenre.Name = "btnGenre";
            btnGenre.Size = new Size(150, 96);
            btnGenre.TabIndex = 10;
            btnGenre.Text = "Genre";
            btnGenre.UseVisualStyleBackColor = true;
            btnGenre.Click += btnGenre_Click;
            // 
            // btnSport
            // 
            btnSport.Location = new Point(746, 379);
            btnSport.Name = "btnSport";
            btnSport.Size = new Size(150, 96);
            btnSport.TabIndex = 9;
            btnSport.Text = "Sports";
            btnSport.UseVisualStyleBackColor = true;
            btnSport.Click += btnSport_Click;
            // 
            // btnShoes
            // 
            btnShoes.Location = new Point(499, 379);
            btnShoes.Name = "btnShoes";
            btnShoes.Size = new Size(150, 96);
            btnShoes.TabIndex = 8;
            btnShoes.Text = "Shoes";
            btnShoes.UseVisualStyleBackColor = true;
            btnShoes.Click += btnShoes_Click;
            // 
            // btnBrand
            // 
            btnBrand.Location = new Point(387, 224);
            btnBrand.Name = "btnBrand";
            btnBrand.Size = new Size(150, 96);
            btnBrand.TabIndex = 7;
            btnBrand.Text = "Brands";
            btnBrand.UseVisualStyleBackColor = true;
            btnBrand.Click += btnBrand_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 699);
            Controls.Add(btnColor);
            Controls.Add(btnGenre);
            Controls.Add(btnSport);
            Controls.Add(btnShoes);
            Controls.Add(btnBrand);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnColor;
        private Button btnGenre;
        private Button btnSport;
        private Button btnShoes;
        private Button btnBrand;
    }
}