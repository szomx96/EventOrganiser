using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Kolokwium
{
    public class LoadXML
    {
        public static Organiser LoadData(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Organiser));
            FileStream fs = new FileStream(path, FileMode.Open);
            Organiser result = (Organiser)serializer.Deserialize(fs);
            fs.Close();

            return result;

        }
       

    }
}
