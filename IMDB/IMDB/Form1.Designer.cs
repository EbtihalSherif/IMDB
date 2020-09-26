namespace IMDB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.joinLbl = new System.Windows.Forms.Label();
            this.searchType = new Bunifu.Framework.UI.BunifuDropdown();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTool = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_viewMovie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Manage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTool)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(296, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 735);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(139, 132);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(667, 4);
            this.bunifuGradientPanel2.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel2.Location = new System.Drawing.Point(29, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 49);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(44, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "This week\'s top TV and movies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(63, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fan favorites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(41, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "What to watch";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbox.BorderColorFocused = System.Drawing.Color.Lavender;
            this.searchbox.BorderColorIdle = System.Drawing.Color.WhiteSmoke;
            this.searchbox.BorderColorMouseHover = System.Drawing.Color.GhostWhite;
            this.searchbox.BorderThickness = 3;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.Teal;
            this.searchbox.isPassword = false;
            this.searchbox.Location = new System.Drawing.Point(387, 21);
            this.searchbox.Margin = new System.Windows.Forms.Padding(5);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(680, 46);
            this.searchbox.TabIndex = 67;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox.OnValueChanged += new System.EventHandler(this.searchbox_OnValueChanged);
            // 
            // joinLbl
            // 
            this.joinLbl.AutoSize = true;
            this.joinLbl.BackColor = System.Drawing.Color.Transparent;
            this.joinLbl.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.joinLbl.Location = new System.Drawing.Point(1356, 2);
            this.joinLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joinLbl.Name = "joinLbl";
            this.joinLbl.Size = new System.Drawing.Size(217, 71);
            this.joinLbl.TabIndex = 70;
            this.joinLbl.Text = "Join Us";
            this.joinLbl.Click += new System.EventHandler(this.joinLbl_Click);
            // 
            // searchType
            // 
            this.searchType.BackColor = System.Drawing.Color.Goldenrod;
            this.searchType.BorderRadius = 3;
            this.searchType.DisabledColor = System.Drawing.Color.Transparent;
            this.searchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchType.ForeColor = System.Drawing.Color.LightCyan;
            this.searchType.Items = new string[] {
        "Title",
        "Rate above",
        "Rate below",
        "Year",
        "Director",
        "Actor",
        "Category"};
            this.searchType.Location = new System.Drawing.Point(920, 20);
            this.searchType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchType.Name = "searchType";
            this.searchType.NomalColor = System.Drawing.Color.Transparent;
            this.searchType.onHoverColor = System.Drawing.Color.LightGray;
            this.searchType.selectedIndex = -1;
            this.searchType.Size = new System.Drawing.Size(209, 48);
            this.searchType.TabIndex = 66;
            this.searchType.onItemSelected += new System.EventHandler(this.searchType_onItemSelected);
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.Transparent;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update Movie";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(-13, 337);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.updateBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(300, 59);
            this.updateBtn.TabIndex = 65;
            this.updateBtn.Text = "Update Movie";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.BorderRadius = 0;
            this.exitBtn.ButtonText = "";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitBtn.Iconimage = global::IMDB.Properties.Resources.icons8_multiply_filled_50;
            this.exitBtn.Iconimage_right = null;
            this.exitBtn.Iconimage_right_Selected = null;
            this.exitBtn.Iconimage_Selected = null;
            this.exitBtn.IconMarginLeft = 0;
            this.exitBtn.IconMarginRight = 0;
            this.exitBtn.IconRightVisible = true;
            this.exitBtn.IconRightZoom = 0D;
            this.exitBtn.IconVisible = true;
            this.exitBtn.IconZoom = 90D;
            this.exitBtn.IsTab = false;
            this.exitBtn.Location = new System.Drawing.Point(1560, -6);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.exitBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.exitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.exitBtn.selected = false;
            this.exitBtn.Size = new System.Drawing.Size(65, 59);
            this.exitBtn.TabIndex = 71;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Textcolor = System.Drawing.Color.White;
            this.exitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.ButtonText = "Delete Movie";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Iconimage")));
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 90D;
            this.deleteBtn.IsTab = false;
            this.deleteBtn.Location = new System.Drawing.Point(-13, 270);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(300, 59);
            this.deleteBtn.TabIndex = 64;
            this.deleteBtn.Text = "Delete Movie";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IMDB.Properties.Resources.www_imdb_logo__CB443130112_;
            this.pictureBox5.Location = new System.Drawing.Point(4, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(307, 87);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 0;
            this.addBtn.ButtonText = "Add Movie";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addBtn.Iconimage")));
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 0;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 90D;
            this.addBtn.IsTab = false;
            this.addBtn.Location = new System.Drawing.Point(-13, 203);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.addBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.addBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(300, 59);
            this.addBtn.TabIndex = 63;
            this.addBtn.Text = "Add Movie";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Textcolor = System.Drawing.Color.White;
            this.addBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchTool
            // 
            this.searchTool.BackColor = System.Drawing.Color.Transparent;
            this.searchTool.Image = ((System.Drawing.Image)(resources.GetObject("searchTool.Image")));
            this.searchTool.ImageActive = null;
            this.searchTool.Location = new System.Drawing.Point(337, 21);
            this.searchTool.Margin = new System.Windows.Forms.Padding(4);
            this.searchTool.Name = "searchTool";
            this.searchTool.Size = new System.Drawing.Size(53, 46);
            this.searchTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchTool.TabIndex = 68;
            this.searchTool.TabStop = false;
            this.searchTool.Zoom = 10;
            this.searchTool.Click += new System.EventHandler(this.searchTool_Click);
            // 
            // btn_viewMovie
            // 
            this.btn_viewMovie.Activecolor = System.Drawing.Color.Transparent;
            this.btn_viewMovie.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewMovie.BorderRadius = 0;
            this.btn_viewMovie.ButtonText = "View All Movies";
            this.btn_viewMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewMovie.DisabledColor = System.Drawing.Color.Gray;
            this.btn_viewMovie.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_viewMovie.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_viewMovie.Iconimage")));
            this.btn_viewMovie.Iconimage_right = null;
            this.btn_viewMovie.Iconimage_right_Selected = null;
            this.btn_viewMovie.Iconimage_Selected = null;
            this.btn_viewMovie.IconMarginLeft = 0;
            this.btn_viewMovie.IconMarginRight = 0;
            this.btn_viewMovie.IconRightVisible = true;
            this.btn_viewMovie.IconRightZoom = 0D;
            this.btn_viewMovie.IconVisible = true;
            this.btn_viewMovie.IconZoom = 90D;
            this.btn_viewMovie.IsTab = false;
            this.btn_viewMovie.Location = new System.Drawing.Point(-13, 406);
            this.btn_viewMovie.Margin = new System.Windows.Forms.Padding(5);
            this.btn_viewMovie.Name = "btn_viewMovie";
            this.btn_viewMovie.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_viewMovie.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_viewMovie.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_viewMovie.selected = false;
            this.btn_viewMovie.Size = new System.Drawing.Size(300, 59);
            this.btn_viewMovie.TabIndex = 72;
            this.btn_viewMovie.Text = "View All Movies";
            this.btn_viewMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewMovie.Textcolor = System.Drawing.Color.White;
            this.btn_viewMovie.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewMovie.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_report
            // 
            this.btn_report.Activecolor = System.Drawing.Color.Transparent;
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.BorderRadius = 0;
            this.btn_report.ButtonText = "View Report";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_report.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_report.Iconimage")));
            this.btn_report.Iconimage_right = null;
            this.btn_report.Iconimage_right_Selected = null;
            this.btn_report.Iconimage_Selected = null;
            this.btn_report.IconMarginLeft = 0;
            this.btn_report.IconMarginRight = 0;
            this.btn_report.IconRightVisible = true;
            this.btn_report.IconRightZoom = 0D;
            this.btn_report.IconVisible = true;
            this.btn_report.IconZoom = 90D;
            this.btn_report.IsTab = false;
            this.btn_report.Location = new System.Drawing.Point(-14, 475);
            this.btn_report.Margin = new System.Windows.Forms.Padding(5);
            this.btn_report.Name = "btn_report";
            this.btn_report.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_report.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_report.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_report.selected = false;
            this.btn_report.Size = new System.Drawing.Size(300, 59);
            this.btn_report.TabIndex = 73;
            this.btn_report.Text = "View Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Textcolor = System.Drawing.Color.White;
            this.btn_report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_Manage
            // 
            this.btn_Manage.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Manage.BackColor = System.Drawing.Color.Transparent;
            this.btn_Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Manage.BorderRadius = 0;
            this.btn_Manage.ButtonText = "Manage Actors And Directors";
            this.btn_Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Manage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Manage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Manage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Manage.Iconimage")));
            this.btn_Manage.Iconimage_right = null;
            this.btn_Manage.Iconimage_right_Selected = null;
            this.btn_Manage.Iconimage_Selected = null;
            this.btn_Manage.IconMarginLeft = 0;
            this.btn_Manage.IconMarginRight = 0;
            this.btn_Manage.IconRightVisible = true;
            this.btn_Manage.IconRightZoom = 0D;
            this.btn_Manage.IconVisible = true;
            this.btn_Manage.IconZoom = 90D;
            this.btn_Manage.IsTab = false;
            this.btn_Manage.Location = new System.Drawing.Point(-14, 544);
            this.btn_Manage.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Manage.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Manage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Manage.selected = false;
            this.btn_Manage.Size = new System.Drawing.Size(300, 59);
            this.btn_Manage.TabIndex = 74;
            this.btn_Manage.Text = "Manage Actors And Directors";
            this.btn_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Manage.Textcolor = System.Drawing.Color.White;
            this.btn_Manage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Activecolor = System.Drawing.Color.Transparent;
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_profile.BorderRadius = 0;
            this.btn_profile.ButtonText = "Profile";
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.DisabledColor = System.Drawing.Color.Gray;
            this.btn_profile.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_profile.Iconimage")));
            this.btn_profile.Iconimage_right = null;
            this.btn_profile.Iconimage_right_Selected = null;
            this.btn_profile.Iconimage_Selected = null;
            this.btn_profile.IconMarginLeft = 0;
            this.btn_profile.IconMarginRight = 0;
            this.btn_profile.IconRightVisible = true;
            this.btn_profile.IconRightZoom = 0D;
            this.btn_profile.IconVisible = true;
            this.btn_profile.IconZoom = 90D;
            this.btn_profile.IsTab = false;
            this.btn_profile.Location = new System.Drawing.Point(-13, 134);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_profile.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_profile.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_profile.selected = false;
            this.btn_profile.Size = new System.Drawing.Size(300, 59);
            this.btn_profile.TabIndex = 75;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Textcolor = System.Drawing.Color.White;
            this.btn_profile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1615, 827);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_Manage);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_viewMovie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.searchTool);
            this.Controls.Add(this.joinLbl);
            this.Controls.Add(this.searchType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton exitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
        public Bunifu.Framework.UI.BunifuMetroTextbox searchbox;
        public Bunifu.Framework.UI.BunifuImageButton searchTool;
        public System.Windows.Forms.Label joinLbl;
        public Bunifu.Framework.UI.BunifuDropdown searchType;
        private Bunifu.Framework.UI.BunifuFlatButton btn_viewMovie;
        private Bunifu.Framework.UI.BunifuFlatButton btn_report;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Manage;
        public Bunifu.Framework.UI.BunifuFlatButton btn_profile;
    }
}

