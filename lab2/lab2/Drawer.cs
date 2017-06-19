using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab2
{
    class Drawer
    {
        public static IImage drawContour(IImage image, VectorOfVectorOfPoint contours)
        {
            var newImage = ((Image<Bgr, byte>)image).Clone();
            for (int i = 0; i < contours.Size; i++)
            {
                var pts = contours[i].ToArray();
                //                newImage.Draw(new Triangle2DF(pts[0], pts[1], pts[2]), new Bgr(Color.GreenYellow), 2);
                newImage.Draw(pts, new Bgr(Color.GreenYellow), 2);
            }
            return newImage;
        }

        public static IImage drawContour(IImage image, List<CircleF> circles)
        {
            var newImage = ((Image<Bgr, byte>)image).Clone();
            foreach (CircleF circle in circles)
                newImage.Draw(circle, new Bgr(Color.GreenYellow), 2);
            return newImage;
        }
    }
}
