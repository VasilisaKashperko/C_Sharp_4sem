using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKLab2
{
    public class FlatInfoDecorator : FlatInfo
    {
        protected FlatInfo flatInfo;

        private bool _furnished;

        public bool Furnished { get => _furnished; set { _furnished = value; } }

        public FlatInfoDecorator(FlatInfo flatInfo, bool furniture) : base()
        {
            this.flatInfo = flatInfo;
            this.Furnished = furniture;
        }
    }
}
