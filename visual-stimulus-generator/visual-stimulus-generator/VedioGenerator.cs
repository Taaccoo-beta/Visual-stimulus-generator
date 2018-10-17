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
        private string VideoName;
        private string Path;
        private int FrameRate;

        public VedioGenerator(string videoName,string path,int frameRate,int width,int height)
        {
            VideoFileWriter writer = new VideoFileWriter();
            this.VideoName = videoName;
            this.Path = path;
            this.FrameRate = frameRate;
            try
            {
                writer.Open(@path, width, height, frameRate, VideoCodec.MPEG4);
            }
            catch
            {
                ;
            }
        }
        public void Generator(Bitmap image)
        {
        
            writer.WriteVideoFrame(image);
           
        }



        
    }
}
