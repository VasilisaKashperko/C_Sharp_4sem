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

        #region [Timer]
        private void myTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Дата и время: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region [Address]

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

            catch (FormatException)
            {
                MessageBox.Show($"Введите числа в поля АДРЕСА, где подразумевается число, вместо слов.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Данные об адресе записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region [Flat]
        private void buttonConfirmFlat_Click(object sender, EventArgs e)
        {
            try
            {
                rooms.Clear();
                richTextBoxRooms.Text = "Данные о комнатах:\n";

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
            catch (FormatException)
            {
                MessageBox.Show($"Введите числа в поля КВАРТИРЫ, где подразумевается число, вместо слов.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Данные о квартире записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void comboBoxFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSquare.Text = "";
            textBoxNumOfWindows.Text = "";
            comboBoxSide.SelectedItem = null;
        }
        #endregion

        #region [Rooms]

        Dictionary<int, Room> rooms = new Dictionary<int, Room>();

        private void buttonConfirmOneRoom_Click(object sender, EventArgs e)
        {
            try
            {
                var info = "Данные о комнатах:\n";

                if (rooms.ContainsKey(Convert.ToInt32(comboBoxFlat.Text)))
                {
                    throw new WarningException();
                }
                else
                {
                    rooms.Add(Convert.ToInt32(comboBoxFlat.Text), new Room(Convert.ToInt32(comboBoxFlat.Text), Convert.ToInt32(textBoxSquare.Text), Convert.ToInt32(textBoxNumOfWindows.Text), comboBoxSide.Text));

                    foreach (var r in rooms.Values)
                    {
                        info += $"Номер: {r.Number} Площадь: {r.Square} Кол-во окон: {r.NumberOfWindows} Сторона: {r.Side}\n";
                    }

                    richTextBoxRooms.Text = info;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show($"Введите числа в поля КОМНАТЫ, где подразумевается число, вместо слов.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (WarningException)
            {
                MessageBox.Show($"Данные о такой комнате уже существуют.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #endregion

        #region [Recycle bin]
        private void toolStripRecycleBin_Click(object sender, EventArgs e)
        {
            textBoxCounty.Text = null;
            textBoxCity.Text = null;
            textBoxDistrict.Text = null;
            textBoxStreet.Text = null;
            textBoxHouse.Text = null;
            textBoxHousing.Text = null;
            textBoxNumOfFlat.Text = null;

            textBoxFootage.Text = null;
            textBoxFloor.Text = null;
            trackBarNumOfRooms.Value = 1;
            checkBoxKitchen.Checked = false;
            checkBoxBathroom.Checked = false;
            checkBoxWC.Checked = false;
            checkBoxBalcony.Checked = false;
            maskedTextBoxYear.Text = null;

            comboBoxFlat.SelectedIndex = -1;
            textBoxSquare.Text = null;
            textBoxNumOfWindows.Text = null;
            comboBoxSide.SelectedIndex = -1;

            rooms.Clear();
            richTextBoxRooms.Text = "Данные о комнатах:\n";
        }
        #endregion
    }
}
