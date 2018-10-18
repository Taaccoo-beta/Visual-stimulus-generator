using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_stimulus_generator
{
    class VisualStimulusDescribe
    {
        
        private Dictionary<int, string> stimulusDescribtion;


        public VisualStimulusDescribe()
        {
            stimulusDescribtion = new Dictionary<int, string>();
            stimulusDescribtion.Add(0, "A single bar(static or dynamic) in the screen");
            stimulusDescribtion.Add(1, "A single swing bar");
            stimulusDescribtion.Add(2, "A cyclic bar");
            stimulusDescribtion.Add(3, "Multi moving bars");
        }

        public string getDescribtion(int index)
        {
            return stimulusDescribtion[index];
        }





    }
}
