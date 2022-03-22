using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;

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
            toolStripStatusLabel.Text = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} " +
                                        $"Количество созданных объектов: {GlobalList.list.Count() + GlobalList.flats.Count() + GlobalList.rooms.Count() + Int32.Parse(GlobalList.singleton.ToString())}";
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
                    toolStripStatusLabelLast.Text = "Последнее выполненое действие: добавить адрес.";
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
                    toolStripStatusLabelLast.Text = "Последнее выполненое действие: добавить квартиру.";
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

                            toolStripStatusLabelLast.Text = "Последнее выполненое действие: добавить комнату.";
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
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: цена.";
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
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: очистка формы.";
        }
        #endregion

        #region [Save data]

        private void toolStripButtonSave_Click(object sender, EventArgs e)
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

                toolStripStatusLabelLast.Text = "Последнее выполненое действие: сохранение в XML.";
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

                    toolStripStatusLabelLast.Text = "Последнее выполненое действие: чтение из XML.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region [Sort]
        List<FlatInfo> mur = new List<FlatInfo>();
        private void ToolStripMenuSortSquare_Click(object sender, EventArgs e)
        {
            mur.Clear();
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
                    mur.Add(item);
                }
                using StreamWriter footageSorted = new StreamWriter(@"D:\Учеба в БГТУ\Пацей Н.В. ООП\Лабораторная 2-3\VKLab2\sortedFootage.json");
                var meow = JsonConvert.SerializeObject(listLINQ);
                footageSorted.WriteLine(meow);
                toolStripStatusLabelLast.Text = "Последнее выполненое действие: сортировка по площади.";
            }
        }
        private void ToolStripMenuSortRooms_Click(object sender, EventArgs e)
        {
            mur.Clear();
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
                    mur.Add(item);
                }
                using StreamWriter numOfRooms = new StreamWriter(@"D:\Учеба в БГТУ\Пацей Н.В. ООП\Лабораторная 2-3\VKLab2\sortedNumberOfRooms.json");
                var meow = JsonConvert.SerializeObject(listLINQ);
                numOfRooms.WriteLine(meow);
                toolStripStatusLabelLast.Text = "Последнее выполненое действие: сортировка по кол-ву комнат.";
            }
        }
        private void ToolStripMenuSortCost_Click(object sender, EventArgs e)
        {
            mur.Clear();
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
                    mur.Add(item);
                }
                using StreamWriter cost = new StreamWriter(@"D:\Учеба в БГТУ\Пацей Н.В. ООП\Лабораторная 2-3\VKLab2\sortedCost.json");
                var meow = JsonConvert.SerializeObject(listLINQ);
                cost.WriteLine(meow);
                toolStripStatusLabelLast.Text = "Последнее выполненое действие: сортировка по цене.";
            }
        }
        #endregion

        #region [Object auto creation]
        private void Obj_Click(object sender, EventArgs e)
        {
            try
            {
                FlatInfo flat1 = new FlatInfo();
                Address address = new Address();

                address.City = "Гомель";
                address.Country = "Беларусь";
                address.District = "Советский";
                address.House = 38;
                address.NumberOfFlat = 25;
                address.Street = "Денисенко";

                flat1.address = address;
                flat1.Footage = 120;
                flat1.Floor = 7;
                flat1.NumberOfRooms = 3;
                flat1.Wc = true;
                flat1.Bathroom = true;
                flat1.YearOfConstruction = 2019;
                flat1.Cost = 54392;

                GlobalList.list.Add(flat1);

                FlatInfo flat2 = new FlatInfo();
                Address address2 = new Address();

                address2.City = "Брест";
                address2.Country = "Беларусь";
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

                address3.City = "Минск";
                address3.Country = "Беларусь";
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

                toolStripStatusLabelLast.Text = "Последнее выполненое действие: добавить объекты.";
            }
            catch (Exception)
            {
                MessageBox.Show($"Вы уже создали такие объекты.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region [To searching form]

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Search formSearch = new Search();
            formSearch.Show();
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: поиск.";
        }

        #endregion

        #region [About]

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"V.2\n\nРазработчик: Кашперко Василиса Сергеевна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: о программе.";
        }

        #endregion

        #region [Panel visibility]

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (toolStrip.Visible == false)
            {
                toolStrip.Show();
            }
        }

        private void toolStripStatusLabelPanelHide_Click(object sender, EventArgs e)
        {
            if (toolStrip.Visible)
            {
                toolStrip.Hide();
            }
        }

        private void toolStripStatusLabelPanelShow_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelPanelShow.ForeColor = System.Drawing.Color.Green;
        }

        private void toolStripStatusLabelPanelHide_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelPanelHide.ForeColor = System.Drawing.Color.Green;
        }

        private void toolStripStatusLabelPanelHide_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelPanelHide.ForeColor = System.Drawing.Color.Black;
        }

        private void toolStripStatusLabelPanelShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelPanelShow.ForeColor = System.Drawing.Color.Black;
        }

        #endregion

        #region [Clear global list]

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GlobalList.list.Clear();
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: удалить объекты.";
        }


        #endregion

        #region [Singleton]

        private void buttonSingleton_Click(object sender, EventArgs e)
        {
            SingletonSettings singletonSettings = SingletonSettings.GetInstance();

            MessageBox.Show($"Цвет фона: {singletonSettings.bgColor.Name};\n" +
                            $"Цвет шрифта: {singletonSettings.fontColor.Name};\n" +
                            $"Название шрифта: {singletonSettings.fontName.ToString()};\n" +
                            $"Размер шрифта: {singletonSettings.fontSize.ToString()} pt;\n" +
                            $"Ширина окна формы: {singletonSettings.mainFormWidth.ToString()} px;\n" +
                            $"Высота окна формы: {singletonSettings.mainFormHeight.ToString()} px.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region [Abstract Factory]

        private void buttonAbstract_Click(object sender, EventArgs e)
        {
            IAbstractFactory gomelFactory = new GomelAbstractFactory();
            var gomelFlat = gomelFactory.CreateFlat();
            var gomelRoom = gomelFactory.CreateRoom();
            MessageBox.Show($"Созданы объекты GomelAbstractFactory:\n\n" +
                            $"GomelFlat:\n" +
                            $"\tАдрес: {gomelFlat.FlatAddress}\n" +
                            $"\tМетраж: {gomelFlat.Footage}\n\n" +
                            $"GomelRoom:\n" +
                            $"\tМетраж комнаты: {gomelRoom.RoomFootage}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GlobalList.flats.Add(gomelFlat);
            GlobalList.rooms.Add(gomelRoom);

            IAbstractFactory minskFactory = new MinskAbstractFactory();
            var minskFlat = minskFactory.CreateFlat();
            var minskRoom = minskFactory.CreateRoom();
            MessageBox.Show($"Созданы объекты MinskAbstractFactory:\n\n" +
                            $"MinskFlat:\n" +
                            $"\tАдрес: {minskFlat.FlatAddress}\n" +
                            $"\tМетраж: {minskFlat.Footage}\n\n" +
                            $"MinskRoom:\n" +
                            $"\tМетраж комнаты: {minskRoom.RoomFootage}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GlobalList.flats.Add(minskFlat);
            GlobalList.rooms.Add(minskRoom);
        }

        #endregion

        #region [Builder]

        private void buttonBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                Address flatAddress = new Address();
                int result;

                if (int.TryParse(textBoxCounty.Text, out result) == true)
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxCity.Text, out result) == true)
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxDistrict.Text, out result) == true)
                {
                    throw new Exception();
                }

                if (int.TryParse(textBoxStreet.Text, out result) == true)
                {
                    throw new Exception();
                }

                if (textBoxHousing.Text == "")
                {
                    textBoxHousing.Text = "0";
                }

                flatAddress = new FlatInfo.AddressBuilder()
                    .SetCountry(textBoxCounty.Text)
                    .SetCity(textBoxCity.Text)
                    .SetDistrict(textBoxDistrict.Text)
                    .SetStreet(textBoxStreet.Text)
                    .SetHouse(Convert.ToInt32(textBoxHouse.Text))
                    .SetHousing(Convert.ToInt32(textBoxHousing.Text))
                    .SetNumberOfFlat(Convert.ToInt32(textBoxNumOfFlat.Text))
                    .Build();

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
                    toolStripStatusLabelLast.Text = "Последнее выполненое действие: добавить адрес.";
                    MessageBox.Show($"Адрес:" +
                                    $"\n\tСтрана: {flatAddress.Country}" +
                                    $"\n\tГород: {flatAddress.City}" +
                                    $"\n\tРайон: {flatAddress.District}" +
                                    $"\n\tДом: {flatAddress.House}" +
                                    $"\n\tКорпус: {flatAddress.Housing}" +
                                    $"\n\tНомер квартиры: {flatAddress.NumberOfFlat}",
                                    "Объект создан с помощью Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region [Prototype]

        private void buttonPrototype_Click(object sender, EventArgs e)
        {
            if (GlobalList.list.Count >= 1)
            {
                FlatInfo flatForClone = GlobalList.list.Last();
                FlatInfo clonedFlat = flatForClone.Clone();
                GlobalList.list.Add(clonedFlat);

                MessageBox.Show($"Склонирована последняя квартира из списка ранее созданных квартир.\n\n" +
                                $"Страна: {clonedFlat.address.Country}\n" +
                                $"Город: {clonedFlat.address.City}\n" +
                                $"Район: {clonedFlat.address.District}\n" +
                                $"Улица: {clonedFlat.address.Street}\n" +
                                $"Дом: {clonedFlat.address.House}\n" +
                                $"Номер квартиры: {clonedFlat.address.NumberOfFlat}\n" +
                                $"Метраж: {clonedFlat.Footage}\n" +
                                $"Количество комнат: {clonedFlat.NumberOfRooms}\n" +
                                $"Год постройки: {clonedFlat.YearOfConstruction}\n" +
                                $"Этаж: {clonedFlat.Floor}\n" +
                                $"Стоимость: {clonedFlat.Cost}\n", "Prototype Clone()", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FlatInfo flatForDeepCopy = GlobalList.list.First();
                FlatInfo copiedFlat = flatForDeepCopy.DeepCopy();
                GlobalList.list.Add(copiedFlat);

                MessageBox.Show($"Первая квартира из списка ранее созданных квартир глубоко скопирована.\n\n" +
                                $"Страна: {copiedFlat.address.Country}\n" +
                                $"Город: {copiedFlat.address.City}\n" +
                                $"Район: {copiedFlat.address.District}\n" +
                                $"Улица: {copiedFlat.address.Street}\n" +
                                $"Дом: {copiedFlat.address.House}\n" +
                                $"Корпус: {copiedFlat.address.Housing}\n" +
                                $"Номер квартиры: {copiedFlat.address.NumberOfFlat}\n" +
                                $"Метраж: {copiedFlat.Footage}\n" +
                                $"Количество комнат: {copiedFlat.NumberOfRooms}\n\n" +
                                $"Ванная: {copiedFlat.Bathroom}\n" +
                                $"Балкон: {copiedFlat.Balcony}\n" +
                                $"Туалет: {copiedFlat.Wc}\n" +
                                $"Кухня: {copiedFlat.Kitchen}\n\n" +
                                $"Год постройки: {copiedFlat.YearOfConstruction}\n" +
                                $"Этаж: {copiedFlat.Floor}\n" +
                                $"Стоимость: {copiedFlat.Cost}\n", "Prototype Clone()", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Вы еще не создали ни одной квартиры.", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
