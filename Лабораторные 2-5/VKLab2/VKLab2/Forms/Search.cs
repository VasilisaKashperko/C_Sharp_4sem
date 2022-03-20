using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;

namespace VKLab2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        #region [Search]

        IEnumerable<FlatInfo> listLINQForJson = GlobalList.list;

        private void buttonConfirmSearch_Click(object sender, EventArgs e)
        {
            IEnumerable<FlatInfo> listLINQ = GlobalList.list;
            listBoxSearch.Items.Clear();

            List<FlatInfo> listCity = new List<FlatInfo>();
            List<FlatInfo> listDistrict = new List<FlatInfo>();

            bool city = false;
            bool district = false;

            if (trackBarNumOfRooms.Value != 0)
            {
                listLINQ = listLINQ.Where(i => i.NumberOfRooms == trackBarNumOfRooms.Value);
            }

            if (maskedTextBoxYear.Text != null && maskedTextBoxYear.Text != "")
            {
                listLINQ = listLINQ.Where(i => i.YearOfConstruction == int.Parse(maskedTextBoxYear.Text));
            }

            if (textBoxCity.Text != null && textBoxCity.Text != "")
            {
                RegexOptions optionCity = RegexOptions.IgnoreCase;
                Regex CityReg = new Regex(textBoxCity.Text, optionCity);

                Match cityMatches = null;

                foreach (var list in listLINQ)
                {
                    cityMatches = CityReg.Match(list.address.City);

                    if (cityMatches.Success)
                    {
                        listCity.Add(list);
                    }
                }

                city = true;
            }

            if (textBoxDistrict.Text != null && textBoxDistrict.Text != "")
            {
                RegexOptions optionDistrict = RegexOptions.IgnoreCase;
                Regex DistrictReg = new Regex(textBoxDistrict.Text, optionDistrict);

                Match districtMatches = null;

                foreach (var list in listLINQ)
                {
                    districtMatches = DistrictReg.Match(list.address.District);

                    if (districtMatches.Success)
                    {
                        listDistrict.Add(list);
                    }
                }

                district = true;
            }

            if (city == true && district == false)
            {
                listLINQ = listCity;
            }

            if (district == true && city == false)
            {
                listLINQ = listDistrict;
            }

            if (city == true && district == true)
            {
                listLINQ = listCity.Intersect(listDistrict);
            }

            foreach (var list in listLINQ)
            {
                listBoxSearch.Items.Add(list);
            }

            listLINQForJson = listLINQ;
        }
        #endregion

        #region [Save]

        private void buttonSearchSave_Click(object sender, EventArgs e)
        {
            using StreamWriter searched = new StreamWriter(@"D:\Учеба в БГТУ\Пацей Н.В. ООП\Лабораторная 2-3\VKLab2\searched.json");
            var meow = JsonConvert.SerializeObject(listLINQForJson);
            searched.WriteLine(meow);
        }

        #endregion

        #region [Clear]

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
        }

        #endregion

        #region [Validation]

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;

            if (!Char.IsLetter(letter) && letter != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;

            if (!Char.IsLetter(letter) && letter != 8)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
