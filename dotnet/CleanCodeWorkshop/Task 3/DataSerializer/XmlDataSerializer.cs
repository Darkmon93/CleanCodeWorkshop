using CleanCodeWorkshop.Utils;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CleanCodeWorkshop.Task_3
{
    // TODO: it should implement an interface you create
    public class XmlDataSerializer
    {
        public string Serialize(List<Player> players)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter))
                {
                    serializer.Serialize(writer, players);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
