using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Format value.
    /// </summary>
    public enum FormatValue
    {
        /// <summary>
        /// Number.
        /// </summary>
        [XmlEnum]
        Number,

        /// <summary>
        /// String.
        /// </summary>
        [XmlEnum]
        String,

        /// <summary>
        /// Enumerate.
        /// </summary>
        [XmlEnum]
        Enumerate,

        /// <summary>
        /// Enumerate case sensitive.
        /// </summary>
        [XmlEnum]
        EnumerateMatchCase
    }
}
