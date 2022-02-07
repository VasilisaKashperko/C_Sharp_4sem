using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKLab1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        #region [Hints]
        // hint для textbox'ов

        private void textBoxHeight_Enter(object sender, EventArgs e)
        {
            if (textBoxHeight.Text == "Рост")
            {
                textBoxHeight.Text = "";
            }
        }

        private void textBoxHeight_Leave(object sender, EventArgs e)
        {
            if (textBoxHeight.Text == "")
            {
                textBoxHeight.Text = "Рост";
            }
        }

        private void textBoxBust_Enter(object sender, EventArgs e)
        {
            if (textBoxBust.Text == "ОГ")
            {
                textBoxBust.Text = "";
            }
        }

        private void textBoxBust_Leave(object sender, EventArgs e)
        {
            if (textBoxBust.Text == "")
            {
                textBoxBust.Text = "ОГ";
            }
        }

        private void textBoxWaist_Enter(object sender, EventArgs e)
        {
            if (textBoxWaist.Text == "ОТ")
            {
                textBoxWaist.Text = "";
            }
        }

        private void textBoxWaist_Leave(object sender, EventArgs e)
        {
            if (textBoxWaist.Text == "")
            {
                textBoxWaist.Text = "ОТ";
            }
        }

        private void textBoxHip_Enter(object sender, EventArgs e)
        {
            if (textBoxHip.Text == "ОБ")
            {
                textBoxHip.Text = "";
            }
        }

        private void textBoxHip_Leave(object sender, EventArgs e)
        {
            if (textBoxHip.Text == "")
            {
                textBoxHip.Text = "ОБ";
            }
        }

        private void textBoxLength_Enter(object sender, EventArgs e)
        {
            if (textBoxLength.Text == "ДС")
            {
                textBoxLength.Text = "";
            }
        }

        private void textBoxLength_Leave(object sender, EventArgs e)
        {
            if (textBoxLength.Text == "")
            {
                textBoxLength.Text = "ДС";
            }
        }


        #endregion

        #region [Styles for buttons]

        private void buttonCalculate_MouseEnter(object sender, EventArgs e)
        {
            buttonCalculate.BackColor = Color.FromArgb(236, 194, 238);
            buttonCalculate.ForeColor = Color.FromArgb(51, 0, 87);
        }

        private void buttonCalculate_MouseLeave(object sender, EventArgs e)
        {
            buttonCalculate.BackColor = Color.FromArgb(174, 162, 231);
            buttonCalculate.ForeColor = Color.FromArgb(51, 0, 87);
        }

        #endregion

        #region [Method for button]

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            #region [Clothing size]

            int height = Convert.ToInt32(textBoxHeight.Text);
            int bust = Convert.ToInt32(textBoxBust.Text);
            int waist = Convert.ToInt32(textBoxWaist.Text);
            int hip = Convert.ToInt32(textBoxHip.Text);

            // it's for XS-girls
            if (height <= 168 || bust <= 82 || waist <= 64 || hip <= 88)
            {
                ResultRusClothes.Text = $"42";
                ResultEurClothes.Text = $"XS";
                ResultAmClothes.Text = $"6";
                ResultBrClothes.Text = $"8";
            }

            // it's for S-girls
            if (height > 168 && height <= 170 || bust > 82 && bust <= 86 || waist > 64 && waist <= 66 || hip > 88 && hip <= 92)
            {
                ResultRusClothes.Text = $"44";
                ResultEurClothes.Text = $"S";
                ResultAmClothes.Text = $"8";
                ResultBrClothes.Text = $"10";
            }

            // it's for M-girls
            if (height > 170 && height <= 172 || bust > 86 && bust <= 90 || waist > 66 && waist <= 70 || hip > 92 && hip <= 96)
            {
                ResultRusClothes.Text = $"46";
                ResultEurClothes.Text = $"M";
                ResultAmClothes.Text = $"10";
                ResultBrClothes.Text = $"12";
            }

            // it's for L-girls
            if (height > 172 && height <= 174 || bust > 90 && bust <= 94 || waist > 70 && waist <= 74 || hip > 96 && hip <= 100)
            {
                ResultRusClothes.Text = $"46";
                ResultEurClothes.Text = $"L";
                ResultAmClothes.Text = $"12";
                ResultBrClothes.Text = $"14";
            }

            // it's for XL-girls
            if (height > 174 && height <= 176 || bust > 94 && bust <= 98 || waist > 74 && waist <= 78 || hip > 100 && hip <= 104)
            {
                ResultRusClothes.Text = $"48";
                ResultEurClothes.Text = $"XL";
                ResultAmClothes.Text = $"14";
                ResultBrClothes.Text = $"16";
            }

            #endregion

            #region [Shoe size]

            int length = Convert.ToInt32(textBoxLength.Text);

            // it's for 35
            if (length <= 22)
            {
                ResultRusShoes.Text = $"35";
                ResultEurShoes.Text = $"35";
                ResultAmShoes.Text = $"5";
                ResultBrShoes.Text = $"3";
            }

            // it's for 36
            if (length > 22 && length <= 23)
            {
                ResultRusShoes.Text = $"36";
                ResultEurShoes.Text = $"36";
                ResultAmShoes.Text = $"6";
                ResultBrShoes.Text = $"4";
            }

            // it's for 37
            if (length > 23 && length <= 23.8)
            {
                ResultRusShoes.Text = $"37";
                ResultEurShoes.Text = $"37";
                ResultAmShoes.Text = $"7";
                ResultBrShoes.Text = $"5";
            }

            // it's for 38
            if (length > 23.8 && length <= 24.8)
            {
                ResultRusShoes.Text = $"38";
                ResultEurShoes.Text = $"38";
                ResultAmShoes.Text = $"8";
                ResultBrShoes.Text = $"6";
            }

            // it's for 39
            if (length > 24.8 && length <= 25.5)
            {
                ResultRusShoes.Text = $"39";
                ResultEurShoes.Text = $"39";
                ResultAmShoes.Text = $"9";
                ResultBrShoes.Text = $"7";
            }

            // it's for 40
            if (length > 25.5 && length <= 26)
            {
                ResultRusShoes.Text = $"40";
                ResultEurShoes.Text = $"40";
                ResultAmShoes.Text = $"10";
                ResultBrShoes.Text = $"8";
            }

            if (length == 0)
            {
                ResultRusShoes.Text = $"-";
                ResultEurShoes.Text = $"-";
                ResultAmShoes.Text = $"-";
                ResultBrShoes.Text = $"-";
            }

            #endregion
        }

        #endregion
    }
}
