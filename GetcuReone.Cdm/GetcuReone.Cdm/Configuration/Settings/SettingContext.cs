using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting context.
    /// </summary>
    [Serializable]
    public sealed class SettingContext
    {
        /// <summary>
        /// Setting context name.
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Setting context description.
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Setting namespaces.
        /// </summary>
        [XmlElement(ElementName = "namespace")]
        public List<SettingNamespace> Namespaces { get; set; }
    }
}
