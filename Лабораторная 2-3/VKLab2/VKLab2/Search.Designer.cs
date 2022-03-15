namespace VKLab2
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirmSearch = new System.Windows.Forms.Button();
            this.labelNumberOfRooms = new System.Windows.Forms.Label();
            this.labelSix = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.trackBarNumOfRooms = new System.Windows.Forms.TrackBar();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.labelYearOfConstruction = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.buttonSearchSave = new System.Windows.Forms.Button();
            this.buttonSearchClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmSearch
            // 
            this.buttonConfirmSearch.BackColor = System.Drawing.Color.LightCyan;
            this.buttonConfirmSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonConfirmSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmSearch.Location = new System.Drawing.Point(60, 264);
            this.buttonConfirmSearch.Name = "buttonConfirmSearch";
            this.buttonConfirmSearch.Size = new System.Drawing.Size(294, 37);
            this.buttonConfirmSearch.TabIndex = 51;
            this.buttonConfirmSearch.Text = "Принять";
            this.buttonConfirmSearch.UseVisualStyleBackColor = false;
            this.buttonConfirmSearch.Click += new System.EventHandler(this.buttonConfirmSearch_Click);
            // 
            // labelNumberOfRooms
            // 
            this.labelNumberOfRooms.AutoSize = true;
            this.labelNumberOfRooms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelNumberOfRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfRooms.Location = new System.Drawing.Point(29, 52);
            this.labelNumberOfRooms.Name = "labelNumberOfRooms";
            this.labelNumberOfRooms.Size = new System.Drawing.Size(180, 22);
            this.labelNumberOfRooms.TabIndex = 52;
            this.labelNumberOfRooms.Text = "Количество комнат:";
            // 
            // labelSix
            // 
            this.labelSix.AutoSize = true;
            this.labelSix.BackColor = System.Drawing.Color.LightCyan;
            this.labelSix.Location = new System.Drawing.Point(351, 68);
            this.labelSix.Name = "labelSix";
            this.labelSix.Size = new System.Drawing.Size(16, 17);
            this.labelSix.TabIndex = 55;
            this.labelSix.Text = "6";
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.BackColor = System.Drawing.Color.LightCyan;
            this.labelOne.Location = new System.Drawing.Point(233, 68);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(16, 17);
            this.labelOne.TabIndex = 54;
            this.labelOne.Text = "0";
            // 
            // trackBarNumOfRooms
            // 
            this.trackBarNumOfRooms.BackColor = System.Drawing.Color.LightCyan;
            this.trackBarNumOfRooms.Location = new System.Drawing.Point(226, 35);
            this.trackBarNumOfRooms.Maximum = 6;
            this.trackBarNumOfRooms.Name = "trackBarNumOfRooms";
            this.trackBarNumOfRooms.Size = new System.Drawing.Size(148, 56);
            this.trackBarNumOfRooms.TabIndex = 53;
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxYear.Location = new System.Drawing.Point(226, 105);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(148, 30);
            this.maskedTextBoxYear.TabIndex = 57;
            this.maskedTextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxYear.ValidatingType = typeof(int);
            // 
            // labelYearOfConstruction
            // 
            this.labelYearOfConstruction.AutoSize = true;
            this.labelYearOfConstruction.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelYearOfConstruction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearOfConstruction.Location = new System.Drawing.Point(29, 105);
            this.labelYearOfConstruction.Name = "labelYearOfConstruction";
            this.labelYearOfConstruction.Size = new System.Drawing.Size(146, 22);
            this.labelYearOfConstruction.TabIndex = 56;
            this.labelYearOfConstruction.Text = "Год постройки: ";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistrict.Location = new System.Drawing.Point(113, 206);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(164, 30);
            this.textBoxDistrict.TabIndex = 61;
            this.textBoxDistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDistrict_KeyPress);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(113, 152);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(164, 30);
            this.textBoxCity.TabIndex = 60;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelDistrict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistrict.Location = new System.Drawing.Point(29, 211);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(68, 22);
            this.labelDistrict.TabIndex = 59;
            this.labelDistrict.Text = "Район:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(29, 158);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(65, 22);
            this.labelCity.TabIndex = 58;
            this.labelCity.Text = "Город:";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 22;
            this.listBoxSearch.Location = new System.Drawing.Point(415, 35);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(553, 202);
            this.listBoxSearch.TabIndex = 62;
            // 
            // buttonSearchSave
            // 
            this.buttonSearchSave.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearchSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSearchSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearchSave.Location = new System.Drawing.Point(415, 264);
            this.buttonSearchSave.Name = "buttonSearchSave";
            this.buttonSearchSave.Size = new System.Drawing.Size(294, 37);
            this.buttonSearchSave.TabIndex = 63;
            this.buttonSearchSave.Text = "Сохранить результаты";
            this.buttonSearchSave.UseVisualStyleBackColor = false;
            this.buttonSearchSave.Click += new System.EventHandler(this.buttonSearchSave_Click);
            // 
            // buttonSearchClear
            // 
            this.buttonSearchClear.BackColor = System.Drawing.Color.Pink;
            this.buttonSearchClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearchClear.Location = new System.Drawing.Point(749, 264);
            this.buttonSearchClear.Name = "buttonSearchClear";
            this.buttonSearchClear.Size = new System.Drawing.Size(219, 37);
            this.buttonSearchClear.TabIndex = 64;
            this.buttonSearchClear.Text = "Очистить";
            this.buttonSearchClear.UseVisualStyleBackColor = false;
            this.buttonSearchClear.Click += new System.EventHandler(this.buttonSearchClear_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1004, 326);
            this.Controls.Add(this.buttonSearchClear);
            this.Controls.Add(this.buttonSearchSave);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.labelYearOfConstruction);
            this.Controls.Add(this.labelNumberOfRooms);
            this.Controls.Add(this.labelSix);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.trackBarNumOfRooms);
            this.Controls.Add(this.buttonConfirmSearch);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmSearch;
        private System.Windows.Forms.Label labelNumberOfRooms;
        private System.Windows.Forms.Label labelSix;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.TrackBar trackBarNumOfRooms;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.Label labelYearOfConstruction;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button buttonSearchSave;
        private System.Windows.Forms.Button buttonSearchClear;
    }
}