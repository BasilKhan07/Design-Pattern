
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Taget -> interface that client wants
    internal interface IJsonParser<T>
    {
        T Parse(string data);
        string ConvertToJson(T obj);

    }
}
