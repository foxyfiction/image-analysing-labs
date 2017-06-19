using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab2
{
    class ContourFinder
    {
        private static VectorOfVectorOfPoint findContours(IImage srcImage)
        {
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(srcImage, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
            return contours;
        }

        public static VectorOfVectorOfPoint findApproxContours(IImage image, int threshold = 140)
        {
            return ContourFinder.getApproxContour(
                ContourFinder.findContours(
                    ImageTransformAlgorithms.getThreshold(
                        ImageTransformAlgorithms.pyramideDec(image), threshold)));
        }

        public static VectorOfVectorOfPoint getApproxContour(VectorOfVectorOfPoint vectors)
        {
            var approxContours = new VectorOfVectorOfPoint();
            for (int i = 0; i < vectors.Size; i++)
            {
                var contour = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(vectors[i], contour, CvInvoke.ArcLength(vectors[i], true) * 0.05, true);
                approxContours.Push(contour);
            }
            return approxContours;
        }

        public static VectorOfVectorOfPoint getTriangles(VectorOfVectorOfPoint contours, int minArea = 0)
        {
            var trianglesContours = new VectorOfVectorOfPoint();
            for (int i = 0; i < contours.Size; i++)
            {
                if (contours[i].Size == 3 && CvInvoke.ContourArea(contours[i], false) > minArea)
                {
                    trianglesContours.Push(contours[i]);
                }
            }
            return trianglesContours;
        }

        public static VectorOfVectorOfPoint getRectangles(VectorOfVectorOfPoint contours, int minArea = 0)
        {
            var rectangleContours = new VectorOfVectorOfPoint();
            for (int i = 0; i < contours.Size; i++)
            {
                if (isRectangle(contours[i].ToArray()) && CvInvoke.ContourArea(contours[i], false) > minArea)
                {
                    rectangleContours.Push(contours[i]);
                }
            }
            return rectangleContours;
        }

        private static bool isRectangle(Point[] pts)
        {
            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

            for (int j = 0; j < edges.Length; j++)
            {
                double angle = Math.Abs(edges[(j + 1) %
                edges.Length].GetExteriorAngleDegree(edges[j])); if (angle < 80 || angle > 100)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<CircleF> getCircles(IImage image, int threshold = 140, int minDistance = 10, int acTreshold = 36, int minRadius = 0, int maxRadius = 100)
        {
            // Hough algorithm 
            return new List<CircleF>(CvInvoke.HoughCircles(
                ImageTransformAlgorithms.getThreshold(ImageTransformAlgorithms.pyramideDec(image), threshold),
                HoughType.Gradient,
                /*2.0,*/ 1.0,
                minDistance,
                100,
                acTreshold,
                minRadius,
                maxRadius
            ));
        }
    }
}
