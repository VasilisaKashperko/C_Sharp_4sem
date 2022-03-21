using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VKLab2
{
    public sealed class SingletonSettings
    {
        private static SingletonSettings _instance; // закрытое поле для хранения единственного и неповторимого экземпляра
        private static readonly object Locker = new object();

        public Color bgColor { get; set; }
        public Color fontColor { get; set; }
        public float fontSize { get; set; }
        public int mainFormWidth { get; set; }
        public int mainFormHeight { get; set; }
        public string fontName { get; set; }
        public int amount { get; set; }

        private SingletonSettings()
        {
            bgColor = Flat.ActiveForm.BackColor;
            fontColor = Flat.ActiveForm.ForeColor;
            fontName = Flat.ActiveForm.Font.Name;
            fontSize = float.Parse(Flat.ActiveForm.Font.Size.ToString());
            mainFormHeight = Int32.Parse(Flat.ActiveForm.Height.ToString());
            mainFormWidth = Int32.Parse(Flat.ActiveForm.Width.ToString());
            amount = 1;
        }

        public static SingletonSettings GetInstance() // Потокобезопасная реализация
        {
            if (_instance == null)
            {
                lock (Locker)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonSettings();
                    }
                }
            }

            return _instance;
        }
    }
}
