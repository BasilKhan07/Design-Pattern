using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XmlToJsonAdapter<T> : IJsonParser<T>
    {
        public T Parse(string data)
        {
            IXmlParser<T> xmlParser = new XmlParser<T>();
            return xmlParser.Parse(data);
        }

        public string ConvertToJson(T obj)
        {
            IJsonParser<T> jsonParser = new JsonParser<T>();
            return jsonParser.ConvertToJson(obj);
        }

    }
}
