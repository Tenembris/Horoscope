using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Horoskop
{
    class DB
    {
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static List<T> DeserializeList<T>(FileStream fs)
        {
            var bf = new BinaryFormatter();
            List<T> list = new List<T>();
            while (fs.Position != fs.Length)
            {
                var deserialized = (T)bf.Deserialize(fs);
                list.Add(deserialized);
            }
            return list;
        }
    }
}
