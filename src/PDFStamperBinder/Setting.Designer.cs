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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.anchor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.html = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.angle = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.transprancy = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pageSetup = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingList
            // 
            this.SettingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingList.FormattingEnabled = true;
            this.SettingList.Location = new System.Drawing.Point(0, 226);
            this.SettingList.Margin = new System.Windows.Forms.Padding(0);
            this.SettingList.Name = "SettingList";
            this.SettingList.Size = new System.Drawing.Size(200, 235);
            this.SettingList.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(69, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "W";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anchor
            // 
            this.anchor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.anchor.Items.AddRange(new object[] {
            "top-left",
            "top-right",
            "bottom-left",
            "bottom-right"});
            this.anchor.Location = new System.Drawing.Point(71, 6);
            this.anchor.Name = "anchor";
            this.anchor.Size = new System.Drawing.Size(102, 21);
            this.anchor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Anchor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // html
            // 
            this.html.Dock = System.Windows.Forms.DockStyle.Fill;
            this.html.Location = new System.Drawing.Point(200, 0);
            this.html.Margin = new System.Windows.Forms.Padding(0);
            this.html.Multiline = true;
            this.html.Name = "html";
            this.html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.html.Size = new System.Drawing.Size(292, 461);
            this.html.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(135, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 34);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh Preiview";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // w
            // 
            this.w.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w.Location = new System.Drawing.Point(33, 3);
            this.w.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(64, 20);
            this.w.TabIndex = 33;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(71, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown1.TabIndex = 38;
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angle.Location = new System.Drawing.Point(3, 60);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(62, 32);
            this.angle.TabIndex = 37;
            this.angle.Text = "Angle";
            this.angle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Location = new System.Drawing.Point(71, 37);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown2.TabIndex = 40;
            // 
            // transprancy
            // 
            this.transprancy.AutoSize = true;
            this.transprancy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transprancy.Location = new System.Drawing.Point(3, 30);
            this.transprancy.Name = "transprancy";
            this.transprancy.Size = new System.Drawing.Size(62, 30);
            this.transprancy.TabIndex = 39;
            this.transprancy.Text = "transprancy";
            this.transprancy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.html, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.printPreview, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // printPreview
            // 
            this.printPreview.AutoZoom = false;
            this.printPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreview.Document = this.printDocument;
            this.printPreview.Location = new System.Drawing.Point(492, 0);
            this.printPreview.Margin = new System.Windows.Forms.Padding(0);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(292, 461);
            this.printPreview.TabIndex = 27;
            this.printPreview.Zoom = 0.28352941176470586D;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SettingList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 461);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 226);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPageSetup, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel4.TabIndex = 43;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.AutoSize = true;
            this.btnPageSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPageSetup.Location = new System.Drawing.Point(123, 3);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(74, 34);
            this.btnPageSetup.TabIndex = 41;
            this.btnPageSetup.Text = "page setup";
            this.btnPageSetup.UseVisualStyleBackColor = true;
            this.btnPageSetup.Click += new System.EventHandler(this.BtnPageSetup_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.h, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.y, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.x, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.w, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel5.TabIndex = 44;
            // 
            // h
            // 
            this.h.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h.Location = new System.Drawing.Point(133, 3);
            this.h.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(64, 20);
            this.h.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(103, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "h";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y
            // 
            this.y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y.Location = new System.Drawing.Point(133, 30);
            this.y.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(64, 20);
            this.y.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Y";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x
            // 
            this.x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x.Location = new System.Drawing.Point(33, 30);
            this.x.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(64, 20);
            this.x.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.anchor, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.transprancy, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown2, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.angle, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 92);
            this.tableLayoutPanel6.TabIndex = 45;
            // 
            // pageSetup
            // 
            this.pageSetup.Document = this.printDocument;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox SettingList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox anchor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox html;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown w;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label transprancy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPageSetup;
        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}