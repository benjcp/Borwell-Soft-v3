using System;
using System.Collections.Generic;

namespace Borewell_Software_v3
{
    //Class for each Wall, uses Window as it's inherited class as walls can have windows and can use measurements
    class Wall :Window
    {

        public List<Window> Windows { get; set; }

        //Use the width and height from the Measurements
        public Wall(decimal height, decimal width):base(width, height) 
        {
            Height = height;
            Width = width;
        }

        //Calculates the total area of the wall with or without windows
        public decimal calcWallArea()
        {
            decimal winarea = new decimal();
            //calculate the total area of windows

            foreach (Window win in Windows)
            { winarea += win.calcWindowArea(); }

            //calculate area of wall minus windows
            try
            { return (Height * Width) - winarea; }
            catch
            { throw new ArgumentException("Please enter a valid input for walls"); }
        }
    }
}
