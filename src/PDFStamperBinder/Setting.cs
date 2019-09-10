using System;
using System.Drawing;
using System.Drawing.Printing;
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
        private bool isnotSave = false;
        private string orignalhtml = null;
        private string stampname = null;
        private PaperSize pageSize = new PaperSize("Letter", 850, 1100);

        public Setting()
        {
            InitializeComponent();

            anchor.Items.Clear();
            foreach (var x in UCS.CornerTextList)
                anchor.Items.Add(x);

            anchor.SelectedItem = "BottomLeft";
        }

        private void updateUI()
        {
            if (html.Text.Length > 4)
            {
                printPreview.InvalidatePreview();
            }
        }

        private string genrateStampImage()
        {
            string stampname = tempDir + MainForm.RandomString(10) + ".png";
            string k = html.Text;
            html2image tt = new html2image(k, System.IO.Directory.GetCurrentDirectory() + "\\" + SettingFolder);
            tt.transprencyKey(System.Drawing.Color.White);
            tt.Generate(stampname, (int)w.Value, (int)h.Value);
            //tt.Generate(stampname);
            tt.close();

            return stampname;
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

            if (SettingList.Items.Count > 0)
            {
                SettingList.SelectedIndex = 0;
            }
        }

        private void BtnPageSetup_Click(object sender, EventArgs e)
        {
            if (pageSetup.ShowDialog() == DialogResult.OK)
            {
                updateUI();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (SettingList.SelectedItem != null)
            {
                File.Delete(SettingFolder + "\\" + SettingList.SelectedItem + fileext);
                SettingList.Items.Remove(SettingList.SelectedItem);
                SettingList.SelectedIndex = SettingList.Items.Count > 0 ? 0 : -1;
            }
            updateUI();
        }

        /*
                private bool SettingList_serch(string input)
                {
                    ;

                    for (int i = startIndex; i < lb.Items.Count; ++i)
                    {
                        string lbString = lb.Items[i].ToString();
                        if (lbString.Contains(searchString))
                            return i;
                    }
                    return -1;
                }
                */

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (inputBox form = new inputBox())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (!SettingList.Items.Contains(form.input) && !File.Exists(SettingFolder + "\\" + form.input + fileext))
                    {
                        if (File.Exists("baseTemplate.ast"))
                        {
                            File.WriteAllText(SettingFolder + "\\" + form.input + fileext, File.ReadAllText("baseTemplate.ast"));
                            SettingList.SelectedIndex = SettingList.Items.Add(form.input);
                        }
                        else
                        {
                            MessageBox.Show("Base template not found. ");
                        }
                    }
                    else
                    {
                        MessageBox.Show(form.input + " already exist in list . Add a different name");
                    }
                }

                form.Dispose();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (SettingList.SelectedIndex > -1 && isnotSave)
            {
                string perm = "<!--$" + w.Value + "," + h.Value +
                                "," + x.Value + "," + y.Value +
                                "," + anchor.SelectedIndex +
                                "," + transprancy.Value +
                                "," + angle.Value +
                                "$-->\n";
                File.WriteAllText(SettingFolder + "\\" + SettingList.SelectedItem + fileext, perm + html.Text);
                btnUpdate.Enabled = isnotSave = false;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            updateUI();
        }

        private void SettingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingList.SelectedIndex > -1)
            {
                btnUpdate.Enabled = isnotSave = false;
                string file = SettingFolder + "\\" + SettingList.SelectedItem + fileext;
                if (File.Exists(file))
                {
                    string tem = File.ReadAllText(file);
                    string[] sl = tem.Substring(5, tem.IndexOf("$-->") - 5).Split(',');
                    if (sl.Length == 7)
                    {
                        w.Value = Convert.ToInt32(sl[0]);
                        h.Value = Convert.ToInt32(sl[1]);
                        x.Value = Convert.ToInt32(sl[2]);
                        y.Value = Convert.ToInt32(sl[3]);
                        anchor.SelectedIndex = Convert.ToInt32(sl[4]);
                        transprancy.Value = Convert.ToInt32(sl[5]);
                        angle.Value = Convert.ToInt32(sl[6]);
                    }
                    else
                    {
                        MessageBox.Show("error with the file format..\n" + file);
                        w.Value = 250;
                        h.Value = 150;
                        x.Value = 100;
                        y.Value = 100;
                        anchor.SelectedItem = "BottomLeft";
                        transprancy.Value = 30;
                        angle.Value = 30;
                    }
                    orignalhtml = html.Text = tem.Remove(0, tem.IndexOf("$-->") + 5);
                    btnRemove.Enabled = true;
                    updateUI();
                }
                else
                {
                    MessageBox.Show("error opening or reafing file... \n" + file);
                }
            }
        }

        private void Html_TextChanged(object sender, EventArgs e)
        {
            if (orignalhtml != html.Text) { btnUpdate.Enabled = isnotSave = true; } else { btnUpdate.Enabled = isnotSave = false; }
        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //  if (File.Exists(stampname)) File.Delete(stampname);
            stampname = null;
            this.Cursor = Cursors.Default;
        }

        private void PrintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            stampname = genrateStampImage();
            this.Cursor = Cursors.WaitCursor;
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //MessageBox.Show(e.PageSettings.PaperSize);
            pageSize = e.PageSettings.PaperSize;

            Point newPt = UCS.shiftAnchor(UCS.Corner.TopLeft, (UCS.Corner)anchor.SelectedIndex,
                                            pageSize.Width, pageSize.Height,

                                            (int)w.Value, (int)h.Value,

                                            new Point((int)x.Value, (int)y.Value)
                                            );

            //Point newPt = UCS.shiftAnchor(UCS.Corner.TopLeft, (UCS.Corner)anchor.SelectedIndex,new Point((int)x.Value, (int)y.Value));

            Bitmap b = new Bitmap(new Bitmap(stampname));

            int ri = (int)Math.Sqrt(b.Width * b.Width + b.Height * b.Height);

            Bitmap returnBitmap = new Bitmap(ri, ri);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform((float)angle.Value);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }

            e.Graphics.DrawImage(returnBitmap, newPt);
        }

        private void PrintPreview_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(pageSize.ToString(), new Font("Tahoma", 10), Brushes.AliceBlue, 3, 3);
        }

        private void W_ValueChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }
    }
}