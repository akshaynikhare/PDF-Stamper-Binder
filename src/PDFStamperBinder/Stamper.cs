using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;

namespace PDFStamperBinder
{

    class Stamper 
    {/*
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


       







        */
        internal void PdfStamp_V2()
        {


            /*
            PdfDocument pdf = new PdfDocument(new PdfReader("asd.pdf"), new PdfWriter("asd_f.pdf"));

           // MessageBox.Show(pdf.GetNumberOfPages().ToString());
            for (var i = 0; i < pdf.GetNumberOfPages(); i++)
            {
                PdfCanvas canvas = new PdfCanvas(pdf.GetPage(i+1));
                ImageData image = ImageDataFactory.Create(System.IO.Directory.GetCurrentDirectory() + "\\img_2.jpg");
                canvas.SaveState();
                //MessageBox.Show(image.GetWidth().ToString());
                PdfExtGState state = new PdfExtGState();
                state.SetFillOpacity(0.6f);
                canvas.SetExtGState(state);
                canvas.AddImage(image, 100, 0, false);
                canvas.RestoreState();
            }

            pdf.Close();

          */


            string stampname = System.IO.Directory.GetCurrentDirectory() + "\\" + RandomString(10) + ".jpg";
         
            string k =System.IO.File.ReadAllText("h.html");
            html2png tt = new html2png();
            tt.genrate(k, stampname);
            while (tt.running) { System.Threading.Thread.Sleep(10); }

            System.Diagnostics.Process.Start(stampname);
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }























    }
}






       
  
