using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borewell_Software_v3
{
    // Public class for all measurements for each room, wall and window
    public class Measurements
    {
        // All of the measurements used for Windows, walls and rooms
        protected decimal Height { get; set; }
        protected decimal Width { get; set; }
        protected decimal Length { get; set; }
    }
}
