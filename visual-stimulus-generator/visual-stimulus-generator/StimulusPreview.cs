using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class StimulusPreview
    {
        private Graphics g1;
      
        private float widthCenter, heightCenter;
        private int width, height;
        private Color bc;
        Bitmap image1;


        public StimulusPreview(int width, int height, Color bc)
        {
            this.widthCenter = width / 2;
            this.heightCenter = height / 2;
            this.width = width;
            this.height = height;
            

            image1 = new Bitmap(width, height);
            g1 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g1.CompositingQuality = CompositingQuality.HighQuality;
            g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            

        }


        private float DegreeToPosition(float degree)
        {
            return degree / 360 * width + width / 2;

            //-180 to 180   ---> 0 to width
        }

        //id = 0, show a single bar
        public Bitmap singleBar()
        {
            g1.Clear(Color.White);
            g1.FillRectangle(new SolidBrush(Color.Black), widthCenter - 20, 0, 40, height);
            return image1;
        }



        public Bitmap singleSwingBar(float degree)
        {
            g1.Clear(Color.White);
            float position = DegreeToPosition(degree);
            g1.FillRectangle(new SolidBrush(Color.Black), position - 20, 0, 40, height);
            return image1;
        }


        public Bitmap singleCyclicBar(float degree)
        {
            g1.Clear(Color.White);
            float position = DegreeToPosition(degree);
            g1.FillRectangle(new SolidBrush(Color.Black), position - 20, 0, 40, height);
            return image1;
        }
    }
}
