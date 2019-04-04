using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace StockExam
{
    public class XmlManager
    {
        string path;
        public XmlManager(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                using (FileStream stream = File.Create(path)){   
                }
            }
            
        }

        public bool Save<T>(List<T> objectList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, objectList);
            }
            return true;
        }

        public List<T> Load<T>()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
            List<T> deserializedList = new List<T>();
            using (FileStream stream = File.OpenRead(path))
            {
                deserializedList = (List<T>)deserializer.Deserialize(stream);
            }
            return deserializedList;
        }
        
    }
}
