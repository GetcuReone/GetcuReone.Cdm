using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration
{
    /// <summary>
    /// GetcuReone config.
    /// </summary>
    [Serializable]
    public sealed class GetcuReoneConfig
    {
        /// <summary>
        /// Settings configurations.
        /// </summary>
        [XmlElement(ElementName = "settingsConfig")]
        public List<ConfigValue> SettingsConfigs { get; set; }

        /// <summary>
        /// Logging configurations.
        /// </summary>
        [XmlElement(ElementName = "loggingConfig")]
        public List<ConfigValue> LoggingConfigs { get; set; }
    }
}
