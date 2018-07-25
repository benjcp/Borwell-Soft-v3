using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borewell_Software_v3
{
    // Class for each window, can calculate the area of the window by taking the length and width of the window.
    public class Window:Measurements
    {
 
        //Use the width and height from the Measurements 
        public Window(decimal windowWidth, decimal windowHeight)
        {
            Height = windowHeight;
            Width = windowWidth;
        }

        //calculate the area of the window
        public decimal calcWindowArea()
        {
            return Height * Width;
        }
    }
}
