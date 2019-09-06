using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace PDFStamperBinder
{

    class Stamper 
    {
        private static string lastimagepath = null;
        private static string stampname = null;
        private static int w = 100, h = 100, x = 100, y = 100;
        
        public Stamper()
        { }

       public void PdfStamp(string Fileout,string stamp, string filein)
        {

            if (!Directory.Exists("temp"))
            {
                Directory.CreateDirectory("temp");
            }

            //MessageBox.Show(stamp);

            GenrateImage(Path.GetFullPath("temp"), stamp);


            
            if (stampname != null)
            {


            var pdfReader = new PdfReader(filein);
            var pdfStamper = new PdfStamper(pdfReader, new FileStream(Fileout, FileMode.Create));
            var image = iTextSharp.text.Image.GetInstance(lastimagepath);
            image.SetAbsolutePosition(x, y);

            for (var i = 0; i < pdfReader.NumberOfPages; i++)
            {
                var content = pdfStamper.GetUnderContent(i + 1);
                content.AddImage(image);
            }

            pdfStamper.Close();
            }
            

        }



        internal static string GenrateImage(string filedir, string stamp)
        {

            string rawHtml = "";
           
            try
            {
                string ts = File.ReadAllText(stamp);
                int schr = ts.IndexOf('$');
                if (schr > 0)
                {
                    string[] sl = ts.Substring(0, schr).Split(',');
                    if (sl.Length == 5)
                    {
                        w = Convert.ToInt32(sl[0]);
                        h = Convert.ToInt32(sl[1]);
                        x = Convert.ToInt32(sl[2]);
                        y = Convert.ToInt32(sl[3]);
                        ts = ts.Remove(0, schr + 2);

                        string dirpath = System.IO.Directory.GetCurrentDirectory() + "\\stamp_Setting\\";
                        rawHtml = ts.Replace("<?Setting_Dir?>", dirpath.Replace("\\", "/")); ;
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

            stampname = RandomString(10)+ ".jpg";
            lastimagepath = filedir+"\\"+stampname;

            
            //MessageBox.Show(lastimagepath);
            StartBrowser(rawHtml, w, h, x, y);
            System.Threading.Thread.Sleep(1000);
            //MessageBox.Show("asd > "+lastimagepath+" < asd");
            //System.Diagnostics.Process.Start(Path.GetFullPath(lastimagepath));
            return lastimagepath;
       }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }






        private static void StartBrowser(string source, int w, int h,int x,int y)
        {
            var th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                //MessageBox.Show("wb=> " + webBrowser.Height.ToString() + "\n img ht=>" + h);
                webBrowser.Height = h;
                //webBrowser.Width = w;
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = source;
                //MessageBox.Show(source);
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
           

        }

        static void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap =  new Bitmap(webBrowser.Width,  webBrowser.Height))
            {
                webBrowser.DrawToBitmap(  bitmap, new System.Drawing .Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(lastimagepath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //MessageBox.Show("asd > " + lastimagepath + " < asd");
                //System.Diagnostics.Process.Start(lastimagepath);
               
            }
        }

    }
}






       
  
