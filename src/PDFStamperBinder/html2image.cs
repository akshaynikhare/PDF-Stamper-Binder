using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    internal struct Tag
    {
        private string name;
        private string replacemnet;

        public Tag(string n, string r) : this()
        {
            this.name = n;
            this.replacemnet = r;
        }

        public string Name { get => name; set => name = value; }
        public string Replacemnet { get => replacemnet; set => replacemnet = value; }
    }

    internal class html2image
    {
        public static List<Tag> tags = new List<Tag>();

        public string fileName;
        public bool running = false;
        public string html;
        public string BaseURL;
        private Thread th;
        private Color colr = Color.Empty;

        public html2image(string html, string baseurl)
        {
            running = false;
            this.BaseURL = baseurl;
            tags.Add(new Tag("<!––#baseUrl#-->", BaseURL.Replace('\\', '/')));
            this.html = html;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap = new Bitmap(webBrowser.Width, webBrowser.Height))
            {
                webBrowser.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.MakeTransparent(colr);
                bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                running = false;
            }
        }

        internal void Generate(string filename, int width = 500, int height = 500)
        {
            this.fileName = filename;
            th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                webBrowser.Height = height;
                webBrowser.Width = width;
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = ConvertTag2path();
                //MessageBox.Show(ConvertTag2path());
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            running = true;
        }

        private string ConvertTag2path()
        {
            String newHtml = html;
            if (BaseURL != null && html != null)
            {
                foreach (var x in tags)
                {
                    newHtml = newHtml.Replace(x.Name, x.Replacemnet);
                }
            }

            return newHtml;
        }

        internal void close()
        {
            while (running) { System.Threading.Thread.Sleep(1); }
            if (th.IsAlive)
                th.Abort();
        }

        internal void transprencyKey(Color colr)
        {
            this.colr = colr;
        }
    }
}