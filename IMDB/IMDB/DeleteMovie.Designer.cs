namespace IMDB
{
    partial class DeleteMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMovie));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(212, 2);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(248, 42);
            this.bunifuCustomLabel1.TabIndex = 119;
            this.bunifuCustomLabel1.Text = "Delete Movie";
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
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(208, 39);
            this.bunifuCustomLabel6.TabIndex = 110;
            this.bunifuCustomLabel6.Text = "Movie Name";
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.NameTxt.HintText = "";
            this.NameTxt.isPassword = false;
            this.NameTxt.LineFocusedColor = System.Drawing.Color.Black;
            this.NameTxt.LineIdleColor = System.Drawing.Color.White;
            this.NameTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.NameTxt.LineThickness = 3;
            this.NameTxt.Location = new System.Drawing.Point(384, 242);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(277, 53);
            this.NameTxt.TabIndex = 109;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTxt.OnValueChanged += new System.EventHandler(this.TypeTxt_OnValueChanged);
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
            this.cancelBtn.TabIndex = 121;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ActiveBorderThickness = 1;
            this.deleteBtn.ActiveCornerRadius = 1;
            this.deleteBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.deleteBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.IdleBorderThickness = 1;
            this.deleteBtn.IdleCornerRadius = 1;
            this.deleteBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.IdleForecolor = System.Drawing.Color.White;
            this.deleteBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.Location = new System.Drawing.Point(100, 608);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(229, 63);
            this.deleteBtn.TabIndex = 120;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(132, 47);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(424, 186);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton4.TabIndex = 107;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.bunifuImageButton4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteMovie";
            this.Size = new System.Drawing.Size(689, 682);
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTxt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}
