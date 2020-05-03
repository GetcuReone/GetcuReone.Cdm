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
        [XmlAttribute]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Default value.
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Setting code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        /// <summary>
        /// Setting name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
    }
}
