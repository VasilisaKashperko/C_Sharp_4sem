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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

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


    }
}
