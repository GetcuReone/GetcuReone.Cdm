using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting name space.
    /// </summary>
    [Serializable]
    public sealed class SettingNameSpace
    {
        /// <summary>
        /// Setting namespace code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        /// <summary>
        /// Setting namespace name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Settings.
        /// </summary>
        public List<Setting> Settings { get; set; }
    }
}
