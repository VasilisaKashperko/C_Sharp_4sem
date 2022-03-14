using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Linq;

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
            toolStripStatusLabel.Text = "Дата и время: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ". Количество созданных объектов: " + GlobalList.list.Count();
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
                if (flat.Kitchen == true)
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
                if (flat.YearOfConstruction > 2000)
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

        Dictionary<int, Room> rooms = new Dictionary<int, Room>();

        private void buttonConfirmOneRoom_Click(object sender, EventArgs e)
        {
            try
            {
                var info = "Данные о комнатах:\n";

                if (rooms.ContainsKey(Convert.ToInt32(comboBoxFlat.Text)))
                {
                    footageIsSquareCheck -= Convert.ToInt32(textBoxSquare.Text);
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

                    if (footageIsSquare < footageIsSquareCheck)
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
                            footageIsSquareCheck -= Convert.ToInt32(textBoxSquare.Text);
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
                GlobalList.list.Add(new FlatInfo(flat.Footage, flat.NumberOfRooms, flat.Kitchen, flat.Bathroom, flat.Wc, flat.Balcony, flat.YearOfConstruction, flat.Floor, flat.address));
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
            footageIsSquareCheck = 0;
            richTextBoxRooms.Text = "Данные о комнатах:\n";
        }
        #endregion

        #region [Save data]

        private void toolStripButtonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<FlatInfo> list = new List<FlatInfo>();
                list.Add(flat);

                XmlSerializer xml = new XmlSerializer(typeof(List<FlatInfo>));

                saveFileDialog.FileName = "results.xml";
                saveFileDialog.ShowDialog();

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, list);
                    MessageBox.Show("Данные записаны!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuSaveSort_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(List<string>));

            //    saveFileDialog.FileName = "resultsSorted.xml";
            //    saveFileDialog.ShowDialog();

            //    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            //    {
            //        xml.Serialize(fs, mur);
            //        MessageBox.Show("Данные записаны!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        #endregion

        #region [Read data]
        private void toolStripButtonRead_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<FlatInfo>));
                List<FlatInfo> flat;
                openFileDialog.FileName = "results.xml";
                openFileDialog.ShowDialog();

                using (FileStream fst = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    flat = (List<FlatInfo>)xml.Deserialize(fst);
                }

                if (flat.Count != 0)
                {
                    Read read = new Read();
                    read.Show();

                    foreach (FlatInfo st in flat)
                    {
                        read.listBox.Items.Add($"АДРЕС");
                        read.listBox.Items.Add($"\tСтрана: {st.address.Country}");
                        read.listBox.Items.Add($"\tГород: {st.address.City}");
                        read.listBox.Items.Add($"\tРайон: {st.address.District}");
                        read.listBox.Items.Add($"\tУлица: {st.address.Street}");
                        read.listBox.Items.Add($"\tДом: {st.address.House}");
                        read.listBox.Items.Add($"\tКорпус: {st.address.Housing}");
                        read.listBox.Items.Add($"\tНомер квартиры: {st.address.NumberOfFlat}");

                        read.listBox.Items.Add($"ДАННЫЕ О КВАРТИРЕ");
                        read.listBox.Items.Add($"\tМетраж: {st.Footage}");
                        read.listBox.Items.Add($"\tЭтажа: {st.Footage}");
                        read.listBox.Items.Add($"\tКоличество комнат: {st.NumberOfRooms}");
                        
                        if(st.Kitchen == true)
                        {
                            read.listBox.Items.Add($"\tЕсть кухня");
                        }
                        if (st.Wc == true)
                        {
                            read.listBox.Items.Add($"\tЕсть туалет");
                        }
                        if (st.Bathroom == true)
                        {
                            read.listBox.Items.Add($"\tЕсть ванная комната");
                        }
                        if (st.Balcony == true)
                        {
                            read.listBox.Items.Add($"\tЕсть балкон");
                        }

                        read.listBox.Items.Add($"\tГод постройки: {st.YearOfConstruction}");

                        read.listBox.Items.Add($"СТОИМОСТЬ КВАРТИРЫ: {st.Cost}$");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region [Sort]
        //public List<string> mur = null;
        private void ToolStripMenuSortSquare_Click(object sender, EventArgs e)
        {
            IEnumerable<FlatInfo> listLINQ;

            listLINQ = from i in GlobalList.list orderby i.Footage select i;
            Sorting sorting = new Sorting();
            sorting.Show();

            if (GlobalList.list.Count == 0)
            {
                sorting.listBoxSorting.Items.Add($"Нам нечего сортировать. Нет объектов для сортировки.");
            }

            else
            {
                foreach (FlatInfo item in listLINQ)
                {
                    sorting.listBoxSorting.Items.Add($"{item.address.Country}, {item.address.City}, {item.address.Street}, площадь: {item.Footage}");
                }
                //foreach (string item in sorting.listBoxSorting.Items)
                //{
                //    mur.Add(item.ToString());
                //}
            }
        }
        private void ToolStripMenuSortRooms_Click(object sender, EventArgs e)
        {
            IEnumerable<FlatInfo> listLINQ;

            listLINQ = from i in GlobalList.list orderby i.NumberOfRooms select i;
            Sorting sorting = new Sorting();
            sorting.Show();

            if (GlobalList.list.Count == 0)
            {
                sorting.listBoxSorting.Items.Add($"Нам нечего сортировать. Нет объектов для сортировки.");
            }

            else
            {
                foreach (FlatInfo item in listLINQ)
                {
                    sorting.listBoxSorting.Items.Add($"{item.address.Country}, {item.address.City}, {item.address.Street}, количество комнат: {item.NumberOfRooms}");
                }
            }
        }
        private void ToolStripMenuSortCost_Click(object sender, EventArgs e)
        {
            IEnumerable<FlatInfo> listLINQ;

            listLINQ = from i in GlobalList.list orderby i.Cost select i;
            Sorting sorting = new Sorting();
            sorting.Show();

            if (GlobalList.list.Count == 0)
            {
                sorting.listBoxSorting.Items.Add($"Нам нечего сортировать. Нет объектов для сортировки.");
            }

            else
            {
                foreach (FlatInfo item in listLINQ)
                {
                    sorting.listBoxSorting.Items.Add($"{item.address.Country}, {item.address.City}, {item.address.Street}, цена: {item.Cost}");
                }
            }
        }
        #endregion

        #region [Object autoCreation]
        private void Obj_Click(object sender, EventArgs e)
        {
            try
            {
                FlatInfo flat1 = new FlatInfo();
                Address address = new Address();

                address.City = "Беларусь";
                address.Country = "Гомель";
                address.District = "Советский";
                address.House = 38;
                address.NumberOfFlat = 25;
                address.Street = "Денисенко";

                flat1.address = address;
                flat1.Footage = 120;
                flat1.Floor = 7;
                flat1.NumberOfRooms = 3;
                flat1.YearOfConstruction = 2019;
                flat1.Cost = 54392;

                GlobalList.list.Add(flat1);

                FlatInfo flat2 = new FlatInfo();
                Address address2 = new Address();

                address2.City = "Беларусь";
                address2.Country = "Брест";
                address2.District = "Ленинский";
                address2.House = 28;
                address2.NumberOfFlat = 53;
                address2.Street = "Рокоссовского";

                flat2.address = address2;
                flat2.Footage = 163;
                flat2.Floor = 4;
                flat2.Kitchen = true;
                flat2.Wc = true;
                flat2.Balcony = true;
                flat2.Bathroom = true;
                flat2.NumberOfRooms = 2;
                flat2.YearOfConstruction = 2010;
                flat2.Cost = 42634;

                GlobalList.list.Add(flat2);

                FlatInfo flat3 = new FlatInfo();
                Address address3 = new Address();

                address3.City = "Беларусь";
                address3.Country = "Минск";
                address3.District = "Ленинский";
                address3.House = 21;
                address3.NumberOfFlat = 614;
                address3.Street = "Белорусская";

                flat3.address = address3;
                flat3.Footage = 143;
                flat3.Floor = 3;
                flat3.Kitchen = true;
                flat3.Wc = true;
                flat3.Balcony = true;
                flat3.Bathroom = true;
                flat3.NumberOfRooms = 2;
                flat3.YearOfConstruction = 2001;
                flat3.Cost = 58302;

                GlobalList.list.Add(flat3);
            }
            catch (Exception)
            {
                MessageBox.Show($"Вы уже создали такие объекты.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
