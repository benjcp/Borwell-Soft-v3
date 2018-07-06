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

        public Window window { get; set; }

        public Wall(decimal height, decimal width):base(width, height)
        {
            height = Height;
            width = Width;
        }

        public decimal calcWallArea()
        {
            return (Height * Width) - window.WindowArea();
        }
    }
}
