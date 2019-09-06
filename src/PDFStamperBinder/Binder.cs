/*
 * Copyright 2019 - 2020 akshay nikhare
 * 
 * This file is part of PDFStamperBinder.
 *
 * PDFStamperBinder is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.

 * PDFStamperBinder is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with PDFStamperBinder.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDFStamperBinder
{
    class Combiner : IDisposable
    {
        private readonly Document _document;
        private readonly PdfCopy _pdfCopy;

        public Combiner(string outputFilePath)
        {
            var outputStream = File.Create(outputFilePath);

            _document = new Document();
            _pdfCopy = new PdfCopy(_document, outputStream);
            _document.Open();
        }

        public void AddFiletoBind(string fileName)
        {
            var reader = new PdfReader(fileName);

            for (var i = 1; i <= reader.NumberOfPages; i++)
            {
                var size = reader.GetPageSizeWithRotation(i);
                _document.SetPageSize(size);
                _document.NewPage();

                var page = _pdfCopy.GetImportedPage(reader, i);
                _pdfCopy.AddPage(page);
            }

            reader.Close();
        }


        /*
        public void AddFiletoBindstamp(string fileName, Stamp s)
        {
            var reader = new PdfReader(fileName);

            for (var i = 1; i <= reader.NumberOfPages; i++)
            {
                var size = reader.GetPageSizeWithRotation(i);
                _document.SetPageSize(size);
                _document.NewPage();

                Image pic = Image.GetInstance((System.Drawing.Image)s.Image, System.Drawing.Imaging.ImageFormat.Bmp);

                MessageBox.Show(pic.ToString());
                //pic.Height = (float)s.y;
                
                 if (s.type == (int)Stamp.ResType.Percetage)
                 {
                     float percentagey = (float)s.Sy / 100;
                     float percentagex = (float)s.Sx / 100;
                     percentagey = size.Height / pic.Height;
                     percentagex = size.Width / pic.Width;
                     pic.ScalePercent(percentagex * 100,percentagey * 100);
                 }
              
                MessageBox.Show(pic.ToString());
                pic.SetAbsolutePosition(1, 2);
                pic.Border = 5;
           
                var page = _pdfCopy.GetImportedPage(reader, i);
 
                page.AddImage(pic);
                     
                _pdfCopy.AddPage(page);
            }

            reader.Close();
        }*/



        public void Dispose()
        {
            _document.Close();
        }

        public static SourceTestResult TestSourceFile(string fileName)
        {
            try
            {
                PdfReader reader = new PdfReader(fileName);
                bool ok = !reader.IsEncrypted() ||
                    (reader.Permissions & PdfWriter.AllowAssembly) == PdfWriter.AllowAssembly;
                reader.Close();

                return ok ? SourceTestResult.Ok : SourceTestResult.Protected;
            }
            catch
            {
                return SourceTestResult.Unreadable;
            }
        }

        public enum SourceTestResult
        {
            Ok, Unreadable, Protected
        }
    }
}
