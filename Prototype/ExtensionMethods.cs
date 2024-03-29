﻿using System.Xml.Serialization;

namespace Prototype
{
    internal static class ExtensionMethods
    {
        public static T DeepCopyXml<T>(this T self)
        {
            using var ms = new MemoryStream();
            XmlSerializer s = new XmlSerializer(typeof(T));
            s.Serialize(ms, self);
            ms.Position = 0;
            return (T)s.Deserialize(ms);   
        }
    }
}
