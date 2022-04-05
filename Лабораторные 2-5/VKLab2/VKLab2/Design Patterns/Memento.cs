using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    // Memento
    public class Memento
    {
        private int _footage; // метраж
        private int _numberOfRooms;

        private bool _kitchen; // опции
        private bool _bathroom;
        private bool _wc;
        private bool _balcony;

        private int _yearOfConstruction;
        private int _floor;
        private int _cost;

        public Address address;

        public Dictionary<int, Room> AllRooms;

        public List<int> NumOfRooms;

        public int Footage { get => _footage; set { _footage = value; } }

        public int NumberOfRooms { get => _numberOfRooms; set { _numberOfRooms = value; } }

        public bool Kitchen { get => _kitchen; set { _kitchen = value; } }

        public bool Bathroom { get => _bathroom; set { _bathroom = value; } }

        public bool Wc { get => _wc; set { _wc = value; } }

        public bool Balcony { get => _balcony; set { _balcony = value; } }

        public int YearOfConstruction { get => _yearOfConstruction; set { _yearOfConstruction = value; } }

        public int Floor { get => _floor; set { _floor = value; } }

        public int Cost { get => _cost; set { _cost = value; } }

        public Memento(int footage, int numberOfRooms, bool kitchen, bool bathroom, bool wc, bool balcony, int yearOfConstruction, int floor, Address add, int c)
        {
            Footage = footage;
            NumberOfRooms = numberOfRooms;
            Kitchen = kitchen;
            Bathroom = bathroom;
            Wc = wc;
            Balcony = balcony;
            YearOfConstruction = yearOfConstruction;
            Floor = floor;
            address = add;
            Cost = c;
        }
    }

    // Caretaker
    public class History
    {
        public Stack<Memento> His { get; private set; }
        public History()
        {
            His = new Stack<Memento>();
        }
    }
}
