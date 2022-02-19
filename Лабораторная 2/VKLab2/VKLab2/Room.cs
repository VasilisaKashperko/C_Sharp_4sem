using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [Range(10, 120, ErrorMessage = "Вы ввели некорректную площадь комнаты.")]
        public int Square { get => _square; set { _square = value; } }

        [Required]
        [Range(1, 6, ErrorMessage = "Вы ввели недопустимое количество окон в комнате.")]
        public int NumberOfWindows { get => _numberOfWindows; set { _numberOfWindows = value; } }

        [Required]
        public string Side { get => _side; set { _side = value; } }

        [Required]
        [Range(1, 6, ErrorMessage = "Столько комнат не было задано Вами ранее.")]
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
