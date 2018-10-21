using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class RandomPointGenerator
    {
        public List<List<int>> randomPoint;

        private int width, height;
        public RandomPointGenerator(int width, int height)
        {
            this.width = width;
            this.height = height;

            randomPoint = new List<List<int>>();
            for (int i = 0; i != width; i++)
            {
                randomPoint.Add(new List<int>());
                for (int j = 0; j != width; j++)
                {
                    randomPoint[i].Add(0);  
                }
            }
        }

        public void GeneratePoint(int pointSize,int rate)
        {
           
            int pointWidth = width / pointSize + 1;
            int pointHeight = height / pointSize + 1;


            Random rd = new Random();
            for (int i = 0; i != pointWidth; i++)
            {
                for (int j = 0; j != pointHeight; j++)
                {
                    int value = rd.Next(0, 100);
                    if (value < 60)
                    {

                        for (int ii = i * pointSize; ii != (ii + 1) * pointSize; ii++)
                        {
                            for (int jj = j * pointSize; jj != (j + 1) * pointSize; jj++)
                            {
                                randomPoint[ii][jj] = 1;
                            }
                        }

                    }
                    
                }
            }
        }



    }
}
