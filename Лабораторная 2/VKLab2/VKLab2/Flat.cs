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
            }

            catch (FormatException ex)
            {
                MessageBox.Show($"Введите числа в поля АДРЕСА, где подразумевается число, вместо слов.\n{ex.Message}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Данные об адресе записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonConfirmFlat_Click(object sender, EventArgs e)
        {
            try
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

                var bindingSource = new BindingSource();
                bindingSource.DataSource = roomNumbers;
                comboBoxFlat.DataSource = bindingSource.DataSource;

                flat.Kitchen = checkBoxKitchen.Checked;
                flat.Bathroom = checkBoxBathroom.Checked;
                flat.Wc = checkBoxWC.Checked;
                flat.Balcony = checkBoxBalcony.Checked;

                flat.YearOfConstruction = Convert.ToInt32(maskedTextBoxYear.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Введите числа в поля КВАРТИРЫ, где подразумевается число, вместо слов.\n{ex.Message}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Данные о квартире записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Dictionary<int, Room> rooms = new Dictionary<int, Room>();

        private void buttonConfirmOneRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (rooms.ContainsKey(Convert.ToInt32(comboBoxFlat.Text)))
                {
                    throw new ArgumentException();
                }
                else
                {
                    rooms.Add(Convert.ToInt32(comboBoxFlat.Text), new Room(Convert.ToInt32(comboBoxFlat.Text), Convert.ToInt32(textBoxSquare.Text), Convert.ToInt32(textBoxNumOfWindows.Text), comboBoxSide.Text));

                    var info = "Данные о комнатах:\n";

                    foreach (var r in rooms.Values)
                    {
                        info += $"Номер: {r.Number} Площадь: {r.Square} Кол-во окон: {r.NumberOfWindows} Сторона: {r.Side}\n";
                    }

                    richTextBoxRooms.Text = info;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Введите числа в поля КОМНАТЫ, где подразумевается число, вместо слов.\n{ex.Message}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Данные о такой комнате уже существуют.\n{ex.Message}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Данные о комнате записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonConfirmRooms_Click(object sender, EventArgs e)
        {
            flat.AllRooms = rooms;
        }

        private void comboBoxFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSquare.Text = "";
            textBoxNumOfWindows.Text = "";
            comboBoxSide.SelectedItem = null;
        }
    }
}
