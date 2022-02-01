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

        #endregion

        private void buttonConcat_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Concat(textBoxForTheFirst.Text, textBoxForTheSecond.Text);
        }

        private void buttonReplacement_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxForTheFirst.Text.Replace("плохой", textBoxForTheSecond.Text);
        }

        private void buttonGetSymbol_Click(object sender, EventArgs e)
        {
            char[] c = textBoxForTheSecond.Text.ToCharArray();
            int result = textBoxForTheFirst.Text.IndexOf(c[0])+1;
            textBoxResult.Text = result.ToString();
        }

    }
}
