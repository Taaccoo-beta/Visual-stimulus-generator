using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class RandomPointMoving
    {

        int width, height;
        int pointSize;
        int barSize;
        int setRandomPoint;
        public RandomPointGenerator background;
        public RandomPointGenerator bar;
        public RandomPointMoving(int width, int height, int pointSize,int barSize,int setRandomPoint)
        {
            this.width = width;
            this.height = height;
            this.pointSize = pointSize;
            this.barSize = barSize;
            this.setRandomPoint = setRandomPoint;
            background = new RandomPointGenerator(width, height, pointSize);
            bar = new RandomPointGenerator(barSize, height, pointSize);
            background.setRandomPoint(setRandomPoint);
            bar.setRandomPoint(setRandomPoint);
            
        }

        public int DegreeToPosition(float degree)
        {
            return (int)(degree / 360f * width + width / 2f);

            //-180 to 180   ---> 0 to width
        }


        //public void setPosition(int position)
        //{
        //    int length = bar.randomCanvasBackground.Count;
        //    for (int i = 0; i!=length;i++)
        //    {
        //        background.randomCanvasBackground[position - barSize + i] = bar.randomCanvasBackground[i];
        //    }
        //}






    }
}
