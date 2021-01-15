using System;
using System.IO;
using System.Xml.Serialization;
using ISerializer;

namespace SimpleSerializer
{
    public class SimpleXmlSerializer<T> : ISerializer<T>
    {
        private XmlSerializer serializer;
        public SimpleXmlSerializer(XmlSerializer serializer)
        {
            this.serializer = serializer;
        }

        public string Serialize(T target)
        {
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, target);
                return writer.ToString();
            }
        }


    }
}
