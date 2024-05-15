namespace Astrology_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            cBtn = new FontAwesome.Sharp.IconButton();
            lBtn = new FontAwesome.Sharp.IconButton();
            hBtn = new FontAwesome.Sharp.IconButton();
            znBtn = new FontAwesome.Sharp.IconButton();
            zchBtn = new FontAwesome.Sharp.IconButton();
            zeBtn = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            homeBtn = new PictureBox();
            panelShadowSide = new Panel();
            panelTitle = new Panel();
            close = new FontAwesome.Sharp.IconButton();
            max = new FontAwesome.Sharp.IconButton();
            mini = new FontAwesome.Sharp.IconButton();
            currentLabel = new Label();
            currentIcon = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panel1 = new Panel();
            panelDesktop = new Panel();
            textBox1 = new TextBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeBtn).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).BeginInit();
            panelShadow.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(13, 32, 89);
            panelMenu.Controls.Add(cBtn);
            panelMenu.Controls.Add(lBtn);
            panelMenu.Controls.Add(hBtn);
            panelMenu.Controls.Add(znBtn);
            panelMenu.Controls.Add(zchBtn);
            panelMenu.Controls.Add(zeBtn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 577);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // cBtn
            // 
            cBtn.Dock = DockStyle.Top;
            cBtn.FlatAppearance.BorderSize = 0;
            cBtn.FlatStyle = FlatStyle.Flat;
            cBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBtn.ForeColor = Color.WhiteSmoke;
            cBtn.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            cBtn.IconColor = Color.WhiteSmoke;
            cBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cBtn.IconSize = 38;
            cBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cBtn.Location = new Point(0, 440);
            cBtn.Name = "cBtn";
            cBtn.Padding = new Padding(10, 0, 20, 0);
            cBtn.Size = new Size(220, 60);
            cBtn.TabIndex = 6;
            cBtn.Text = "O programie";
            cBtn.TextAlign = ContentAlignment.MiddleLeft;
            cBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cBtn.UseVisualStyleBackColor = true;
            cBtn.Click += cBtn_Click;
            // 
            // lBtn
            // 
            lBtn.Dock = DockStyle.Top;
            lBtn.FlatAppearance.BorderSize = 0;
            lBtn.FlatStyle = FlatStyle.Flat;
            lBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBtn.ForeColor = Color.WhiteSmoke;
            lBtn.IconChar = FontAwesome.Sharp.IconChar.Heart;
            lBtn.IconColor = Color.WhiteSmoke;
            lBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lBtn.IconSize = 38;
            lBtn.ImageAlign = ContentAlignment.MiddleLeft;
            lBtn.Location = new Point(0, 380);
            lBtn.Name = "lBtn";
            lBtn.Padding = new Padding(10, 0, 20, 0);
            lBtn.Size = new Size(220, 60);
            lBtn.TabIndex = 5;
            lBtn.Text = "Dopasowanie miłosne";
            lBtn.TextAlign = ContentAlignment.MiddleLeft;
            lBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            lBtn.UseVisualStyleBackColor = true;
            lBtn.Click += lBtn_Click;
            // 
            // hBtn
            // 
            hBtn.Dock = DockStyle.Top;
            hBtn.FlatAppearance.BorderSize = 0;
            hBtn.FlatStyle = FlatStyle.Flat;
            hBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hBtn.ForeColor = Color.WhiteSmoke;
            hBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            hBtn.IconColor = Color.WhiteSmoke;
            hBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            hBtn.IconSize = 38;
            hBtn.ImageAlign = ContentAlignment.MiddleLeft;
            hBtn.Location = new Point(0, 320);
            hBtn.Name = "hBtn";
            hBtn.Padding = new Padding(10, 0, 20, 0);
            hBtn.Size = new Size(220, 60);
            hBtn.TabIndex = 4;
            hBtn.Text = "Horoskop ";
            hBtn.TextAlign = ContentAlignment.MiddleLeft;
            hBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            hBtn.UseVisualStyleBackColor = true;
            hBtn.Click += hBtn_Click;
            // 
            // znBtn
            // 
            znBtn.Dock = DockStyle.Top;
            znBtn.FlatAppearance.BorderSize = 0;
            znBtn.FlatStyle = FlatStyle.Flat;
            znBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            znBtn.ForeColor = Color.WhiteSmoke;
            znBtn.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            znBtn.IconColor = Color.WhiteSmoke;
            znBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            znBtn.IconSize = 38;
            znBtn.ImageAlign = ContentAlignment.MiddleLeft;
            znBtn.Location = new Point(0, 260);
            znBtn.Name = "znBtn";
            znBtn.Padding = new Padding(10, 0, 20, 0);
            znBtn.Size = new Size(220, 60);
            znBtn.TabIndex = 3;
            znBtn.Text = "Zodiak numerologiczny";
            znBtn.TextAlign = ContentAlignment.MiddleLeft;
            znBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            znBtn.UseVisualStyleBackColor = true;
            znBtn.Click += znBtn_Click;
            // 
            // zchBtn
            // 
            zchBtn.Dock = DockStyle.Top;
            zchBtn.FlatAppearance.BorderSize = 0;
            zchBtn.FlatStyle = FlatStyle.Flat;
            zchBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zchBtn.ForeColor = Color.WhiteSmoke;
            zchBtn.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            zchBtn.IconColor = Color.WhiteSmoke;
            zchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            zchBtn.IconSize = 38;
            zchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            zchBtn.Location = new Point(0, 200);
            zchBtn.Name = "zchBtn";
            zchBtn.Padding = new Padding(10, 0, 20, 0);
            zchBtn.Size = new Size(220, 60);
            zchBtn.TabIndex = 2;
            zchBtn.Text = "Zodiak chinski";
            zchBtn.TextAlign = ContentAlignment.MiddleLeft;
            zchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            zchBtn.UseVisualStyleBackColor = true;
            zchBtn.Click += zchBtn_Click;
            // 
            // zeBtn
            // 
            zeBtn.Dock = DockStyle.Top;
            zeBtn.FlatAppearance.BorderSize = 0;
            zeBtn.FlatStyle = FlatStyle.Flat;
            zeBtn.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zeBtn.ForeColor = Color.WhiteSmoke;
            zeBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            zeBtn.IconColor = Color.WhiteSmoke;
            zeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            zeBtn.IconSize = 38;
            zeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            zeBtn.Location = new Point(0, 140);
            zeBtn.Name = "zeBtn";
            zeBtn.Padding = new Padding(10, 0, 20, 0);
            zeBtn.Size = new Size(220, 60);
            zeBtn.TabIndex = 1;
            zeBtn.Text = "Zodiak europejski";
            zeBtn.TextAlign = ContentAlignment.MiddleLeft;
            zeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            zeBtn.UseVisualStyleBackColor = true;
            zeBtn.Click += zeBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(homeBtn);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // homeBtn
            // 
            homeBtn.Image = Properties.Resources.astrology_logo_small;
            homeBtn.Location = new Point(26, -5);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(214, 145);
            homeBtn.TabIndex = 0;
            homeBtn.TabStop = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // panelShadowSide
            // 
            panelShadowSide.BackColor = Color.FromArgb(13, 16, 58);
            panelShadowSide.Dock = DockStyle.Left;
            panelShadowSide.Location = new Point(0, 0);
            panelShadowSide.Name = "panelShadowSide";
            panelShadowSide.Size = new Size(2, 495);
            panelShadowSide.TabIndex = 1;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(13, 32, 89);
            panelTitle.Controls.Add(close);
            panelTitle.Controls.Add(max);
            panelTitle.Controls.Add(mini);
            panelTitle.Controls.Add(currentLabel);
            panelTitle.Controls.Add(currentIcon);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(829, 80);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.IconChar = FontAwesome.Sharp.IconChar.X;
            close.IconColor = Color.Black;
            close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            close.IconSize = 32;
            close.Location = new Point(802, 7);
            close.Margin = new Padding(0);
            close.Name = "close";
            close.Size = new Size(22, 22);
            close.TabIndex = 4;
            close.TextImageRelation = TextImageRelation.TextAboveImage;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // max
            // 
            max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            max.IconChar = FontAwesome.Sharp.IconChar.Sign;
            max.IconColor = Color.Black;
            max.IconFont = FontAwesome.Sharp.IconFont.Auto;
            max.Location = new Point(768, 7);
            max.Name = "max";
            max.Size = new Size(22, 22);
            max.TabIndex = 3;
            max.UseVisualStyleBackColor = true;
            max.Click += max_Click;
            // 
            // mini
            // 
            mini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mini.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            mini.IconColor = Color.Black;
            mini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mini.Location = new Point(732, 7);
            mini.Name = "mini";
            mini.Size = new Size(22, 22);
            mini.TabIndex = 2;
            mini.UseVisualStyleBackColor = true;
            mini.Click += mini_Click;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentLabel.ForeColor = Color.WhiteSmoke;
            currentLabel.Location = new Point(78, 25);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(49, 25);
            currentLabel.TabIndex = 1;
            currentLabel.Text = "Start";
            // 
            // currentIcon
            // 
            currentIcon.BackColor = Color.FromArgb(13, 32, 89);
            currentIcon.ForeColor = Color.WhiteSmoke;
            currentIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            currentIcon.IconColor = Color.WhiteSmoke;
            currentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentIcon.IconSize = 46;
            currentIcon.Location = new Point(26, 12);
            currentIcon.Name = "currentIcon";
            currentIcon.Size = new Size(46, 48);
            currentIcon.TabIndex = 0;
            currentIcon.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(13, 16, 58);
            panelShadow.Controls.Add(panel1);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 80);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(829, 2);
            panelShadow.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, -80);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 579);
            panel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(13, 32, 89);
            panelDesktop.Controls.Add(panelShadowSide);
            panelDesktop.Controls.Add(textBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 82);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(829, 495);
            panelDesktop.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Wybrałeś datę: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 577);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homeBtn).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).EndInit();
            panelShadow.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton zeBtn;
        private FontAwesome.Sharp.IconButton lBtn;
        private FontAwesome.Sharp.IconButton hBtn;
        private FontAwesome.Sharp.IconButton znBtn;
        private FontAwesome.Sharp.IconButton zchBtn;
        private FontAwesome.Sharp.IconButton cBtn;
        private PictureBox homeBtn;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox currentIcon;
        private Label currentLabel;
        private Panel panelShadow;
        private Panel panelDesktop;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton mini;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton max;
        private Panel panelShadowSide;
        private Panel panel1;
    }
}
