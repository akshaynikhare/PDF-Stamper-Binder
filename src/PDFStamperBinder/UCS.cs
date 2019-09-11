using System.Collections.Generic;
using System.Drawing;

namespace PDFStamperBinder
{
    internal class UCS
    {
        public enum Corner { TopLeft, BottomLeft, TopRight, BottomRight }
        public enum Type { form, pdf }

        public static List<string> CornerTextList = new List<string>(new string[] { "TopLeft", "BottomLeft", "TopRight", "BottomRight" });

        internal static Point shiftAnchor(Type type, Corner oldUCS, Corner newUCS, int paperW, int paperH, int objectW, int objectH, Point refPoint)
        {
            int x = 0;
            int y = 0;

            if (oldUCS == newUCS || oldUCS != Corner.TopLeft) return refPoint;

            if (type == Type.form)
            {
                switch (newUCS)
                {
                    default:
                        //top left
                        x = refPoint.X;
                        y = refPoint.Y;
                        break;

                    case Corner.TopRight:

                        x = paperW - refPoint.X - objectW;
                        y = refPoint.Y;
                        break;

                    case Corner.BottomLeft:
                        x = refPoint.X;
                        y = paperH - refPoint.Y - objectH;
                        break;

                    case Corner.BottomRight:
                        x = paperW - refPoint.X - objectW;
                        y = paperH - refPoint.Y - objectH;
                        break;
                }
            }
            else
            {

                switch (newUCS)
                {
                    default:
                        //top left
                        x = refPoint.X;
                        y = paperH - refPoint.Y - objectH;
                        break;

                    case Corner.TopRight:
                        x = paperW - refPoint.X - objectW;
                        y = paperH - refPoint.Y - objectH;
                        break;

                    case Corner.BottomLeft:
                        x = refPoint.X;
                        y = refPoint.Y;
                        break;

                    case Corner.BottomRight:
                        x = paperW - refPoint.X - objectW;
                        y = refPoint.Y;
                        break;
                }

            }

            return new Point(x, y);
            // throw new NotImplementedException();
        }
    }
}