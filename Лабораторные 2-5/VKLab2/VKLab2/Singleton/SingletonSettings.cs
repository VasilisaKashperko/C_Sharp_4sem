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

        private SingletonSettings()
        {
            bgColor = Color.PowderBlue;
            fontColor = Color.Black;
            fontSize = 1;
            mainFormWidth = 0;
            mainFormHeight = 0;
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
