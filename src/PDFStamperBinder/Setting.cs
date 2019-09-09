using System;
using System.IO;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    public partial class Setting : Form
    {
        private static string fileext = ".ast";
        private static string SettingFolder = "Stamp_Template";
        private static Random random = new Random();
        private string tempDir = System.IO.Directory.GetCurrentDirectory() + "\\temp\\";

        public Setting()
        {
            InitializeComponent();
        }

        private void updateUI()
        {
            throw new NotImplementedException();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(SettingFolder))
            {
                Directory.CreateDirectory(SettingFolder);
            }
            SettingList.Items.Clear();

            foreach (string file in Directory.EnumerateFiles(SettingFolder, "*" + fileext))
            {
                SettingList.Items.Add(Path.GetFileNameWithoutExtension(file)); // to replace the specific text with blankfile);
                //string contents = File.ReadAllText(file);
            }
        }

        private void UpdateSetting_Click(object sender, EventArgs e)
        {
            //String data = w.Text+"," + h.Text + "," + x.Text + "," + y.Text + "," + anchor.SelectedIndex.ToString()+ seprator+"\n" ;
            // File.WriteAllText(SettingFolder + "\\" + SettingList.SelectedItem + Fileext,data+html.Text);
        }

        private void BtnPageSetup_Click(object sender, EventArgs e)
        {
            pageSetup.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (SettingList.SelectedItem != null)
            {
                MessageBox.Show("not programed !already exist..");
                //File.Delete(SettingFolder + "\\" + SettingList.SelectedItem + fileext);
                //SettingList.Items.Remove(SettingList.SelectedItem);
                html.Text = "";
            }
            updateUI();
        }
    }
}