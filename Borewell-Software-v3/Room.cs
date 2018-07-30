using System;
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
            try
            { return (Height * Width) * Length; }
            catch
            { throw new ArgumentException("Please enter a valid input for a room"); }
        }

        //Calculate the area of the floor
        public decimal calcFloorArea()
        {
            try
            { return (Width * Length); }
            catch
            { throw new ArgumentException("Please enter a valid input for floor values"); }
        }

        //Calculate the amount of paint required to paint the room
        public decimal calcPaint(int coats)
        {
            decimal surfaceArea = new decimal();

            //calculate the surface area of the room
            foreach (Wall wall in Walls)
            {
                surfaceArea += wall.calcWallArea();
            }
            //calculate the total paint required (In Liters)
            try
            {
                //if the required paint is less than 0 or invalid data entered, throw an error
                decimal Paint = (surfaceArea * coats) / 10;

                if (Paint > 0)
                { return Paint; }
                else if (Paint <= 0)
                { return Paint; }
                else
                { throw new ArgumentException("required paint must be more than 0"); }
            }
            catch
            {
                throw new ArgumentException("Please enter valid input for required paint");
            }
        }
    }
}
