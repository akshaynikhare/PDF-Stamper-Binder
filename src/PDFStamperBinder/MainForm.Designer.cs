namespace PDFStamperBinder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addFileButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveAllButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpButton = new System.Windows.Forms.ToolStripButton();
            this.moveDownButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Setting_stamp = new System.Windows.Forms.ToolStripButton();
            this.config = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.completeButton = new System.Windows.Forms.ToolStripButton();
            this.StampButton = new System.Windows.Forms.ToolStripButton();
            this.complete_StampButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.addFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.helpLabel = new System.Windows.Forms.Label();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputListBox
            // 
            this.inputListBox.AllowDrop = true;
            this.inputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(4, 30);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(749, 277);
            this.inputListBox.TabIndex = 0;
            this.inputListBox.SelectedIndexChanged += new System.EventHandler(this.inputListBox_SelectedIndexChanged);
            this.inputListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputListBox_DragDrop);
            this.inputListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputListBox_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileButton,
            this.RemoveButton,
            this.RemoveAllButton,
            this.toolStripSeparator1,
            this.moveUpButton,
            this.moveDownButton,
            this.toolStripSeparator2,
            this.Setting_stamp,
            this.config,
            this.toolStripSeparator3,
            this.completeButton,
            this.StampButton,
            this.complete_StampButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addFileButton
            // 
            this.addFileButton.Image = ((System.Drawing.Image)(resources.GetObject("addFileButton.Image")));
            this.addFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(77, 22);
            this.addFileButton.Text = "Add file...";
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveButton.Text = "Remove selected";
            this.RemoveButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveAllButton.Enabled = false;
            this.RemoveAllButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveAllButton.Image")));
            this.RemoveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveAllButton.Text = "Remove All ";
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // moveUpButton
            // 
            this.moveUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveUpButton.Enabled = false;
            this.moveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("moveUpButton.Image")));
            this.moveUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(23, 22);
            this.moveUpButton.Text = "Move up";
            this.moveUpButton.Click += new System.EventHandler(this.moveItemButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveDownButton.Enabled = false;
            this.moveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("moveDownButton.Image")));
            this.moveDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(23, 22);
            this.moveDownButton.Text = "toolStripButton3";
            this.moveDownButton.Click += new System.EventHandler(this.moveItemButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Setting_stamp
            // 
            this.Setting_stamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Setting_stamp.Image = ((System.Drawing.Image)(resources.GetObject("Setting_stamp.Image")));
            this.Setting_stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Setting_stamp.Name = "Setting_stamp";
            this.Setting_stamp.Size = new System.Drawing.Size(23, 22);
            this.Setting_stamp.Text = "toolStripButton1";
            this.Setting_stamp.Click += new System.EventHandler(this.Setting_stamp_Click);
            // 
            // config
            // 
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(200, 25);
            this.config.DropDownClosed += new System.EventHandler(this.Config_DropDownClosed);
            this.config.Click += new System.EventHandler(this.Config_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // completeButton
            // 
            this.completeButton.AutoSize = false;
            this.completeButton.Enabled = false;
            this.completeButton.Image = ((System.Drawing.Image)(resources.GetObject("completeButton.Image")));
            this.completeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(54, 22);
            this.completeButton.Text = "Bind";
            this.completeButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // StampButton
            // 
            this.StampButton.Enabled = false;
            this.StampButton.Image = ((System.Drawing.Image)(resources.GetObject("StampButton.Image")));
            this.StampButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StampButton.Name = "StampButton";
            this.StampButton.Size = new System.Drawing.Size(67, 22);
            this.StampButton.Text = "Stamp !";
            this.StampButton.Click += new System.EventHandler(this.StampButton_Click);
            // 
            // complete_StampButton
            // 
            this.complete_StampButton.Enabled = false;
            this.complete_StampButton.Image = ((System.Drawing.Image)(resources.GetObject("complete_StampButton.Image")));
            this.complete_StampButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.complete_StampButton.Name = "complete_StampButton";
            this.complete_StampButton.Size = new System.Drawing.Size(105, 22);
            this.complete_StampButton.Text = "Bind + Stamp !";
            this.complete_StampButton.Click += new System.EventHandler(this.Complete_StampButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pdf";
            this.saveFileDialog.Filter = "PDF documents|*.pdf|All files|*.*";
            // 
            // addFileDialog
            // 
            this.addFileDialog.DefaultExt = "pdf";
            this.addFileDialog.Filter = "PDF documents|*.pdf";
            this.addFileDialog.Multiselect = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(4, 314);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(749, 16);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // helpLabel
            // 
            this.helpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel.AutoSize = true;
            this.helpLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpLabel.Location = new System.Drawing.Point(4, 314);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(0, 13);
            this.helpLabel.TabIndex = 3;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.ToolStripComboBox1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 333);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.inputListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(437, 229);
            this.Name = "MainForm";
            this.Text = "PDF Stamper & Binder By Akshay";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addFileButton;
        private System.Windows.Forms.ToolStripButton moveUpButton;
        private System.Windows.Forms.ToolStripButton moveDownButton;
        private System.Windows.Forms.ToolStripButton completeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog addFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.ToolStripButton RemoveButton;
        private System.Windows.Forms.ToolStripButton complete_StampButton;
        private System.Windows.Forms.ToolStripButton RemoveAllButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton StampButton;
        private System.Windows.Forms.ToolStripComboBox config;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton Setting_stamp;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

