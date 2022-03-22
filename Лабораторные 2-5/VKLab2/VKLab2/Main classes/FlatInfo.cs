using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Xml.Serialization;
//using Microsoft.WindowsServerSolutions.Administration.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    [Serializable]

    public partial class FlatInfo : FlatPrototype<FlatInfo>
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

        [Required]
        public Address address;

        [Required]
        [XmlIgnore]
        public Dictionary<int, Room> AllRooms;

        public List<int> NumOfRooms;

        [Required]
        [Range(50, 500, ErrorMessage = "Вы ввели недопустимое количество метража квартиры.")]
        public int Footage { get => _footage; set { _footage = value; } }

        [Required]
        [Range(1, 6, ErrorMessage = "Вы ввели недопустимое количество комнат в квартире.")]
        public int NumberOfRooms { get => _numberOfRooms; set { _numberOfRooms = value; } }

        public bool Kitchen { get => _kitchen; set { _kitchen = value; } }

        public bool Bathroom { get => _bathroom; set { _bathroom = value; } }

        public bool Wc { get => _wc; set { _wc = value; } }

        public bool Balcony { get => _balcony; set { _balcony = value; } }

        [Required]
        [Attribute(ErrorMessage = "Вы ввели недопустимый год постройки.")]
        //[Range(1960, 2022, ErrorMessage = "Вы ввели недопустимый год постройки.")] - был до этого такой атрибут
        public int YearOfConstruction { get => _yearOfConstruction; set { _yearOfConstruction = value; } }

        [Required]
        [Range(1, 20, ErrorMessage = "Вы ввели несуществующий этаж.")]
        public int Floor { get => _floor; set { _floor = value; } }

        public int Cost { get => _cost; set { _cost = value; } }

        public FlatInfo(int footage, int numberOfRooms, bool kitchen, bool bathroom, bool wc, bool balcony, int yearOfConstruction, int floor, Address add)
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
        }

        public FlatInfo()
        {
            Footage = 0;
            NumberOfRooms = 0;
            Kitchen = false;
            Bathroom = false;
            Wc = false;
            Balcony = false;
            YearOfConstruction = 0;
            Floor = 0;
        }

        public FlatInfo(FlatInfo flat)
        {
            Footage = flat.Footage;
            NumberOfRooms = flat.NumberOfRooms;
            YearOfConstruction = flat.YearOfConstruction;
            address.District = flat.address.District;
            address.City = flat.address.City;
            Cost = flat.Cost;
        }

        public override string ToString()
        {
            return address.Country + ", " + address.City + ", " + address.District + ". "
                + address.Street + ", " + address.House + "," + address.Housing + ", " + address.NumberOfFlat + ". "
                + Footage + ", " + NumberOfRooms + ", " + YearOfConstruction + ", " + Floor + ". "
                + ". \n\n";
        }
    }

}
