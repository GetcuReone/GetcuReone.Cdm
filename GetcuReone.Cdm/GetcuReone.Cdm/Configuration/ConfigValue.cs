using System;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration
{
    /// <summary>
    /// Class for serializing config values.
    /// </summary>
    [Serializable]
    public sealed class ConfigValue
    {
        /// <summary>
        /// Key.
        /// </summary>
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"key <{Key}> value <{Value}>";
        }
    }
}
