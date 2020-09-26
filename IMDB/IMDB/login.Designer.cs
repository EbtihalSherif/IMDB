namespace IMDB
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.s_upPanel = new System.Windows.Forms.Panel();
            this.signUpDone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.uname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.f_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.s_inPanel = new System.Windows.Forms.Panel();
            this.signInDone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.uspass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.signInBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signUpBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.s_upPanel.SuspendLayout();
            this.s_inPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // s_upPanel
            // 
            this.s_upPanel.Controls.Add(this.signUpDone);
            this.s_upPanel.Controls.Add(this.label5);
            this.s_upPanel.Controls.Add(this.label4);
            this.s_upPanel.Controls.Add(this.upass);
            this.s_upPanel.Controls.Add(this.uname);
            this.s_upPanel.Controls.Add(this.label3);
            this.s_upPanel.Controls.Add(this.label2);
            this.s_upPanel.Controls.Add(this.s_name);
            this.s_upPanel.Controls.Add(this.f_name);
            this.s_upPanel.Controls.Add(this.label1);
            this.s_upPanel.Location = new System.Drawing.Point(28, 159);
            this.s_upPanel.Margin = new System.Windows.Forms.Padding(4);
            this.s_upPanel.Name = "s_upPanel";
            this.s_upPanel.Size = new System.Drawing.Size(564, 530);
            this.s_upPanel.TabIndex = 18;
            // 
            // signUpDone
            // 
            this.signUpDone.ActiveBorderThickness = 1;
            this.signUpDone.ActiveCornerRadius = 1;
            this.signUpDone.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.signUpDone.ActiveForecolor = System.Drawing.Color.White;
            this.signUpDone.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.signUpDone.BackColor = System.Drawing.Color.White;
            this.signUpDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpDone.BackgroundImage")));
            this.signUpDone.ButtonText = "Sign Up";
            this.signUpDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpDone.ForeColor = System.Drawing.Color.Black;
            this.signUpDone.IdleBorderThickness = 1;
            this.signUpDone.IdleCornerRadius = 1;
            this.signUpDone.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.signUpDone.IdleForecolor = System.Drawing.Color.White;
            this.signUpDone.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.signUpDone.Location = new System.Drawing.Point(148, 437);
            this.signUpDone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpDone.Name = "signUpDone";
            this.signUpDone.Size = new System.Drawing.Size(241, 63);
            this.signUpDone.TabIndex = 0;
            this.signUpDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpDone.Click += new System.EventHandler(this.signUpDone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "user name";
            // 
            // upass
            // 
            this.upass.BorderColorFocused = System.Drawing.Color.Silver;
            this.upass.BorderColorIdle = System.Drawing.Color.Silver;
            this.upass.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.upass.BorderThickness = 1;
            this.upass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.upass.ForeColor = System.Drawing.Color.Black;
            this.upass.isPassword = false;
            this.upass.Location = new System.Drawing.Point(25, 305);
            this.upass.Margin = new System.Windows.Forms.Padding(5);
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(513, 38);
            this.upass.TabIndex = 7;
            this.upass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uname
            // 
            this.uname.BorderColorFocused = System.Drawing.Color.Silver;
            this.uname.BorderColorIdle = System.Drawing.Color.Silver;
            this.uname.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.uname.BorderThickness = 1;
            this.uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.uname.ForeColor = System.Drawing.Color.Black;
            this.uname.isPassword = false;
            this.uname.Location = new System.Drawing.Point(25, 215);
            this.uname.Margin = new System.Windows.Forms.Padding(5);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(513, 38);
            this.uname.TabIndex = 6;
            this.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(291, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "second name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "first name";
            // 
            // s_name
            // 
            this.s_name.BorderColorFocused = System.Drawing.Color.Silver;
            this.s_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.s_name.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.s_name.BorderThickness = 1;
            this.s_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.s_name.ForeColor = System.Drawing.Color.Black;
            this.s_name.isPassword = false;
            this.s_name.Location = new System.Drawing.Point(285, 117);
            this.s_name.Margin = new System.Windows.Forms.Padding(5);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(253, 38);
            this.s_name.TabIndex = 3;
            this.s_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // f_name
            // 
            this.f_name.BorderColorFocused = System.Drawing.Color.Silver;
            this.f_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.f_name.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.f_name.BorderThickness = 1;
            this.f_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.f_name.ForeColor = System.Drawing.Color.Black;
            this.f_name.isPassword = false;
            this.f_name.Location = new System.Drawing.Point(21, 117);
            this.f_name.Margin = new System.Windows.Forms.Padding(5);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(251, 38);
            this.f_name.TabIndex = 1;
            this.f_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up for free";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(95, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 36);
            this.label9.TabIndex = 8;
            this.label9.Text = "user name";
            // 
            // s_inPanel
            // 
            this.s_inPanel.BackColor = System.Drawing.Color.White;
            this.s_inPanel.Controls.Add(this.signInDone);
            this.s_inPanel.Controls.Add(this.label8);
            this.s_inPanel.Controls.Add(this.label9);
            this.s_inPanel.Controls.Add(this.uspass);
            this.s_inPanel.Controls.Add(this.usname);
            this.s_inPanel.Controls.Add(this.label12);
            this.s_inPanel.Location = new System.Drawing.Point(28, 159);
            this.s_inPanel.Margin = new System.Windows.Forms.Padding(4);
            this.s_inPanel.Name = "s_inPanel";
            this.s_inPanel.Size = new System.Drawing.Size(564, 530);
            this.s_inPanel.TabIndex = 19;
            // 
            // signInDone
            // 
            this.signInDone.ActiveBorderThickness = 1;
            this.signInDone.ActiveCornerRadius = 1;
            this.signInDone.ActiveFillColor = System.Drawing.Color.Teal;
            this.signInDone.ActiveForecolor = System.Drawing.Color.White;
            this.signInDone.ActiveLineColor = System.Drawing.Color.Teal;
            this.signInDone.BackColor = System.Drawing.Color.White;
            this.signInDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInDone.BackgroundImage")));
            this.signInDone.ButtonText = "Sign In";
            this.signInDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInDone.ForeColor = System.Drawing.Color.Black;
            this.signInDone.IdleBorderThickness = 1;
            this.signInDone.IdleCornerRadius = 1;
            this.signInDone.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.signInDone.IdleForecolor = System.Drawing.Color.White;
            this.signInDone.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.signInDone.Location = new System.Drawing.Point(101, 418);
            this.signInDone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInDone.Name = "signInDone";
            this.signInDone.Size = new System.Drawing.Size(347, 63);
            this.signInDone.TabIndex = 0;
            this.signInDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInDone.Click += new System.EventHandler(this.signInDone_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(96, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "password";
            // 
            // uspass
            // 
            this.uspass.BorderColorFocused = System.Drawing.Color.Silver;
            this.uspass.BorderColorIdle = System.Drawing.Color.Silver;
            this.uspass.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.uspass.BorderThickness = 1;
            this.uspass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uspass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.uspass.ForeColor = System.Drawing.Color.Black;
            this.uspass.isPassword = false;
            this.uspass.Location = new System.Drawing.Point(93, 293);
            this.uspass.Margin = new System.Windows.Forms.Padding(5);
            this.uspass.Name = "uspass";
            this.uspass.Size = new System.Drawing.Size(359, 38);
            this.uspass.TabIndex = 7;
            this.uspass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usname
            // 
            this.usname.BorderColorFocused = System.Drawing.Color.Silver;
            this.usname.BorderColorIdle = System.Drawing.Color.Silver;
            this.usname.BorderColorMouseHover = System.Drawing.Color.SlateGray;
            this.usname.BorderThickness = 1;
            this.usname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usname.ForeColor = System.Drawing.Color.Black;
            this.usname.isPassword = false;
            this.usname.Location = new System.Drawing.Point(93, 187);
            this.usname.Margin = new System.Windows.Forms.Padding(5);
            this.usname.Name = "usname";
            this.usname.Size = new System.Drawing.Size(359, 38);
            this.usname.TabIndex = 6;
            this.usname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(215, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 42);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sign In";
            // 
            // signInBtn
            // 
            this.signInBtn.ActiveBorderThickness = 1;
            this.signInBtn.ActiveCornerRadius = 1;
            this.signInBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.signInBtn.ActiveForecolor = System.Drawing.Color.White;
            this.signInBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.signInBtn.BackColor = System.Drawing.Color.White;
            this.signInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInBtn.BackgroundImage")));
            this.signInBtn.ButtonText = "Sign in";
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.Black;
            this.signInBtn.IdleBorderThickness = 1;
            this.signInBtn.IdleCornerRadius = 1;
            this.signInBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(89)))));
            this.signInBtn.IdleForecolor = System.Drawing.Color.White;
            this.signInBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(89)))));
            this.signInBtn.Location = new System.Drawing.Point(311, 68);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(228, 63);
            this.signInBtn.TabIndex = 17;
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.ActiveBorderThickness = 1;
            this.signUpBtn.ActiveCornerRadius = 1;
            this.signUpBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.signUpBtn.ActiveForecolor = System.Drawing.Color.White;
            this.signUpBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.signUpBtn.BackColor = System.Drawing.Color.White;
            this.signUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpBtn.BackgroundImage")));
            this.signUpBtn.ButtonText = "Sign Up";
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.IdleBorderThickness = 1;
            this.signUpBtn.IdleCornerRadius = 1;
            this.signUpBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.signUpBtn.IdleForecolor = System.Drawing.Color.White;
            this.signUpBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.signUpBtn.Location = new System.Drawing.Point(76, 68);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(236, 63);
            this.signUpBtn.TabIndex = 16;
            this.signUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // close
            // 
            this.close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.BorderRadius = 0;
            this.close.ButtonText = "";
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.DisabledColor = System.Drawing.Color.Gray;
            this.close.Iconcolor = System.Drawing.Color.Transparent;
            this.close.Iconimage = global::IMDB.Properties.Resources.icons8_multiply_filled_50;
            this.close.Iconimage_right = null;
            this.close.Iconimage_right_Selected = null;
            this.close.Iconimage_Selected = null;
            this.close.IconMarginLeft = 0;
            this.close.IconMarginRight = 0;
            this.close.IconRightVisible = true;
            this.close.IconRightZoom = 0D;
            this.close.IconVisible = true;
            this.close.IconZoom = 90D;
            this.close.IsTab = false;
            this.close.Location = new System.Drawing.Point(557, -2);
            this.close.Margin = new System.Windows.Forms.Padding(5);
            this.close.Name = "close";
            this.close.Normalcolor = System.Drawing.Color.Transparent;
            this.close.OnHovercolor = System.Drawing.Color.Transparent;
            this.close.OnHoverTextColor = System.Drawing.Color.White;
            this.close.selected = false;
            this.close.Size = new System.Drawing.Size(64, 53);
            this.close.TabIndex = 72;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Textcolor = System.Drawing.Color.White;
            this.close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.close);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.s_inPanel);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.s_upPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Size = new System.Drawing.Size(612, 759);
            this.Load += new System.EventHandler(this.login_Load);
            this.s_upPanel.ResumeLayout(false);
            this.s_upPanel.PerformLayout();
            this.s_inPanel.ResumeLayout(false);
            this.s_inPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 signInBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpDone;
        private System.Windows.Forms.Panel s_upPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox upass;
        private Bunifu.Framework.UI.BunifuMetroTextbox uname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox s_name;
        private Bunifu.Framework.UI.BunifuMetroTextbox f_name;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 signInDone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel s_inPanel;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox uspass;
        private Bunifu.Framework.UI.BunifuMetroTextbox usname;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpBtn;
        private Bunifu.Framework.UI.BunifuFlatButton close;
    }
}
