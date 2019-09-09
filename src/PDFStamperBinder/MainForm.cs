
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    public partial class MainForm : Form
    {

        static string fileext = ".ast";
        static string SettingFolder = "stamp_Setting";

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
                }else
                {
                    StampButton.Enabled = true;
                }

                completeButton.Enabled = complete_StampButton.Enabled=  false;
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
            var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            Array.Sort(fileNames);

            foreach (var file in fileNames)
            {
               // AddInputFile(file);
            }

            UpdateUI();
        }

        private void combineButton_Click(object sender, EventArgs e)
        {

            /*
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
             */
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

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        private void Config_DropDownClosed(object sender, EventArgs e)
        {


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

        private void Complete_StampButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not programed");
        }



        private void Config_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("stamp_Setting"))
            {
                Directory.CreateDirectory("stamp_Setting");
            }
            config.Items.Clear();

            foreach (string file in Directory.EnumerateFiles(SettingFolder, "*" + fileext))
            {
                config.Items.Add(Path.GetFileNameWithoutExtension(file)); // to replace the specific text with blankfile);
                //string contents = File.ReadAllText(file);
                if (config.Items.Count > 0) config.SelectedItem=config.Items[0] ;
                
            }

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        private void StampButton_Click(object sender, EventArgs e)
        {
            if(config.SelectedIndex >= 0) { 
                
                    progressBar.Visible = true;
                    this.Enabled = false;
                    for (int i = 0; i < inputListBox.Items.Count; i++)
                    {

                    string stampname = System.IO.Directory.GetCurrentDirectory() + "\\temp\\" +RandomString(10) +".png";
                    string k = System.IO.File.ReadAllText(SettingFolder + "\\" + config.SelectedItem.ToString() + fileext);

                    html2image tt = new html2image(k, System.IO.Directory.GetCurrentDirectory() + "\\"+ SettingFolder );

                    int sc = k.IndexOf("$-->");
                    string[] sl = k.Substring(5, sc - 5).Split(',');
                    tt.transprencyKey(System.Drawing.Color.White);
                    tt.Generate(stampname, Convert.ToInt32(sl[0]), Convert.ToInt32(sl[1]));
                    tt.close();
                                       
                    //System.Diagnostics.Process.Start(stampname);
                    
                    string outpath = Path.GetDirectoryName((string)inputListBox.Items[i]) + "\\";
                    outpath += Path.GetFileNameWithoutExtension((string)inputListBox.Items[i]) + "_stamped";
                    outpath += Path.GetExtension((string)inputListBox.Items[i]) ;
                    Stamper smp = new Stamper();
                    smp.PdfStamp(outpath, stampname, (string)inputListBox.Items[i]);
                    System.Diagnostics.Process.Start(outpath);
                    progressBar.Value = (int)(((i + 1) / (double)inputListBox.Items.Count) * 100);

                    }


                    this.Enabled = true;
                    progressBar.Visible = false;
            }
            else
            {
                MessageBox.Show("Select setting");
            }

        }
    }
}