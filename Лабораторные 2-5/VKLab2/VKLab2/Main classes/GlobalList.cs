using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public static class GlobalList
    {
        public static List<FlatInfo> list = new List<FlatInfo>();

        public static List<IFlat> flats = new List<IFlat>();

        public static List<IRoom> rooms = new List<IRoom>();

        public static int singleton = 1;
    }
}
