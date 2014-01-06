using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Greyhound
    {

        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;


        public bool Run()
        {
            int distance = Randomizer.Next(1,5);
            Console.WriteLine("distance: " + distance);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;

            if (p.X >= RacetrackLength)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            Location = StartingPosition;
        }

    }
}
