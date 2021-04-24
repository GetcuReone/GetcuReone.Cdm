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
        /// Sections.
        /// </summary>
        [XmlElement(ElementName = "section")]
        public List<SectionConfig> Sections { get; set; }
    }
}
