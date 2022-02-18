using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKLab2
{
    public partial class Flat : Form
    {
        public Flat()
        {
            InitializeComponent();

            myTimer.Enabled = true;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Дата и время: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        FlatInfo flat = new FlatInfo();

        private void buttonConfirmAddress_Click(object sender, EventArgs e)
        {
            try
            {
                Address flatAddress = new Address();

                flatAddress.Country = textBoxCounty.Text;
                flatAddress.City = textBoxCity.Text;
                flatAddress.District = textBoxDistrict.Text;
                flatAddress.Street = textBoxStreet.Text;

                flatAddress.House = Convert.ToInt32(textBoxHouse.Text);
                flatAddress.Housing = Convert.ToInt32(textBoxHousing.Text);
                flatAddress.NumberOfFlat = Convert.ToInt32(textBoxNumOfFlat.Text);

                flat.address = flatAddress;

                //flatRoom.Square = Convert.ToInt32(textBoxSquare.Text);
                //flatRoom.NumberOfWindows = Convert.ToInt32(textBoxNumOfWindows.Text);
                //flatRoom.Side = comboBoxSide.Text;

                //flat.rooms.Add(flatRoom);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числа, вместо слов, где подразумевается число.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonConfirmFlat_Click(object sender, EventArgs e)
        {
            flat.Footage = Convert.ToInt32(textBoxFootage.Text);
            flat.Floor = Convert.ToInt32(textBoxFloor.Text);
            flat.NumberOfRooms = trackBarNumOfRooms.Value;

            List<int> roomNumbers = new List<int>();

            for (int i = 1; i <= flat.NumberOfRooms; i++)
            {
                roomNumbers.Add(i);
            }

            flat.NumOfRooms = roomNumbers;

            flat.Kitchen = checkBoxKitchen.Checked;
            flat.Bathroom = checkBoxBathroom.Checked;
            flat.Wc = checkBoxWC.Checked;
            flat.Balcony = checkBoxBalcony.Checked;

            flat.YearOfConstruction = Convert.ToInt32(maskedTextBoxYear.Text);
        }
    }
}
