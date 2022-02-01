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

        private void textBoxForTheFirst_Enter(object sender, EventArgs e)
        {
            if (textBoxForTheFirst.Text == "Введите строку")
            {
                textBoxForTheFirst.Text = "";
            }
        }

        private void textBoxForTheFirst_Leave(object sender, EventArgs e)
        {
            if (textBoxForTheFirst.Text == "")
            {
                textBoxForTheFirst.Text = "Введите строку";
            }
        }

        private void textBoxForTheSecond_Enter(object sender, EventArgs e)
        {
            if (textBoxForTheSecond.Text == "Введите строку")
            {
                textBoxForTheSecond.Text = "";
            }
        }

        private void textBoxForTheSecond_Leave(object sender, EventArgs e)
        {
            if (textBoxForTheSecond.Text == "")
            {
                textBoxForTheSecond.Text = "Введите строку";
            }
        }
    }
}
