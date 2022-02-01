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
            char[] vowels = {'а', 'и', 'о', 'у', 'ы', 'е', 'э', 'я', 'ю', 'А', 'И', 'О', 'У', 'Ы', 'Е', 'Э', 'Я', 'Ю'};
            char[] stringFirst = textBoxForTheFirst.Text.ToCharArray();
            char[] stringSecond = textBoxForTheSecond.Text.ToCharArray();

            if (textBoxForTheFirst.Text != "Введите строку" && textBoxForTheSecond.Text == "Введите строку")
            {
                for (int n = 0; n == stringFirst.Length - 1; n++)
                {
                    for (int i = 0; i == vowels.Length - 1; i++)
                    {
                        if (textBoxForTheFirst.Text.Contains(vowels[i]))
                        {
                            int foundVowel = textBoxForTheFirst.Text.IndexOf(vowels[i]);
                            textBoxResult.Text = textBoxForTheFirst.Text.Insert(foundVowel, vowels[i].ToString());
                        }
                        else
                        {
                            textBoxResult.Text = "Гласных в строке нет!";
                        }
                    }
                }
            }

            if (textBoxForTheSecond.Text != "Введите строку" && textBoxForTheFirst.Text == "Введите строку")
            {

            }

            if (textBoxForTheSecond.Text != "Введите строку" && textBoxForTheFirst.Text != "Введите строку")
            {
                textBoxResult.Text = "Удалите, пожалуйста, любую введенную строку";
            }
        }

        #endregion
    }
}