
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace lab2
{
    class ImageTransformAlgorithms
    {
        public static Mat pyramideDec(IImage scrImage)
        {
            // преобразование изображения в чёрно-белое 
            var image = new Mat();
            CvInvoke.CvtColor(scrImage, image, ColorConversion.Bgr2Gray);

            // применение пирамидальной декомпозиции для устранения шумов 
            var pyrDown = new Mat();
            CvInvoke.PyrDown(image, pyrDown);
            CvInvoke.PyrUp(pyrDown, image);
            return image;
        }

        public static Mat getThreshold(IImage scrImage, int treshold = 140)
        {
            // обнаружение областей интереса
            var image = new Mat();
            CvInvoke.Threshold(scrImage, image, treshold, 255, ThresholdType.Binary);
            return image;
        }
    }
}
