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

        public static bool WriteXml(string filePath, T objectToSerialize)
        {
            if(!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.Create(filePath).Close();

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlWriter writer = new XmlTextWriter(filePath, UTF8Encoding.UTF8);

                serializer.Serialize(writer, objectToSerialize);
                writer.Close();

                return true;
            }
            else
            {
                // Si le fichier existe déjà, on ne fait aucun traitement
                return false;
            }
        }
    }
}
