
using System.Drawing;

using System.Threading;

using System.Windows.Forms;

namespace PDFStamperBinder
{
    class html2png
    {

        public string fileout;
        public bool running=false;
        public string html;
        Thread th;


        public html2png(string html) => this.html = html;





        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap = new Bitmap(webBrowser.Width, webBrowser.Height))
            {

                webBrowser.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(fileout, System.Drawing.Imaging.ImageFormat.Jpeg);
                running = false;
        
              
            }
        }

        internal void genrate(string fileout,int width =500, int height=500)
        {
            this.fileout = fileout;
            th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                webBrowser.Height = height;
                webBrowser.Width = width;
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = html;
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            running = true;
        }

        internal void close()
        {
            while (running) { System.Threading.Thread.Sleep(1); }
            if (th.IsAlive)
            th.Abort();
        }
    }
}
