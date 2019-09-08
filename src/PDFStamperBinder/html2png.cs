using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    class html2png
    {

        public string fileout;
        public bool running=false;
        Thread th;
        internal  void genrate(string html, string fileo)
        {

            int w = 400, h = 300, x = 100, y = 100;
            fileout = fileo;
                th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                //MessageBox.Show("wb=> " + webBrowser.Height.ToString() + "\n img ht=>" + h);
                webBrowser.Height = h;
                //webBrowser.Width = w;
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = html;
                //MessageBox.Show(source);
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            running = true;
            //MessageBox.Show("start");
        }



         void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap = new Bitmap(webBrowser.Width, webBrowser.Height))
            {

                webBrowser.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(fileout, System.Drawing.Imaging.ImageFormat.Jpeg);
                running = false;
                th.Abort();
              
            }
        }

















    }
}
