using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using System.IO;

namespace PDFStamperBinder
{
    internal class Stamper
    {
        internal int x = 0, y = 0;
        internal float transprency = 0.6f, rotation = 10f;
        internal UCS.Corner anchor = UCS.Corner.TopLeft;

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


                    System.Drawing.Point newPt =/* new System.Drawing.Point(0, 0);*/
                        UCS.shiftAnchor(UCS.Type.pdf, UCS.Corner.TopLeft, anchor,
                                                                    (int)pdf.GetPage(i + 1).GetPageSize().GetWidth(), (int)pdf.GetPage(i + 1).GetPageSize().GetHeight(),

                                                                    (int)image.GetWidth(), (int)image.GetHeight(),

                                                                    new System.Drawing.Point(x, y)
                                                                    );


                    //TODO: add width & height to image
                    canvas.AddImage(image, newPt.X, newPt.Y, false);

                    canvas.RestoreState();
                }
                pdf.Close();
            }
        }
    }
}