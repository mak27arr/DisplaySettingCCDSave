using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsDisplayAPI;

namespace DisplaySettingCCDSave.Classes
{
    static class Serialization
    {
        public static string ObjectToString(object obj)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, obj);
                return Convert.ToBase64String(ms.ToArray());
            }
            //XmlSerializer formatter = new XmlSerializer(obj.GetType());
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    formatter.Serialize(ms, obj);
            //    return Convert.ToString(ms.ToArray());
            //}
        }

        public static object StringToObject(string obj_str, Type obj_type)
        {
            byte[] bytes = Convert.FromBase64String(obj_str);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                ms.Write(bytes, 0, bytes.Length);
                ms.Position = 0;
                return new BinaryFormatter().Deserialize(ms);
            }
            //XmlSerializer formatter = new XmlSerializer(obj_type);
            //using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(obj_str ?? "")))
            //{  
            //    return formatter.Deserialize(ms);
            //}
        }
    }
}
