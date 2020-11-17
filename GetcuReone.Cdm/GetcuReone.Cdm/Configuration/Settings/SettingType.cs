using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting type.
    /// </summary>
    [Serializable]
    public sealed class SettingType
    {
        /// <summary>
        /// Format value.
        /// </summary>
        [XmlAttribute(AttributeName = "formatValue")]
        public FormatValue FormatValue { get; set; }

        /// <summary>
        /// Type code.
        /// </summary>
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Permissible values. Must be set if the format of the enumeration value.
        /// </summary>
        [XmlElement(ElementName = "permissibleValue")]
        public List<string> PermissibleValues { get; set; }

        /// <summary>
        /// Text pattern. Must be set if the format of the text value.
        /// </summary>
        [XmlElement(ElementName = "pattern")]
        public string TextPattern { get; set; }

        /// <summary>
        /// <see cref="int"/> setting type.
        /// </summary>

        public static readonly SettingType Int = new SettingType
        {
            Code = nameof(Int),
            FormatValue = FormatValue.Text,
            TextPattern = @"(^\d+$)|(^-\d+$)",
        };

        /// <summary>
        /// <see cref="bool"/> setting type.
        /// </summary>

        public static readonly SettingType Bool = new SettingType
        {
            Code = nameof(Bool),
            FormatValue = FormatValue.Enumerate,
            PermissibleValues = new List<string>(2)
            {
                "True",
                "False",
            }
        };

        /// <summary>
        /// <see cref="string"/> setting type.
        /// </summary>

        public static readonly SettingType String = new SettingType
        {
            Code = nameof(String),
            FormatValue = FormatValue.Text,
            TextPattern = ".*"
        };

        /// <summary>
        /// On or off mode setting type.
        /// </summary>
        public static readonly SettingType PowerMode = new SettingType
        {
            Code = nameof(PowerMode),
            FormatValue = FormatValue.Enumerate,
            PermissibleValues = new List<string>(2)
            {
                nameof(Enums.PowerMode.On),
                nameof(Enums.PowerMode.Off),
            },
        };
    }
}
