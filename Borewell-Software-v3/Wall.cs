using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borewell_Software_v3
{
    //Class for each Wall, uses Window as it's inherited class as walls can have windows and can use measurements
    class Wall:Window
    {

        public List<Window> Windows { get; set; }

        //Use the width and height from the Measurements
        public Wall(decimal height, decimal width):base(width, height)
        {
            height = Height;
            width = Width;
        }

        //Calculates the total area of the wall with or without windows
        public decimal calcWallArea()
        {
            if(Windows != null)
            {
                decimal winarea = new decimal();

                foreach(Window win in Windows)
                {
                    winarea += win.WindowArea();
                }

                return (Height * Width) - winarea;
            }
            return (Height * Width);
        }
    }
}
