using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Xml.Serialization;
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
                int result;

                if (int.TryParse(textBoxCounty.Text, out result) != true)
                {
                    flatAddress.Country = textBoxCounty.Text;
                }
                else
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxCity.Text, out result) != true)
                {
                    flatAddress.City = textBoxCity.Text;
                }
                else
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxDistrict.Text, out result) != true)
                {
                    flatAddress.District = textBoxDistrict.Text;
                }
                else
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxStreet.Text, out result) != true)
                {
                    flatAddress.Street = textBoxStreet.Text;
                }
                else
                {
                    throw new Exception();
                }

                flatAddress.House = Convert.ToInt32(textBoxHouse.Text);

                if (textBoxHousing.Text != "")
                {
                    flatAddress.Housing = Convert.ToInt32(textBoxHousing.Text);
                }
                else
                {
                    flatAddress.Housing = 0;
                }

                flatAddress.NumberOfFlat = Convert.ToInt32(textBoxNumOfFlat.Text);

                flat.address = flatAddress;

                var results = new List<ValidationResult>();
                var context = new ValidationContext(flatAddress);

                if (!Validator.TryValidateObject(flatAddress, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show($"{error.ErrorMessage}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Данные об адресе записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show($"Введите числа в поля АДРЕСА, где подразумевается число, вместо слов.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show($"Введите слова в поля АДРЕСА, где подразумеваются названия, вместо чисел.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region [Flat]

        public int footageIsSquare = 0;

        private void buttonConfirmFlat_Click(object sender, EventArgs e)
        {
            try
            {
                #region [Clear data and values]
                rooms.Clear();
                richTextBoxRooms.Text = "Данные о комнатах:\n";
                #endregion

                int cost = 2000;

                flat.Footage = Convert.ToInt32(textBoxFootage.Text);
                footageIsSquare = Convert.ToInt32(textBoxFootage.Text);
                cost += flat.Footage;

                flat.Floor = Convert.ToInt32(textBoxFloor.Text);
                cost *= flat.Floor;

                flat.NumberOfRooms = trackBarNumOfRooms.Value;
                cost *= flat.NumberOfRooms;

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
                if(flat.Kitchen == true)
                {
                    cost += 500;
                }

                flat.Bathroom = checkBoxBathroom.Checked;
                if (flat.Bathroom == true)
                {
                    cost += 500;
                }

                flat.Wc = checkBoxWC.Checked;
                if (flat.Wc == true)
                {
                    cost += 500;
                }

                flat.Balcony = checkBoxBalcony.Checked;
                if (flat.Balcony == true)
                {
                    cost += 500;
                }

                flat.YearOfConstruction = Convert.ToInt32(maskedTextBoxYear.Text);
                if(flat.YearOfConstruction > 2000)
                {
                    cost += 10000;
                }

                flat.Cost = cost;

                var results = new List<ValidationResult>();
                var context = new ValidationContext(flat);

                if (!Validator.TryValidateObject(flat, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show($"{error.ErrorMessage}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Данные о квартире записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show($"Введите числа в поля КВАРТИРЫ, где подразумевается число, вместо слов.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public int footageIsSquareCheck = 0;

        SortedList<int, Room> rooms = new SortedList<int, Room>();

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
                    Room roomForCheck = new Room();

                    roomForCheck.Number = Convert.ToInt32(comboBoxFlat.Text);

                    roomForCheck.NumberOfWindows = Convert.ToInt32(textBoxNumOfWindows.Text);

                    roomForCheck.Square = Convert.ToInt32(textBoxSquare.Text);
                    footageIsSquareCheck += Convert.ToInt32(textBoxSquare.Text);
                    roomForCheck.Side = comboBoxSide.Text;

                    var results = new List<ValidationResult>();
                    var context = new ValidationContext(roomForCheck);

                    if (footageIsSquare < footageIsSquareCheck )
                    {
                        footageIsSquareCheck -= Convert.ToInt32(textBoxSquare.Text);
                        throw new ConstraintException();
                    }

                    else
                    {
                        if (!Validator.TryValidateObject(roomForCheck, context, results, true))
                        {
                            foreach (var error in results)
                            {
                                MessageBox.Show($"{error.ErrorMessage}", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        else
                        {
                            rooms.Add(Convert.ToInt32(comboBoxFlat.Text), new Room(Convert.ToInt32(comboBoxFlat.Text), Convert.ToInt32(textBoxSquare.Text), Convert.ToInt32(textBoxNumOfWindows.Text), comboBoxSide.Text));

                            foreach (var r in rooms.Values)
                            {
                                info += $"Номер: {r.Number} Площадь: {r.Square} Кол-во окон: {r.NumberOfWindows} Сторона: {r.Side}\n";
                            }

                            richTextBoxRooms.Text = info;
                            flat.AllRooms = rooms;

                            MessageBox.Show("Данные о комнате записаны.", "Системный фидбэк", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
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
            catch (ConstraintException)
            {
                MessageBox.Show($"Площадь всех комнат превышает метраж самой квартиры. Измените площадь комнаты или введите другой метраж квартиры.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region [Cost]

        private void buttonConfirmRooms_Click(object sender, EventArgs e)
        {
            Cost Cost = new Cost();
            Cost.Show();
            if (flat.Cost <= 2000)
            {
                Cost.LabelCost = $"Вы не ввели все данные";
            }
            else
            {
                Cost.LabelCost = $"{flat.Cost} $";
            }
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
            textBoxHousing.Text = "";
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
            footageIsSquareCheck = 0;
            footageIsSquare = 0;

            rooms.Clear();
            richTextBoxRooms.Text = "Данные о комнатах:\n";
        }
        #endregion

        #region [Save data]

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //List<FlatInfo> list = new List<FlatInfo>();
                //list.Add(flat);

                saveFileDialog.FileName = "results.xml";
                saveFileDialog.ShowDialog();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(FlatInfo));

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, flat);
                }

                //XmlSerializeWrapper.Serialize(list, "results.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region [Read data]
        private void toolStripButtonRead_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "results.xml";
            openFileDialog.ShowDialog();
            Read read = new Read();
            read.Show();

            List<FlatInfo> result;
            try
            {
                using (FileStream fst = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FlatInfo>));
                    result = (List<FlatInfo>)xmlSerializer.Deserialize(fst);
                }

                if (result.Count != 0)
                {
                    foreach (FlatInfo res in result)
                    {
                        GlobalList.list.Add(res);
                        read.listBox.Items.Add(res);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
