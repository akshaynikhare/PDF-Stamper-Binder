using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    public partial class MainForm : Form
    {
        private static string fileext = ".ast";
        private static string SettingFolder = "Stamp_Template";
        private static Random random = new Random();
        private string tempDir = System.IO.Directory.GetCurrentDirectory() + "\\temp\\";
        private UCS.Corner anchor = UCS.Corner.TopLeft;
        private float transprancy = 1f;
        private float angle = 0f;
        private int x = 0, y = 0;

        public MainForm()
        {
            InitializeComponent();
            UpdateUI();
            config.Items.Clear();
        }

        public void AddInputFile(string file)
        {
            switch (Combiner.TestSourceFile(file))
            {
                case Combiner.SourceTestResult.Unreadable:
                    MessageBox.Show(string.Format("File could not be opened as a PDF document:\n\n{0}", file), "Illegal file type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case Combiner.SourceTestResult.Protected:
                    MessageBox.Show(string.Format("PDF document does not allow copying:\n\n{0}", file), "Permission denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;

                case Combiner.SourceTestResult.Ok:
                    inputListBox.Items.Add(file);
                    break;
            }
        }

        public void UpdateUI()
        {
            if (inputListBox.Items.Count < 2)
            {
                if (inputListBox.Items.Count < 1)
                {
                    StampButton.Enabled = false;
                }
                else
                {
                    StampButton.Enabled = true;
                }

                completeButton.Enabled = complete_StampButton.Enabled = false;
                RemoveAllButton.Enabled = false;
                helpLabel.Text = "Drop PDF-documents in the box above, or choose \"add document\" from the toolbar";
            }
            else
            {
                completeButton.Enabled = complete_StampButton.Enabled = StampButton.Enabled = true;
                RemoveAllButton.Enabled = true;
                helpLabel.Text = "Click the \"bind!\" button when you are done adding documents";
            }

            if (inputListBox.SelectedIndex < 0)
            {
                RemoveButton.Enabled = moveUpButton.Enabled = moveDownButton.Enabled = false;
            }
            else
            {
                RemoveButton.Enabled = true;
                moveUpButton.Enabled = (inputListBox.SelectedIndex > 0);
                moveDownButton.Enabled = (inputListBox.SelectedIndex < inputListBox.Items.Count - 1);
            }
        }

        private void inputListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void inputListBox_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            Array.Sort(fileNames);

            foreach (var file in fileNames)
            {
                // AddInputFile(file);
            }

            UpdateUI();
        }

        private void combineButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var combiner = new Combiner(saveFileDialog.FileName))
                {
                    progressBar.Visible = true;
                    this.Enabled = false;

                    for (int i = 0; i < inputListBox.Items.Count; i++)
                    {
                        combiner.AddFiletoBind((string)inputListBox.Items[i]);
                        progressBar.Value = (int)(((i + 1) / (double)inputListBox.Items.Count) * 100);
                    }

                    this.Enabled = true;
                    progressBar.Visible = false;
                }

                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in addFileDialog.FileNames)
                {
                    AddInputFile(file);
                }

                UpdateUI();
            }
        }

        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            inputListBox.Items.Remove(inputListBox.SelectedItem);
        }

        private void moveItemButton_Click(object sender, EventArgs e)
        {
            object dataItem = inputListBox.SelectedItem;
            int index = inputListBox.SelectedIndex;

            if (sender == moveUpButton)
                index--;
            if (sender == moveDownButton)
                index++;

            inputListBox.Items.Remove(dataItem);
            inputListBox.Items.Insert(index, dataItem);

            inputListBox.SelectedIndex = index;
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            inputListBox.Items.Clear();
            UpdateUI();
        }

        private void Setting_stamp_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            //set.TopMost = true;
            set.ShowDialog();
            Updatelist();
        }

        public void Updatelist()
        {
            //config.Items.Clear();

            //config.SelectedItem = 0;
        }

        private void StampButton_Click(object sender, EventArgs e)
        {
            if (config.SelectedIndex >= 0)
            {
                progressBar.Visible = true;
                this.Enabled = false;

                string stampname = genrateStampImage();

                for (int i = 0; i < inputListBox.Items.Count; i++)
                {
                    if (File.Exists(stampname))
                    {
                        if (File.Exists((string)inputListBox.Items[i]))
                        {
                            string outpath = Path.GetDirectoryName((string)inputListBox.Items[i]) + "\\";
                            outpath += Path.GetFileNameWithoutExtension((string)inputListBox.Items[i]) + "_stamped";
                            outpath += Path.GetExtension((string)inputListBox.Items[i]);


                            if (File.Exists(outpath))
                            {

                                DialogResult dialogResult = MessageBox.Show("File aleard exist.\n" + outpath, "Over write ", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    File.Delete(outpath);
                                    Stamper smp = new Stamper();
                                    smp.transprency = transprancy;
                                    smp.rotation = angle;
                                    smp.x = x;
                                    smp.y = y;
                                    smp.anchor = anchor;
                                    smp.PdfStamp(outpath, stampname, (string)inputListBox.Items[i]);


                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    //do something else
                                }

                            }
                            else
                            {
                                Stamper smp = new Stamper();
                                smp.transprency = transprancy;
                                smp.rotation = angle;
                                smp.x = x;
                                smp.y = y;
                                smp.anchor = anchor;
                                smp.PdfStamp(outpath, stampname, (string)inputListBox.Items[i]);


                            }

                            System.Diagnostics.Process.Start(outpath);
                            progressBar.Value = (int)(((i + 1) / (double)inputListBox.Items.Count) * 100);
                        }
                        else
                        {
                            MessageBox.Show("file :" + (string)inputListBox.Items[i] + " \n Does not exist ! skipping file ...", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error with the stamp file input & genration.", "Error");
                    }
                }

                this.Enabled = true;
                progressBar.Visible = false;
                //File.Delete(stampname);
            }
            else
            {
                MessageBox.Show("Select setting");
            }
        }

        private string genrateStampImage()
        {
            string stampname = tempDir + RandomString(10) + ".png";
            string k = System.IO.File.ReadAllText(SettingFolder + "\\" + config.SelectedItem.ToString() + fileext);

            html2image tt = new html2image(k, System.IO.Directory.GetCurrentDirectory() + "\\" + SettingFolder);

            int sc = k.IndexOf("$-->");
            string[] sl = k.Substring(5, sc - 5).Split(',');
            tt.transprencyKey(System.Drawing.Color.White);
            x = Convert.ToInt32(sl[2]);
            y = Convert.ToInt32(sl[3]);
            anchor = (UCS.Corner)Convert.ToInt32(sl[4]);
            transprancy = Convert.ToInt32(sl[5]);
            angle = Convert.ToInt32(sl[6]);

            tt.Generate(stampname, Convert.ToInt32(sl[0]), Convert.ToInt32(sl[1]), angle);
            tt.close();

            return stampname;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(SettingFolder))
            {
                Directory.CreateDirectory(SettingFolder);
            }

            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
            }

            config.Items.Clear();

            foreach (string file in Directory.EnumerateFiles(SettingFolder, "*" + fileext))
            {
                config.Items.Add(Path.GetFileNameWithoutExtension(file)); // to replace the specific text with blankfile);
                //string contents = File.ReadAllText(file);
                if (config.Items.Count > 0) config.SelectedItem = config.Items[0];
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var bb = new About();
            bb.Show();
        }

        private void StampAndBindButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string stampname = genrateStampImage();
                string pdfname = tempDir + RandomString(10) + ".pdf";

                using (var combiner = new Combiner(pdfname))
                {
                    progressBar.Visible = true;
                    this.Enabled = false;

                    for (int i = 0; i < inputListBox.Items.Count; i++)
                    {
                        combiner.AddFiletoBind((string)inputListBox.Items[i]);
                        progressBar.Value = (int)(((i + 1) / (double)inputListBox.Items.Count) * 90);
                    }

                    this.Enabled = true;
                    progressBar.Visible = false;
                }

                if (File.Exists(stampname))
                {
                    if (File.Exists(pdfname))
                    {
                        Stamper smp = new Stamper();
                        smp.transprency = transprancy;
                        smp.rotation = angle;
                        smp.x = x;
                        smp.y = y;
                        smp.anchor = anchor;
                        smp.PdfStamp(saveFileDialog.FileName, stampname, pdfname);
                    }
                    else
                    {
                        MessageBox.Show("Binded file \n Does not exist ! skipping file ... \n no file genrated", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Error with the stamp file input & genration.", "Error");
                }

                System.Diagnostics.Process.Start(saveFileDialog.FileName);
                File.Delete(stampname);
                File.Delete(pdfname);
            }
        }
    }
}