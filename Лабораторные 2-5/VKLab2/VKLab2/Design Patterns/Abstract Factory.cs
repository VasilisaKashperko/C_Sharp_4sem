using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public interface IFlat
    {
        string FlatAddress { get; }
        int Footage { get; }
    }

    [Serializable]
    public class GomelFlat : IFlat
    {
        public string FlatAddress => "Беларусь, г. Гомель, Советский район";
        public int Footage => 130;
    }

    [Serializable]
    public class MinskFlat : IFlat
    {
        public string FlatAddress => "Беларусь, г. Минск, Ленинский район";
        public int Footage => 120;
    }

    public interface IRoom
    {
        int RoomFootage { get; }
    }

    [Serializable]
    public class GomelRoom : IRoom
    {
        public int RoomFootage => 30;
    }

    [Serializable]
    public class MinskRoom : IRoom
    {
        public int RoomFootage => 40;
    }

    public interface IAbstractFactory
    {
        IFlat CreateFlat();
        IRoom CreateRoom();
    }

    public class GomelAbstractFactory : IAbstractFactory
    {
        public IFlat CreateFlat() { return new GomelFlat(); }
        public IRoom CreateRoom() { return new GomelRoom(); }
    }

    public class MinskAbstractFactory : IAbstractFactory
    {
        public IFlat CreateFlat() { return new MinskFlat(); }
        public IRoom CreateRoom() { return new MinskRoom(); }
    }
}
