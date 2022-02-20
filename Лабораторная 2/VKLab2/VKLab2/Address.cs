using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    [Serializable]
    public class Address
    {
        private string _country;
        private string _city;
        private string _district;
        private string _street;
        private int _house;
        private int _housing;
        private int _numberOfFlat;

        [Required(ErrorMessage = "Требуется поле Страна")]
        [StringLength(30, ErrorMessage = "Вы ввели слишком короткое или длинное название страны.", MinimumLength = 2)]
        [XmlElement(ElementName = "Country")]
        public string Country { get => _country; set { _country = value; } }

        [Required]
        [StringLength(30, ErrorMessage = "Вы ввели слишком короткое или длинное название города.", MinimumLength = 2)]
        [XmlElement(ElementName = "City")]
        public string City { get => _city; set { _city = value; } }

        [Required]
        [StringLength(30, ErrorMessage = "Вы ввели слишком короткое или длинное название района.", MinimumLength = 2)]
        [XmlElement(ElementName = "District")]
        public string District { get => _district; set { _district = value; } }

        [Required]
        [StringLength(30, ErrorMessage = "Вы ввели слишком короткое или длинное название улицы.", MinimumLength = 2)]
        [XmlElement(ElementName = "Street")]
        public string Street { get => _street; set { _street = value; } }

        [Required]
        [Range(1, 500, ErrorMessage = "Вы ввели несуществующий номер дома.")]
        [XmlElement(ElementName = "House")]
        public int House { get => _house; set { _house = value; } }

        [Range(0, 20, ErrorMessage ="Вы ввели несуществующий корпус.")]
        [XmlIgnore]
        public int Housing { get => _housing; set { _housing = value; } }

        [Required]
        [Range(1, 300, ErrorMessage = "Вы ввели недопустимый номер квартиры.")]
        [XmlElement(ElementName = "NumberOfFlat")]
        public int NumberOfFlat { get => _numberOfFlat; set { _numberOfFlat = value; } }

        public Address(string country, string city, string district, string street, int house, int housing, int numberOfFlat)
        {
            Country = country;
            City = city;
            District = district;
            Street = street;
            House = house;
            Housing = housing;
            NumberOfFlat = numberOfFlat;
        }

        public Address()
        {
            Country = "";
            City = "";
            District = "";
            Street = "";
            House = 0;
            Housing = 0;
            NumberOfFlat = 0;
        }
    }
}
