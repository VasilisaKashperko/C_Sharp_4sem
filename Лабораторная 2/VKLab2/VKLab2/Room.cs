using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public class Room
    {
        private int _number;
        private int _square;
        private int _numberOfWindows;
        private string _side;
        
        public int Square { get => _square; set { _square = value; } }
        public int NumberOfWindows { get => _numberOfWindows; set { _numberOfWindows = value; } }
        public string Side { get => _side; set { _side = value; } }
        public int Number { get => _number; set { _number = value; } }

        public Room(int n, int square, int numberOfWindows, string s)
        {
            Number = n;
            Square = square;
            NumberOfWindows = numberOfWindows;
            Side = s;
        }

        public Room()
        {
            Number = 0;
            Square = 0;
            NumberOfWindows = 0;
            Side = "";
        }
    }
}
