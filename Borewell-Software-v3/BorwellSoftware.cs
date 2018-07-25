using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Borewell_Software_v3
{
    public partial class BorwellSoftware : Form
    {
        public BorwellSoftware()
        {
            InitializeComponent();

            Room r = new Room(10,10,10);
            r.Walls = new List<Wall>();
            r.Walls.Add(new Wall(5, 5));
            r.Walls[0].Windows = new List<Window>();
            r.Walls[0].Windows.Add(new Window(1.5m, 1));

            decimal a = r.calcRoomVolume();
            decimal b = r.calcWallArea();
            decimal c = r.calcPaint(2);

            Console.WriteLine("Room Volume: " + a);
            Console.WriteLine("Wall Area: " + b);
            Console.WriteLine($"Paint: {c}L");
        }
    }
}
