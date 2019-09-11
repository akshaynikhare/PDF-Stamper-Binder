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

using iText.Kernel.Pdf;
using System;

namespace PDFStamperBinder
{
    internal class Combiner : IDisposable
    {
        private readonly PdfDocument pdfDoc;
        // private readonly PdfCopy _pdfCopy;

        public Combiner(string outputFilePath)
        {
            this.pdfDoc = new PdfDocument(new PdfWriter(outputFilePath).SetSmartMode(true));
        }

        public void Dispose()
        {
            pdfDoc.Close();
        }

        public static SourceTestResult TestSourceFile(string fileName)
        {
            try
            {
                PdfReader reader = new PdfReader(fileName);
                bool ok = !reader.IsEncrypted();

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

        internal void AddFiletoBind(string fileName)
        {
            PdfDocument srcDoc = new PdfDocument(new PdfReader(fileName));
            srcDoc.CopyPagesTo(1, srcDoc.GetNumberOfPages(), pdfDoc);
        }
    }
}