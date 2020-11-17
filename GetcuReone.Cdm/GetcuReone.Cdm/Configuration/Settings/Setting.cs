using System;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting.
    /// </summary>
    [Serializable]
    public sealed class Setting
    {
        /// <summary>
        /// Type code.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Default value.
        /// </summary>
        [XmlElement(ElementName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Setting code.
        /// </summary>
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Setting full code.
        /// </summary>
        [XmlIgnore]
        public string FullCode { get; set; }

        /// <summary>
        /// Setting name.
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }
}
