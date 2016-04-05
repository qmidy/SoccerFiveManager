using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CommonLibrary
{
    public static class XmlService<T>
    {
        public static T ReadXml(string filePath)
        {
            T result;

            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReader reader = new XmlTextReader(filePath);

                if(serializer.CanDeserialize(reader))
                {
                    result = (T)serializer.Deserialize(reader);
                }
                else
                {
                    result = default(T);
                }
            }
            else
            {
                result = default(T);
            }

            return result;
        }
    }
}
