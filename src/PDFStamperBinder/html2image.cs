using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public string fileName = null;
        private float angle = 0;
        public bool running = false;
        public string html = null;
        public string BaseURL = null;
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


                if (angle != 0)
                    RotateBitmap(bitmap, angle).Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                else
                    bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);


                running = false;
            }
        }

        internal void Generate(string filename, int width = 500, int height = 500, float angle = 0)
        {
            this.fileName = filename;
            this.angle = angle;
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







        // Find the bounding rectangle for an array of points.
        private void GetPointBounds(PointF[] points, out float xmin, out float xmax, out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }






        // Return a bitmap rotated around its center.
        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a Matrix to represent rotation
            // by this angle.
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);

            // Rotate the image's corners to see how big
            // it will be after rotation.
            PointF[] points =
            {
        new PointF(0, 0),
        new PointF(bm.Width, 0),
        new PointF(bm.Width, bm.Height),
        new PointF(0, bm.Height),
    };
            rotate_at_origin.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBounds(points, out xmin, out xmax,
                out ymin, out ymax);

            // Make a bitmap to hold the rotated result.
            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(wid / 2f, hgt / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(Color.Transparent);

                //// For debugging. (It's easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }

            // Return the result bitmap.
            return result;
        }


    }
}