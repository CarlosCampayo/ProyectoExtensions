using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProyectoExtensions.Extensions
{
    public static class TempDataExtension
    {
        public static void SetObjectXML<T>(this ITempDataDictionary tempData,
                    String key, Object value)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringWriter writer = new StringWriter();
            xmlSerializer.Serialize(writer,value);
            tempData[key] = writer.ToString();
        }
        public static T GetObjectXML<T>(this ITempDataDictionary tempData,
            String key)
        {
            String data = tempData[key].ToString();
            if (data == null)
                return default(T);
            else
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                StringReader rdr = new StringReader(data);
                return (T)xmlSerializer.Deserialize(rdr);
            }
        }
    }
}
