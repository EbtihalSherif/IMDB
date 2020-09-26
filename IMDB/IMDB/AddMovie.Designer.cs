namespace IMDB
{
    partial class AddMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chooseType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YearTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Director = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rateTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.movieImage = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 11);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(217, 46);
            this.bunifuCustomLabel1.TabIndex = 104;
            this.bunifuCustomLabel1.Text = "Add Movie";
            // 
            // chooseType
            // 
            this.chooseType.BackColor = System.Drawing.Color.White;
            this.chooseType.BorderRadius = 3;
            this.chooseType.DisabledColor = System.Drawing.Color.White;
            this.chooseType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseType.ForeColor = System.Drawing.Color.Black;
            this.chooseType.Items = new string[] {
        "Drama",
        "Action",
        "Horror",
        "Comedy",
        "Fantasy",
        "Adventure",
        "Romance",
        "Animation"};
            this.chooseType.Location = new System.Drawing.Point(384, 400);
            this.chooseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseType.Name = "chooseType";
            this.chooseType.NomalColor = System.Drawing.Color.White;
            this.chooseType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.chooseType.selectedIndex = -1;
            this.chooseType.Size = new System.Drawing.Size(272, 43);
            this.chooseType.TabIndex = 103;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(28, 107);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(227, 42);
            this.bunifuCustomLabel7.TabIndex = 102;
            this.bunifuCustomLabel7.Text = "insert Poster";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(28, 548);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(245, 42);
            this.bunifuCustomLabel5.TabIndex = 101;
            this.bunifuCustomLabel5.Text = "Release Year";
            // 
            // YearTxt
            // 
            this.YearTxt.BackColor = System.Drawing.Color.White;
            this.YearTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTxt.ForeColor = System.Drawing.Color.Black;
            this.YearTxt.HintForeColor = System.Drawing.Color.Empty;
            this.YearTxt.HintText = "";
            this.YearTxt.isPassword = false;
            this.YearTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.YearTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.YearTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.YearTxt.LineThickness = 3;
            this.YearTxt.Location = new System.Drawing.Point(384, 546);
            this.YearTxt.Margin = new System.Windows.Forms.Padding(5);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(272, 50);
            this.YearTxt.TabIndex = 100;
            this.YearTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(28, 319);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(258, 42);
            this.bunifuCustomLabel2.TabIndex = 99;
            this.bunifuCustomLabel2.Text = "Movie Director";
            // 
            // Director
            // 
            this.Director.BackColor = System.Drawing.Color.White;
            this.Director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Director.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Director.ForeColor = System.Drawing.Color.Black;
            this.Director.HintForeColor = System.Drawing.Color.Empty;
            this.Director.HintText = "";
            this.Director.isPassword = false;
            this.Director.LineFocusedColor = System.Drawing.Color.Blue;
            this.Director.LineIdleColor = System.Drawing.Color.Gray;
            this.Director.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Director.LineThickness = 3;
            this.Director.Location = new System.Drawing.Point(384, 321);
            this.Director.Margin = new System.Windows.Forms.Padding(5);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(277, 52);
            this.Director.TabIndex = 98;
            this.Director.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(28, 471);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(207, 42);
            this.bunifuCustomLabel3.TabIndex = 97;
            this.bunifuCustomLabel3.Text = "Movie Rate";
            // 
            // rateTxt
            // 
            this.rateTxt.BackColor = System.Drawing.Color.White;
            this.rateTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rateTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxt.ForeColor = System.Drawing.Color.Black;
            this.rateTxt.HintForeColor = System.Drawing.Color.Empty;
            this.rateTxt.HintText = "";
            this.rateTxt.isPassword = false;
            this.rateTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.rateTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.rateTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.rateTxt.LineThickness = 3;
            this.rateTxt.Location = new System.Drawing.Point(384, 470);
            this.rateTxt.Margin = new System.Windows.Forms.Padding(5);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(272, 49);
            this.rateTxt.TabIndex = 96;
            this.rateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(28, 242);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(227, 42);
            this.bunifuCustomLabel6.TabIndex = 95;
            this.bunifuCustomLabel6.Text = "Movie Name";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.White;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.Black;
            this.nametxt.HintForeColor = System.Drawing.Color.Empty;
            this.nametxt.HintText = "";
            this.nametxt.isPassword = false;
            this.nametxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.nametxt.LineIdleColor = System.Drawing.Color.Gray;
            this.nametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nametxt.LineThickness = 3;
            this.nametxt.Location = new System.Drawing.Point(384, 241);
            this.nametxt.Margin = new System.Windows.Forms.Padding(5);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(277, 53);
            this.nametxt.TabIndex = 94;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(28, 395);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(212, 42);
            this.bunifuCustomLabel4.TabIndex = 93;
            this.bunifuCustomLabel4.Text = "Movie Type";
            // 
            // cancelBtn
            // 
            this.cancelBtn.ActiveBorderThickness = 1;
            this.cancelBtn.ActiveCornerRadius = 1;
            this.cancelBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.IdleBorderThickness = 1;
            this.cancelBtn.IdleCornerRadius = 1;
            this.cancelBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.IdleForecolor = System.Drawing.Color.White;
            this.cancelBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.Location = new System.Drawing.Point(356, 608);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(228, 63);
            this.cancelBtn.TabIndex = 106;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 1;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 1;
            this.AddBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.AddBtn.Location = new System.Drawing.Point(100, 608);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(229, 63);
            this.AddBtn.TabIndex = 105;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.Color.Transparent;
            this.movieImage.Image = ((System.Drawing.Image)(resources.GetObject("movieImage.Image")));
            this.movieImage.ImageActive = null;
            this.movieImage.Location = new System.Drawing.Point(381, 38);
            this.movieImage.Margin = new System.Windows.Forms.Padding(4);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(280, 186);
            this.movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.movieImage.TabIndex = 92;
            this.movieImage.TabStop = false;
            this.movieImage.Zoom = 10;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.chooseType);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.movieImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMovie";
            this.Size = new System.Drawing.Size(689, 682);
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown chooseType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox YearTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Director;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rateTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton movieImage;
    }
}
