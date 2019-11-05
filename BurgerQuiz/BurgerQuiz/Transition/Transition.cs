using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQuiz
{
    class Transition
    {
        public string Image;
        public string Video;

        public Transition()
        {
            Image = "";
            Video = "";
        }

        public Transition(string image)
        {
            Image = image;
            Video = "";
        }

        public Transition(string image, string video)
        {
            Image = image;
            Video = video;
        }
    }
}
