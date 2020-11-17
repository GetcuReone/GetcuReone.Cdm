using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting name space.
    /// </summary>
    [Serializable]
    public sealed class SettingNamespace
    {
        /// <summary>
        /// Setting namespace code.
        /// </summary>
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Setting full code.
        /// </summary>
        [XmlIgnore]
        public string FullCode { get; set; }

        /// <summary>
        /// Setting namespace name.
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///  Sub namespaces.
        /// </summary>
        [XmlElement(ElementName = "namespace")]
        public List<SettingNamespace> Namespaces { get; set; }

        /// <summary>
        /// Settings.
        /// </summary>
        [XmlElement(ElementName = "setting")]
        public List<Setting> Settings { get; set; }
    }
}
