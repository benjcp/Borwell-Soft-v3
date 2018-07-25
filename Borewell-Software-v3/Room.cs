using System.Collections.Generic;

namespace Borewell_Software_v3
{
    //Class for each room, will need to store at least one wall
    class Room:Wall
    {

        public List<Wall> Walls { get; set; }

        //Use the width, Length and height from the Measurements
        public Room(decimal height, decimal width, decimal length):base(height, width)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        //Calculates the volume of the room
        public decimal calcRoomVolume()
        {
            return (Height * Width) * Length;
        }

        //Calculate the area of the floor
        public decimal calcFloorArea()
        {
            return (Width * Length);
        }

        //Calculate the amount of paint required to paint the room
        public decimal calcPaint(int coats)
        {
            decimal surfaceArea = new decimal();

            if(Walls != null)
            {
                //calculate the surface area of the room
                foreach(Wall wall in Walls)
                {
                    surfaceArea += wall.calcWallArea();
                }
                //calculate the total paint required (In Liters)
                return (surfaceArea * coats) / 10;
            }
            else
            {
               return 0;
            }
        }
    }
}
