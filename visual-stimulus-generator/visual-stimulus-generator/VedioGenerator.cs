using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class VedioGenerator
    {

        private VideoFileWriter writer;
        

        public VedioGenerator(string savePath,int frameRate,int width,int height)
        {
            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(savePath, width, height, frameRate, VideoCodec.MPEG4);
            
        }


        public void WriteSingleFrame(Bitmap image)
        {
        
            writer.WriteVideoFrame(image);
           
        }

        



        
    }
}
