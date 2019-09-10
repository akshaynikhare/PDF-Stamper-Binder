using System.IO;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;

namespace PDFStamperBinder
{
    internal class Stamper
    {
        internal int x = 0, y = 0;
        internal float transprency = 0.6f, rotation = 10f;

        public Stamper()
        { }

        public void PdfStamp(string fileout, string stamp, string filein)
        {
            if (File.Exists(filein) && File.Exists(stamp))
            {
                PdfDocument pdf = new PdfDocument(new PdfReader(filein), new PdfWriter(fileout));
                // MessageBox.Show(pdf.GetNumberOfPages().ToString());
                for (var i = 0; i < pdf.GetNumberOfPages(); i++)
                {
                    PdfCanvas canvas = new PdfCanvas(pdf.GetPage(i + 1));
                    ImageData image = ImageDataFactory.Create(stamp);
                    image.SetRotation(rotation);
                    canvas.SaveState();
                    PdfExtGState state = new PdfExtGState();

                    state.SetFillOpacity(transprency > 1f ? (transprency / 100) : transprency);
                    canvas.SetExtGState(state);
                    //TODO: add width & height to image
                    canvas.AddImage(image, x, y, false);
                    canvas.RestoreState();
                }
                pdf.Close();
            }
        }
    }
}