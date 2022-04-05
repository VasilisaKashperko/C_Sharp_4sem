using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace VKLab2
{
    public interface IAudioPlayer
    {
        void Load(string file);
        void Play();

    }

    public class SoundPlayerAdapter : IAudioPlayer
    {
        // адаптируемый объект (класса System.Media.SoundPlayer)
        private readonly SoundPlayer _player = new SoundPlayer();
        public void Load(string file)
        {
            _player.SoundLocation = file;
            _player.Load();
        }
        public void Play()
        {
            _player.Play();
        }
    }
}
