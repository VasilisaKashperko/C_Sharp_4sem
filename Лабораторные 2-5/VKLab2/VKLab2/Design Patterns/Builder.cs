using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public partial class FlatInfo
    {
        public interface IAddressBuilder
        {
            IAddressBuilder SetCountry(string Country);
            IAddressBuilder SetCity(string City);
            IAddressBuilder SetDistrict(string District);
            IAddressBuilder SetStreet(string Street);
            IAddressBuilder SetHouse(int House);
            IAddressBuilder SetHousing(int Housing);
            IAddressBuilder SetNumberOfFlat(int NumberOfFlat);
            Address Build();
        }
        public class AddressBuilder : IAddressBuilder
        {
            Address address;
            public AddressBuilder() => address = new Address();
            public Address Build() => address;

            public IAddressBuilder SetCountry(string Country)
            {
                address.Country = Country;
                return this;
            }
            public IAddressBuilder SetCity(string City)
            {
                address.City = City;
                return this;
            }
            public IAddressBuilder SetDistrict(string District)
            {
                address.District = District;
                return this;
            }
            public IAddressBuilder SetStreet(string Street)
            {
                address.Street = Street;
                return this;
            }
            public IAddressBuilder SetHouse(int House)
            {
                address.House = House;
                return this;
            }
            public IAddressBuilder SetHousing(int Housing)
            {
                address.Housing = Housing;
                return this;
            }
            public IAddressBuilder SetNumberOfFlat(int NumberOfFlat)
            {
                address.NumberOfFlat = NumberOfFlat;
                return this;
            }
        }
    }
}
