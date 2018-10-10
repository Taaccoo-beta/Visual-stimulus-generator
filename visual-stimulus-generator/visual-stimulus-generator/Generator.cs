using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class Generator
    {
        public List<List<int>> canvas;
        private int canvasWidth;
        private int canvasHeight;

        //image rectangle
        public Generator(int width,int height)
        {
            canvas = new List<List<int>>();
            this.canvasWidth = width;
            this.canvasHeight = height;

            for (int i = 0; i != canvasWidth; i++)
            {
                canvas.Add(new List<int>());
                for (int j = 0; j != canvasHeight; j++)
                {
                    canvas[i].Add(0);
                }
            }
        }

        
        public void MoveRight(int step)
        {
            for (int i = 0; i != step; i++)
            {
                canvas.Insert(0, canvas[canvasWidth-1]);
                canvas.Remove(canvas[canvasWidth]);
            }
        }

        public void MoveLeft(int step)
        {
            for (int i = 0; i != step; i++)
            {
                canvas.Add(canvas[0]);
                canvas.Remove(canvas[0]);
            }
        }

        public int DegreeToPosition(float degree)
        {
            return (int)(degree / 360 * canvasWidth + canvasWidth / 2);

            //-180 to 180   ---> 0 to width
        }

    }
}
