using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace VKLab2
{
    [Serializable]
    public abstract class FlatPrototype<T>
    {
        // поверхностное (неполное) копирование - копирование значимых типов
        public virtual T Clone()
        {
            return (T)MemberwiseClone();
        }

        // глубокое копирование
        public virtual T DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var context = new StreamingContext(StreamingContextStates.Clone);
                var formatter = new BinaryFormatter { Context = context };
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }


}
