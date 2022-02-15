using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public class Room
    {
        private int _square;
        private int _numberOfWindows;
        private string _side;
        
        public int Square { get => _square; set { _square = value; } }
        public int NumberOfWindows { get => _numberOfWindows; set { _numberOfWindows = value; } }
        public string Side { get => _side; set { _side = value; } }

        public Room(int square, int numberOfWindows, string s)
        {
            Square = square;
            NumberOfWindows = numberOfWindows;
            Side = s;
        }

        public Room()
        {
            Square = 0;
            NumberOfWindows = 0;
            Side = "";
        }
    }
}
