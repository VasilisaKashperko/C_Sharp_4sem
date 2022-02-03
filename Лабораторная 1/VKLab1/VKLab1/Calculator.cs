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

        #region [Methods for buttons]
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

        private void buttonCut_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxForTheFirst.Text.Replace(textBoxForTheSecond.Text, "");
        }

        private void buttonLength_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = $"Длина первой строки: {textBoxForTheFirst.Text.Length}. Длина второй строки: {textBoxForTheSecond.Text.Length}."; 
        }

        private void buttonDoubleVowels_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            char[] vowels = {'а', 'и', 'о', 'у', 'ы', 'е', 'э', 'я', 'ю', 'А', 'И', 'О', 'У', 'Ы', 'Е', 'Э', 'Я', 'Ю'};
            char[] stringFirst = textBoxForTheFirst.Text.ToCharArray();
            char[] stringSecond = textBoxForTheSecond.Text.ToCharArray();
            var res = new List<char>();

            if (textBoxForTheFirst.Text != "Введите строку" && textBoxForTheSecond.Text == "Введите строку")
            {

                foreach (char vow in stringFirst)
                {
                    if (vowels.Contains(vow))
                    {
                        res.Add(vow);
                        res.Add(vow);
                    }
                    else
                    {
                        res.Add(vow);
                    }
                }

                foreach (var result in res)
                {
                    textBoxResult.Text += result;
                }
            }

            if (textBoxForTheSecond.Text != "Введите строку" && textBoxForTheFirst.Text == "Введите строку")
            {
                foreach (char vow in stringSecond)
                {
                    if (vowels.Contains(vow))
                    {
                        res.Add(vow);
                        res.Add(vow);
                    }
                    else
                    {
                        res.Add(vow);
                    }
                }

                foreach (var result in res)
                {
                    textBoxResult.Text += result;
                }
            }

            if (textBoxForTheSecond.Text != "Введите строку" && textBoxForTheFirst.Text != "Введите строку")
            {
                textBoxResult.Text = "Удалите, пожалуйста, любую введенную строку";
            }

            if (textBoxForTheSecond.Text == "Введите строку" && textBoxForTheFirst.Text == "Введите строку")
            {
                textBoxResult.Text = "Введите, пожалуйста, что-то в качестве строки";
            }
        }

        #endregion

        #region [Styles for buttons]
        private void buttonConcat_MouseEnter(object sender, EventArgs e)
        {
            buttonConcat.BackColor = Color.FromArgb(95, 196, 12);
            buttonConcat.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonConcat_MouseLeave(object sender, EventArgs e)
        {
            buttonConcat.BackColor = Color.FromArgb(63, 63, 63);
            buttonConcat.ForeColor = Color.FromArgb(221, 245, 250);
        }

        private void buttonReplacement_MouseEnter(object sender, EventArgs e)
        {
            buttonReplacement.BackColor = Color.FromArgb(95, 196, 12);
            buttonReplacement.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonReplacement_MouseLeave(object sender, EventArgs e)
        {
            buttonReplacement.BackColor = Color.FromArgb(63, 63, 63);
            buttonReplacement.ForeColor = Color.FromArgb(221, 245, 250);
        }

        private void buttonGetSymbol_MouseEnter(object sender, EventArgs e)
        {
            buttonGetSymbol.BackColor = Color.FromArgb(95, 196, 12);
            buttonGetSymbol.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonGetSymbol_MouseLeave(object sender, EventArgs e)
        {
            buttonGetSymbol.BackColor = Color.FromArgb(63, 63, 63);
            buttonGetSymbol.ForeColor = Color.FromArgb(221, 245, 250);
        }

        private void buttonCut_MouseEnter(object sender, EventArgs e)
        {
            buttonCut.BackColor = Color.FromArgb(95, 196, 12);
            buttonCut.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonCut_MouseLeave(object sender, EventArgs e)
        {
            buttonCut.BackColor = Color.FromArgb(63, 63, 63);
            buttonCut.ForeColor = Color.FromArgb(221, 245, 250);
        }

        private void buttonLength_MouseEnter(object sender, EventArgs e)
        {
            buttonLength.BackColor = Color.FromArgb(95, 196, 12);
            buttonLength.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonLength_MouseLeave(object sender, EventArgs e)
        {
            buttonLength.BackColor = Color.FromArgb(63, 63, 63);
            buttonLength.ForeColor = Color.FromArgb(221, 245, 250);
        }

        private void buttonDoubleVowels_MouseEnter(object sender, EventArgs e)
        {
            buttonDoubleVowels.BackColor = Color.FromArgb(95, 196, 12);
            buttonDoubleVowels.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void buttonDoubleVowels_MouseLeave(object sender, EventArgs e)
        {
            buttonDoubleVowels.BackColor = Color.FromArgb(63, 63, 63);
            buttonDoubleVowels.ForeColor = Color.FromArgb(221, 245, 250);
        }

        #endregion
    }
}