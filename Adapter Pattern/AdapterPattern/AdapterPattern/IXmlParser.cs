using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface IXmlParser<T>
    {
        // Adaptee -> interface incompatible with target interface
        T Parse(string data);

        string ConvertToXml(T obj);
    }
}
