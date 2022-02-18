namespace VKLab2
{
    partial class Flat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flat));
            this.lableAddress = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelHousing = new System.Windows.Forms.Label();
            this.labelNumberOfFlat = new System.Windows.Forms.Label();
            this.lableFlat = new System.Windows.Forms.Label();
            this.labelFootage = new System.Windows.Forms.Label();
            this.labelNumberOfRooms = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelYearOfConstruction = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelNumberOfWindows = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();
            this.buttonConfirmAddress = new System.Windows.Forms.Button();
            this.textBoxCounty = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxHousing = new System.Windows.Forms.TextBox();
            this.textBoxNumOfFlat = new System.Windows.Forms.TextBox();
            this.textBoxFootage = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.checkBoxKitchen = new System.Windows.Forms.CheckBox();
            this.checkBoxBathroom = new System.Windows.Forms.CheckBox();
            this.checkBoxWC = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxNumOfWindows = new System.Windows.Forms.TextBox();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFlat = new System.Windows.Forms.ComboBox();
            this.flatInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSide = new System.Windows.Forms.ComboBox();
            this.trackBarNumOfRooms = new System.Windows.Forms.TrackBar();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelSix = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonConfirmFlat = new System.Windows.Forms.Button();
            this.flatInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flatInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfRooms)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lableAddress
            // 
            this.lableAddress.AutoSize = true;
            this.lableAddress.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lableAddress.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableAddress.Location = new System.Drawing.Point(168, 55);
            this.lableAddress.Name = "lableAddress";
            this.lableAddress.Size = new System.Drawing.Size(76, 26);
            this.lableAddress.TabIndex = 0;
            this.lableAddress.Text = "Адрес";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(40, 110);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(77, 22);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Страна:";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(40, 162);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(65, 22);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "Город:";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelDistrict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistrict.Location = new System.Drawing.Point(40, 215);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(68, 22);
            this.labelDistrict.TabIndex = 3;
            this.labelDistrict.Text = "Район:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelStreet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(40, 268);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(69, 22);
            this.labelStreet.TabIndex = 4;
            this.labelStreet.Text = "Улица:";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelHouse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHouse.Location = new System.Drawing.Point(40, 322);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(53, 22);
            this.labelHouse.TabIndex = 5;
            this.labelHouse.Text = "Дом:";
            // 
            // labelHousing
            // 
            this.labelHousing.AutoSize = true;
            this.labelHousing.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelHousing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHousing.Location = new System.Drawing.Point(40, 375);
            this.labelHousing.Name = "labelHousing";
            this.labelHousing.Size = new System.Drawing.Size(77, 22);
            this.labelHousing.TabIndex = 6;
            this.labelHousing.Text = "Корпус:";
            // 
            // labelNumberOfFlat
            // 
            this.labelNumberOfFlat.AutoSize = true;
            this.labelNumberOfFlat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelNumberOfFlat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfFlat.Location = new System.Drawing.Point(40, 428);
            this.labelNumberOfFlat.Name = "labelNumberOfFlat";
            this.labelNumberOfFlat.Size = new System.Drawing.Size(158, 22);
            this.labelNumberOfFlat.TabIndex = 7;
            this.labelNumberOfFlat.Text = "Номер квартиры:";
            // 
            // lableFlat
            // 
            this.lableFlat.AutoSize = true;
            this.lableFlat.BackColor = System.Drawing.Color.LightCyan;
            this.lableFlat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableFlat.Location = new System.Drawing.Point(550, 57);
            this.lableFlat.Name = "lableFlat";
            this.lableFlat.Size = new System.Drawing.Size(117, 26);
            this.lableFlat.TabIndex = 8;
            this.lableFlat.Text = "Квартира";
            // 
            // labelFootage
            // 
            this.labelFootage.AutoSize = true;
            this.labelFootage.BackColor = System.Drawing.Color.LightCyan;
            this.labelFootage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFootage.Location = new System.Drawing.Point(421, 112);
            this.labelFootage.Name = "labelFootage";
            this.labelFootage.Size = new System.Drawing.Size(84, 22);
            this.labelFootage.TabIndex = 9;
            this.labelFootage.Text = "Метраж:";
            // 
            // labelNumberOfRooms
            // 
            this.labelNumberOfRooms.AutoSize = true;
            this.labelNumberOfRooms.BackColor = System.Drawing.Color.LightCyan;
            this.labelNumberOfRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfRooms.Location = new System.Drawing.Point(421, 215);
            this.labelNumberOfRooms.Name = "labelNumberOfRooms";
            this.labelNumberOfRooms.Size = new System.Drawing.Size(180, 22);
            this.labelNumberOfRooms.TabIndex = 10;
            this.labelNumberOfRooms.Text = "Количество комнат:";
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.BackColor = System.Drawing.Color.LightCyan;
            this.labelOptions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(421, 268);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(74, 22);
            this.labelOptions.TabIndex = 11;
            this.labelOptions.Text = "Опции:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.BackColor = System.Drawing.Color.LightCyan;
            this.labelFloor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloor.Location = new System.Drawing.Point(421, 166);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(66, 22);
            this.labelFloor.TabIndex = 13;
            this.labelFloor.Text = "Этаж: ";
            // 
            // labelYearOfConstruction
            // 
            this.labelYearOfConstruction.AutoSize = true;
            this.labelYearOfConstruction.BackColor = System.Drawing.Color.LightCyan;
            this.labelYearOfConstruction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearOfConstruction.Location = new System.Drawing.Point(421, 428);
            this.labelYearOfConstruction.Name = "labelYearOfConstruction";
            this.labelYearOfConstruction.Size = new System.Drawing.Size(146, 22);
            this.labelYearOfConstruction.TabIndex = 12;
            this.labelYearOfConstruction.Text = "Год постройки: ";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.BackColor = System.Drawing.Color.AliceBlue;
            this.labelRoom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoom.Location = new System.Drawing.Point(873, 57);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(134, 26);
            this.labelRoom.TabIndex = 14;
            this.labelRoom.Text = "Комната №";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.BackColor = System.Drawing.Color.AliceBlue;
            this.labelSquare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare.Location = new System.Drawing.Point(822, 112);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(92, 22);
            this.labelSquare.TabIndex = 15;
            this.labelSquare.Text = "Площадь:";
            // 
            // labelNumberOfWindows
            // 
            this.labelNumberOfWindows.AutoSize = true;
            this.labelNumberOfWindows.BackColor = System.Drawing.Color.AliceBlue;
            this.labelNumberOfWindows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfWindows.Location = new System.Drawing.Point(822, 164);
            this.labelNumberOfWindows.Name = "labelNumberOfWindows";
            this.labelNumberOfWindows.Size = new System.Drawing.Size(160, 22);
            this.labelNumberOfWindows.TabIndex = 16;
            this.labelNumberOfWindows.Text = "Количество окон:";
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.BackColor = System.Drawing.Color.AliceBlue;
            this.labelSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSide.Location = new System.Drawing.Point(822, 215);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(133, 22);
            this.labelSide.TabIndex = 17;
            this.labelSide.Text = "Сторона окон:";
            // 
            // buttonConfirmAddress
            // 
            this.buttonConfirmAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmAddress.Location = new System.Drawing.Point(28, 492);
            this.buttonConfirmAddress.Name = "buttonConfirmAddress";
            this.buttonConfirmAddress.Size = new System.Drawing.Size(294, 37);
            this.buttonConfirmAddress.TabIndex = 20;
            this.buttonConfirmAddress.Text = "Принять данные";
            this.buttonConfirmAddress.UseVisualStyleBackColor = true;
            this.buttonConfirmAddress.Click += new System.EventHandler(this.buttonConfirmAddress_Click);
            // 
            // textBoxCounty
            // 
            this.textBoxCounty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCounty.Location = new System.Drawing.Point(124, 102);
            this.textBoxCounty.Name = "textBoxCounty";
            this.textBoxCounty.Size = new System.Drawing.Size(164, 30);
            this.textBoxCounty.TabIndex = 21;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(124, 156);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(164, 30);
            this.textBoxCity.TabIndex = 22;
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistrict.Location = new System.Drawing.Point(124, 210);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(164, 30);
            this.textBoxDistrict.TabIndex = 23;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(124, 264);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(164, 30);
            this.textBoxStreet.TabIndex = 24;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(124, 318);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(74, 30);
            this.textBoxHouse.TabIndex = 25;
            // 
            // textBoxHousing
            // 
            this.textBoxHousing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHousing.Location = new System.Drawing.Point(124, 372);
            this.textBoxHousing.Name = "textBoxHousing";
            this.textBoxHousing.Size = new System.Drawing.Size(164, 30);
            this.textBoxHousing.TabIndex = 26;
            // 
            // textBoxNumOfFlat
            // 
            this.textBoxNumOfFlat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumOfFlat.Location = new System.Drawing.Point(204, 425);
            this.textBoxNumOfFlat.Name = "textBoxNumOfFlat";
            this.textBoxNumOfFlat.Size = new System.Drawing.Size(83, 30);
            this.textBoxNumOfFlat.TabIndex = 27;
            // 
            // textBoxFootage
            // 
            this.textBoxFootage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFootage.Location = new System.Drawing.Point(510, 104);
            this.textBoxFootage.Name = "textBoxFootage";
            this.textBoxFootage.Size = new System.Drawing.Size(80, 30);
            this.textBoxFootage.TabIndex = 28;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFloor.Location = new System.Drawing.Point(510, 158);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(80, 30);
            this.textBoxFloor.TabIndex = 31;
            // 
            // checkBoxKitchen
            // 
            this.checkBoxKitchen.AutoSize = true;
            this.checkBoxKitchen.BackColor = System.Drawing.Color.LightCyan;
            this.checkBoxKitchen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKitchen.Location = new System.Drawing.Point(512, 268);
            this.checkBoxKitchen.Name = "checkBoxKitchen";
            this.checkBoxKitchen.Size = new System.Drawing.Size(80, 26);
            this.checkBoxKitchen.TabIndex = 32;
            this.checkBoxKitchen.Text = "кухня";
            this.checkBoxKitchen.UseVisualStyleBackColor = false;
            // 
            // checkBoxBathroom
            // 
            this.checkBoxBathroom.AutoSize = true;
            this.checkBoxBathroom.BackColor = System.Drawing.Color.LightCyan;
            this.checkBoxBathroom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBathroom.Location = new System.Drawing.Point(512, 304);
            this.checkBoxBathroom.Name = "checkBoxBathroom";
            this.checkBoxBathroom.Size = new System.Drawing.Size(90, 26);
            this.checkBoxBathroom.TabIndex = 33;
            this.checkBoxBathroom.Text = "ванная";
            this.checkBoxBathroom.UseVisualStyleBackColor = false;
            // 
            // checkBoxWC
            // 
            this.checkBoxWC.AutoSize = true;
            this.checkBoxWC.BackColor = System.Drawing.Color.LightCyan;
            this.checkBoxWC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWC.Location = new System.Drawing.Point(512, 340);
            this.checkBoxWC.Name = "checkBoxWC";
            this.checkBoxWC.Size = new System.Drawing.Size(87, 26);
            this.checkBoxWC.TabIndex = 34;
            this.checkBoxWC.Text = "туалет";
            this.checkBoxWC.UseVisualStyleBackColor = false;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.BackColor = System.Drawing.Color.LightCyan;
            this.checkBoxBalcony.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBalcony.Location = new System.Drawing.Point(512, 376);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(91, 26);
            this.checkBoxBalcony.TabIndex = 35;
            this.checkBoxBalcony.Text = "балкон";
            this.checkBoxBalcony.UseVisualStyleBackColor = false;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSquare.Location = new System.Drawing.Point(988, 104);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(100, 30);
            this.textBoxSquare.TabIndex = 36;
            // 
            // textBoxNumOfWindows
            // 
            this.textBoxNumOfWindows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumOfWindows.Location = new System.Drawing.Point(988, 160);
            this.textBoxNumOfWindows.Name = "textBoxNumOfWindows";
            this.textBoxNumOfWindows.Size = new System.Drawing.Size(100, 30);
            this.textBoxNumOfWindows.TabIndex = 37;
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxYear.Location = new System.Drawing.Point(607, 425);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(148, 30);
            this.maskedTextBoxYear.TabIndex = 39;
            this.maskedTextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxYear.ValidatingType = typeof(int);
            // 
            // comboBoxFlat
            // 
            this.comboBoxFlat.DataSource = this.flatInfoBindingSource2;
            this.comboBoxFlat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFlat.FormattingEnabled = true;
            this.comboBoxFlat.Location = new System.Drawing.Point(1005, 53);
            this.comboBoxFlat.Name = "comboBoxFlat";
            this.comboBoxFlat.Size = new System.Drawing.Size(50, 30);
            this.comboBoxFlat.TabIndex = 40;
            // 
            // flatInfoBindingSource2
            // 
            this.flatInfoBindingSource2.DataSource = typeof(VKLab2.FlatInfo);
            // 
            // comboBoxSide
            // 
            this.comboBoxSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSide.FormattingEnabled = true;
            this.comboBoxSide.Items.AddRange(new object[] {
            "юг",
            "юго-запад"});
            this.comboBoxSide.Location = new System.Drawing.Point(988, 212);
            this.comboBoxSide.Name = "comboBoxSide";
            this.comboBoxSide.Size = new System.Drawing.Size(100, 30);
            this.comboBoxSide.TabIndex = 41;
            // 
            // trackBarNumOfRooms
            // 
            this.trackBarNumOfRooms.BackColor = System.Drawing.Color.LightCyan;
            this.trackBarNumOfRooms.Location = new System.Drawing.Point(607, 210);
            this.trackBarNumOfRooms.Maximum = 6;
            this.trackBarNumOfRooms.Minimum = 1;
            this.trackBarNumOfRooms.Name = "trackBarNumOfRooms";
            this.trackBarNumOfRooms.Size = new System.Drawing.Size(148, 56);
            this.trackBarNumOfRooms.TabIndex = 42;
            this.trackBarNumOfRooms.Value = 1;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(617, 243);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(15, 17);
            this.labelOne.TabIndex = 43;
            this.labelOne.Text = "1";
            // 
            // labelSix
            // 
            this.labelSix.AutoSize = true;
            this.labelSix.Location = new System.Drawing.Point(731, 243);
            this.labelSix.Name = "labelSix";
            this.labelSix.Size = new System.Drawing.Size(15, 17);
            this.labelSix.TabIndex = 44;
            this.labelSix.Text = "6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 440);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(372, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 440);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(792, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 227);
            this.panel3.TabIndex = 47;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 22);
            this.toolStripLabel1.Text = "Сохранить данные";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(182, 22);
            this.toolStripLabel2.Text = "Чтение данных из файла";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.MintCream;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1156, 28);
            this.statusStrip.TabIndex = 49;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.MintCream;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(127, 22);
            this.toolStripStatusLabel.Text = "Дата и время:";
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // buttonConfirmFlat
            // 
            this.buttonConfirmFlat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmFlat.Location = new System.Drawing.Point(425, 492);
            this.buttonConfirmFlat.Name = "buttonConfirmFlat";
            this.buttonConfirmFlat.Size = new System.Drawing.Size(294, 37);
            this.buttonConfirmFlat.TabIndex = 50;
            this.buttonConfirmFlat.Text = "Принять данные";
            this.buttonConfirmFlat.UseVisualStyleBackColor = true;
            this.buttonConfirmFlat.Click += new System.EventHandler(this.buttonConfirmFlat_Click);
            // 
            // flatInfoBindingSource1
            // 
            this.flatInfoBindingSource1.DataSource = typeof(VKLab2.FlatInfo);
            // 
            // flatInfoBindingSource
            // 
            this.flatInfoBindingSource.DataSource = typeof(VKLab2.FlatInfo);
            // 
            // Flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1156, 567);
            this.Controls.Add(this.buttonConfirmFlat);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelSix);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.trackBarNumOfRooms);
            this.Controls.Add(this.comboBoxSide);
            this.Controls.Add(this.comboBoxFlat);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.textBoxNumOfWindows);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxWC);
            this.Controls.Add(this.checkBoxBathroom);
            this.Controls.Add(this.checkBoxKitchen);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxFootage);
            this.Controls.Add(this.textBoxNumOfFlat);
            this.Controls.Add(this.textBoxHousing);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxCounty);
            this.Controls.Add(this.buttonConfirmAddress);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.labelNumberOfWindows);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelYearOfConstruction);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.labelNumberOfRooms);
            this.Controls.Add(this.labelFootage);
            this.Controls.Add(this.lableFlat);
            this.Controls.Add(this.labelNumberOfFlat);
            this.Controls.Add(this.labelHousing);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.lableAddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчет стоимости квартиры";
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfRooms)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Label labelHousing;
        private System.Windows.Forms.Label labelNumberOfFlat;
        private System.Windows.Forms.Label lableFlat;
        private System.Windows.Forms.Label labelFootage;
        private System.Windows.Forms.Label labelNumberOfRooms;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelYearOfConstruction;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelNumberOfWindows;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.Button buttonConfirmAddress;
        private System.Windows.Forms.TextBox textBoxCounty;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxHousing;
        private System.Windows.Forms.TextBox textBoxNumOfFlat;
        private System.Windows.Forms.TextBox textBoxFootage;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.CheckBox checkBoxKitchen;
        private System.Windows.Forms.CheckBox checkBoxBathroom;
        private System.Windows.Forms.CheckBox checkBoxWC;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxNumOfWindows;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.ComboBox comboBoxFlat;
        private System.Windows.Forms.ComboBox comboBoxSide;
        private System.Windows.Forms.TrackBar trackBarNumOfRooms;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelSix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.BindingSource flatInfoBindingSource;
        private System.Windows.Forms.Button buttonConfirmFlat;
        private System.Windows.Forms.BindingSource flatInfoBindingSource1;
        private System.Windows.Forms.BindingSource flatInfoBindingSource2;
    }
}

