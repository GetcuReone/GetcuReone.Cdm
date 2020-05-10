using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Format value.
    /// </summary>
    public enum FormatValue
    {

        /// <summary>
        /// String.
        /// </summary>
        [XmlEnum]
        Text,

        /// <summary>
        /// Enumerate.
        /// </summary>
        [XmlEnum]
        Enumerate,
    }
}
