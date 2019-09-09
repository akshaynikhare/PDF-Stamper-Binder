namespace PDFStamperBinder
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.SettingList = new System.Windows.Forms.ListBox();
            this.AddSetting = new System.Windows.Forms.Button();
            this.RemoveSetting = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anchor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.html = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateSetting = new System.Windows.Forms.Button();
            this.plane = new System.Windows.Forms.Panel();
            this.paper = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sviw = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.paperkind = new System.Windows.Forms.ComboBox();
            this.oriantation = new System.Windows.Forms.ComboBox();
            this.w = new System.Windows.Forms.NumericUpDown();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.angle = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.transprancy = new System.Windows.Forms.Label();
            this.plane.SuspendLayout();
            this.paper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingList
            // 
            this.SettingList.FormattingEnabled = true;
            this.SettingList.Location = new System.Drawing.Point(12, 40);
            this.SettingList.Name = "SettingList";
            this.SettingList.Size = new System.Drawing.Size(192, 589);
            this.SettingList.TabIndex = 1;
            this.SettingList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.refershlist);
            this.SettingList.SelectedIndexChanged += new System.EventHandler(this.refershlist);
            this.SettingList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refershlist);
            // 
            // AddSetting
            // 
            this.AddSetting.Location = new System.Drawing.Point(12, 12);
            this.AddSetting.Name = "AddSetting";
            this.AddSetting.Size = new System.Drawing.Size(60, 25);
            this.AddSetting.TabIndex = 2;
            this.AddSetting.Text = "Add";
            this.AddSetting.UseVisualStyleBackColor = true;
            this.AddSetting.Click += new System.EventHandler(this.AddSetting_Click);
            // 
            // RemoveSetting
            // 
            this.RemoveSetting.Enabled = false;
            this.RemoveSetting.Location = new System.Drawing.Point(144, 12);
            this.RemoveSetting.Name = "RemoveSetting";
            this.RemoveSetting.Size = new System.Drawing.Size(60, 25);
            this.RemoveSetting.TabIndex = 3;
            this.RemoveSetting.Text = "Remove";
            this.RemoveSetting.UseVisualStyleBackColor = true;
            this.RemoveSetting.Click += new System.EventHandler(this.RemoveSetting_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Y";
            // 
            // anchor
            // 
            this.anchor.Items.AddRange(new object[] {
            "top-left",
            "top-right",
            "bottom-left",
            "bottom-right"});
            this.anchor.Location = new System.Drawing.Point(580, 12);
            this.anchor.Name = "anchor";
            this.anchor.Size = new System.Drawing.Size(70, 21);
            this.anchor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Anchor";
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(210, 367);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(833, 262);
            this.webBrowser1.TabIndex = 25;
            // 
            // html
            // 
            this.html.Location = new System.Drawing.Point(210, 67);
            this.html.Multiline = true;
            this.html.Name = "html";
            this.html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.html.Size = new System.Drawing.Size(527, 294);
            this.html.TabIndex = 26;
            this.html.TextChanged += new System.EventHandler(this.Html_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 22);
            this.button2.TabIndex = 28;
            this.button2.Text = "Genrate image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UpdateSetting
            // 
            this.UpdateSetting.Enabled = false;
            this.UpdateSetting.Location = new System.Drawing.Point(78, 12);
            this.UpdateSetting.Name = "UpdateSetting";
            this.UpdateSetting.Size = new System.Drawing.Size(60, 25);
            this.UpdateSetting.TabIndex = 4;
            this.UpdateSetting.Text = "Update";
            this.UpdateSetting.UseVisualStyleBackColor = true;
            this.UpdateSetting.Click += new System.EventHandler(this.UpdateSetting_Click);
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plane.Controls.Add(this.paper);
            this.plane.Location = new System.Drawing.Point(743, 67);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(300, 294);
            this.plane.TabIndex = 29;
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paper.Controls.Add(this.label4);
            this.paper.Controls.Add(this.sviw);
            this.paper.Location = new System.Drawing.Point(2, 2);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(192, 291);
            this.paper.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // sviw
            // 
            this.sviw.BackColor = System.Drawing.SystemColors.Info;
            this.sviw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sviw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sviw.Location = new System.Drawing.Point(3, 3);
            this.sviw.Name = "sviw";
            this.sviw.Size = new System.Drawing.Size(51, 41);
            this.sviw.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh Preiview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // paperkind
            // 
            this.paperkind.Location = new System.Drawing.Point(961, 12);
            this.paperkind.Name = "paperkind";
            this.paperkind.Size = new System.Drawing.Size(82, 21);
            this.paperkind.TabIndex = 31;
            this.paperkind.SelectedIndexChanged += new System.EventHandler(this.Paper_SelectedIndexChanged);
            // 
            // oriantation
            // 
            this.oriantation.Location = new System.Drawing.Point(873, 12);
            this.oriantation.Name = "oriantation";
            this.oriantation.Size = new System.Drawing.Size(82, 21);
            this.oriantation.TabIndex = 32;
            this.oriantation.SelectedIndexChanged += new System.EventHandler(this.Paper_SelectedIndexChanged);
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(225, 15);
            this.w.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(38, 20);
            this.w.TabIndex = 33;
            this.w.ValueChanged += new System.EventHandler(this.W_ValueChanged);
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(281, 15);
            this.h.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(38, 20);
            this.h.TabIndex = 34;
            this.h.ValueChanged += new System.EventHandler(this.H_ValueChanged);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(336, 14);
            this.x.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(38, 20);
            this.x.TabIndex = 35;
            this.x.ValueChanged += new System.EventHandler(this.pos_ValueChanged);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(399, 14);
            this.y.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(38, 20);
            this.y.TabIndex = 36;
            this.y.ValueChanged += new System.EventHandler(this.pos_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(262, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 38;
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(222, 47);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(34, 13);
            this.angle.TabIndex = 37;
            this.angle.Text = "Angle";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(427, 45);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 40;
            // 
            // transprancy
            // 
            this.transprancy.AutoSize = true;
            this.transprancy.Location = new System.Drawing.Point(359, 47);
            this.transprancy.Name = "transprancy";
            this.transprancy.Size = new System.Drawing.Size(62, 13);
            this.transprancy.TabIndex = 39;
            this.transprancy.Text = "transprancy";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 641);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.transprancy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Controls.Add(this.oriantation);
            this.Controls.Add(this.paperkind);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.html);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anchor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateSetting);
            this.Controls.Add(this.RemoveSetting);
            this.Controls.Add(this.AddSetting);
            this.Controls.Add(this.SettingList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.plane.ResumeLayout(false);
            this.paper.ResumeLayout(false);
            this.paper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox SettingList;
        private System.Windows.Forms.Button AddSetting;
        private System.Windows.Forms.Button RemoveSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anchor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox html;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdateSetting;
        private System.Windows.Forms.Panel plane;
        private System.Windows.Forms.Panel sviw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox paperkind;
        private System.Windows.Forms.Panel paper;
        private System.Windows.Forms.ComboBox oriantation;
        private System.Windows.Forms.NumericUpDown w;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.NumericUpDown y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label transprancy;
    }
}