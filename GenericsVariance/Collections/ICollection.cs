using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsVariance.Collections
{
    public interface ICollection<T>
    {
        int Set(T obj);
        T Get(int index);
        int Count { get; }
    }
}
