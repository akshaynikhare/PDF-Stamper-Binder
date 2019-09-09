using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    public partial class Setting : Form
    {

        //List<stamp> stamps;
        static string fileext = ".ast";
        static readonly string SettingFolder = "stamp_Setting";
        static readonly char seprator = '$';

        public static string Fileext { get => fileext; set => fileext = value; }

        public Setting()
        {
            InitializeComponent();
                           
                
                paperkind.Items.Clear();
                PrinterSettings se = new PrinterSettings();
                foreach (PaperSize size in se.PaperSizes)
                paperkind.Items.Add(size.Kind.ToString().ToUpper());
                
                oriantation.Items.Clear();
                oriantation.Items.Add("portrait");
                oriantation.Items.Add("landscape");
                paperkind.SelectedItem = "A4";
                
                


        }

        private void refershlist()
        {
           if(SettingList.SelectedIndex > -1)
            {
               UpdateSetting.Enabled =RemoveSetting.Enabled= true;
               
                try
                {
                    string ts = File.ReadAllText(SettingFolder + "\\" + SettingList.SelectedItem + Fileext);
                    int schr = ts.IndexOf(seprator);
                    if (schr > 0) { 
                                            string[] sl = ts.Substring(0, schr).Split(',');
                                            if (sl.Length == 5)
                                            {
                                                w.Value = Convert.ToInt32(sl[0]);
                                                h.Value = Convert.ToInt32(sl[1]);
                                                x.Value = Convert.ToInt32(sl[2]);
                                                y.Value = Convert.ToInt32(sl[3]);
                                                anchor.SelectedIndex = Convert.ToInt32(sl[4]);
                                                ts = ts.Remove(0, schr+2);
                                                html.Text = ts;


                                                    string dirpath = System.IO.Directory.GetCurrentDirectory() + "\\stamp_Setting\\";
                                                    webBrowser1.DocumentText = html.Text.Replace("<?Setting_Dir?>", dirpath.Replace("\\", "/"));
                                                }
                                            else
                                            {
                                                throw new Exception("error in setting");
                                            }

                                }
                                else
                                {
                                    throw new Exception("error in setting");
                                }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

                if (oriantation.SelectedItem == null)
                {
                    oriantation.SelectedItem = "portrait";
                }
                PaperSize sz = GetPaperSize(paperkind.SelectedItem.ToString());


                if (sz.Height > sz.Width)
                {

                    if (oriantation.SelectedItem.ToString() == "portrait")
                    {
                        paper.Height = (plane.Height - 4);
                        paper.Width = (paper.Height * sz.Width) / sz.Height;
                        sviw.Location = new Point((paper.Width * (int)x.Value) / sz.Width, (paper.Height * (int)y.Value) / sz.Height );
                        sviw.Height = (paper.Height * (int)h.Value) / sz.Height;
                        sviw.Width = (paper.Width * (int)w.Value) / sz.Width;
                    }
                    else
                    {
                        MessageBox.Show("not set");
                        oriantation.SelectedItem = "portrait";
                    }
                }
                else
                {
                    if (oriantation.SelectedItem.ToString() == "landscape")
                    {
                        paper.Width = (plane.Width - 4);
                        paper.Height = (paper.Width * sz.Height) / sz.Width;
                        sviw.Height = (paper.Height * (int)h.Value) / sz.Height;
                        sviw.Width = (paper.Width * (int)w.Value) / sz.Width;
                    }
                    else
                    {
                        MessageBox.Show("not set");
                        oriantation.SelectedItem = "portrait";
                    }
                }

                               

                //MessageBox.Show(ts_p);
                //html.Text = SettingFolder + "\\" + SettingList.SelectedItem + fileext;
            }
            else
            {
                UpdateSetting.Enabled = RemoveSetting.Enabled = false;
            }

            

        }

        private void AddSetting_Click(object sender, EventArgs e)
        {

           // string input = Interaction.InputBox("Prompt", "Title", "Default", -1, -1);
           /* if (SettingList.FindString(input) > 0)
            {
                SettingList.Items.Add(input);
            }
            else*/
                MessageBox.Show("not programed !already exist..");
        }

        private void RemoveSetting_Click(object sender, EventArgs e)
        {
            if (SettingList.SelectedItem != null)
            {
                File.Delete(SettingFolder + "\\" + SettingList.SelectedItem + Fileext);
                SettingList.Items.Remove(SettingList.SelectedItem);
                html.Text = "";
                
                
            }
            refershlist();
        }

        private void refershlist(object sender, KeyPressEventArgs e)
        {
            refershlist();
        }

        private void refershlist(object sender, MouseEventArgs e)
        {
            refershlist();
        }


        private void Setting_Load(object sender, EventArgs e)
        {


           
            if (!Directory.Exists("stamp_Setting"))
            {
                Directory.CreateDirectory("stamp_Setting");
            }
            SettingList.Items.Clear();

            foreach (string file in Directory.EnumerateFiles(SettingFolder, "*"+Fileext))
            {
                SettingList.Items.Add(Path.GetFileNameWithoutExtension(file)); // to replace the specific text with blankfile);
                //string contents = File.ReadAllText(file);
            }


            //System.Diagnostics.Process.Start(@"stamp_Setting");

        }


       

        private void Button2_Click(object sender, EventArgs e)
        {

            using (Bitmap bitmap =  new Bitmap(webBrowser1.Width, webBrowser1.Height))
            {
                
                webBrowser1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save("stamp_Setting\\asdasdsad.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                System.Diagnostics.Process.Start("stamp_Setting\\asdasdsad.jpg");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Width= Convert.ToInt32(w.Text);
        }

        private void UpdateSetting_Click(object sender, EventArgs e)
        {

            String data = w.Text+"," + h.Text + "," + x.Text + "," + y.Text + "," + anchor.SelectedIndex.ToString()+ seprator+"\n" ;


            File.WriteAllText(SettingFolder + "\\" + SettingList.SelectedItem + Fileext,data+html.Text);
        }

        private void refershlist(object sender, EventArgs e)
        {
            refershlist();
        }

        private void Html_TextChanged(object sender, EventArgs e)
        {
                       


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            refershlist();
        }

        private void Paper_SelectedIndexChanged(object sender, EventArgs e)
        {
            refershlist();
            PaperSize sz = GetPaperSize(paperkind.SelectedItem.ToString());
            label4.Text = sz.Width + "x" + sz.Height;



        }


        public static PaperSize GetPaperSize(string Name)
        {
            PaperSize size1 = null;
            Name = Name.ToUpper();
            PrinterSettings settings = new PrinterSettings();
            foreach (PaperSize size in settings.PaperSizes)
                if (size.Kind.ToString().ToUpper() == Name)
                {
                    size1 = size;
                    break;
                }
            return size1;
        }

        private void W_ValueChanged(object sender, EventArgs e)
        {
            webBrowser1.Width = (int)w.Value;
        }

 
        private void H_ValueChanged(object sender, EventArgs e)
        {
            webBrowser1.Height = (int)h.Value;
        }

        private void pos_ValueChanged(object sender, EventArgs e)
        {
            if (oriantation.SelectedItem == null)
            {
                oriantation.SelectedItem = "portrait";
            }
            PaperSize sz = GetPaperSize(paperkind.SelectedItem.ToString());
            if (sz.Height > sz.Width)
            {

                if (oriantation.SelectedItem.ToString() == "portrait")
                {
                    paper.Height = (plane.Height - 4);
                    paper.Width = (paper.Height * sz.Width) / sz.Height;
                    sviw.Location = new Point((paper.Width * (int)x.Value) / sz.Width, (paper.Height * (int)y.Value) / sz.Height);
                    sviw.Height = (paper.Height * (int)h.Value) / sz.Height;
                    sviw.Width = (paper.Width * (int)w.Value) / sz.Width;
                }
                else
                {
                    MessageBox.Show("not set");
                    oriantation.SelectedItem = "portrait";
                }
            }
            else
            {
                if (oriantation.SelectedItem.ToString() == "landscape")
                {
                    paper.Width = (plane.Width - 4);
                    paper.Height = (paper.Width * sz.Height) / sz.Width;
                    sviw.Height = (paper.Height * (int)h.Value) / sz.Height;
                    sviw.Width = (paper.Width * (int)w.Value) / sz.Width;
                }
                else
                {
                    MessageBox.Show("not set");
                    oriantation.SelectedItem = "portrait";
                }
            }
        }
    }
}
