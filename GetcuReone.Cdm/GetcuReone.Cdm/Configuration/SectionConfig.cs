using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration
{
    /// <summary>
    /// Section config
    /// </summary>
    [Serializable]
    public class SectionConfig
    {
        /// <summary>
        /// Setting name.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Logging configurations.
        /// </summary>
        [XmlElement(ElementName = "config")]
        public List<ConfigValue> Configs { get; set; }
    }
}
