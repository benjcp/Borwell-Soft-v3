using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borewell_Software_v3
{
    //Class for each room, will need to store at least one wall
    class Room:Wall
    {

        public List<Wall> Walls { get; set; }

        //Use the width, Length and height from the Measurements
        public Room(decimal height, decimal width, decimal length):base(width, height)
        {
            height = Height;
            width = Width;
            length = Length;
        }



    }
}
