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
        /// Format value
        /// </summary>
        [XmlAttribute]
        public FormatValue FormatValue { get; set; }

        /// <summary>
        /// Type code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        /// <summary>
        /// Permissible values.
        /// </summary>
        public List<string> PermissibleValues { get; set; }

        /// <summary>
        /// <see cref="int"/> setting type.
        /// </summary>

        public static readonly SettingType Int = new SettingType
        {
            Code = nameof(Int),
            FormatValue = FormatValue.Number,
        };

        /// <summary>
        /// <see cref="bool"/> setting type.
        /// </summary>

        public static readonly SettingType Bool = new SettingType
        {
            Code = nameof(Bool),
            FormatValue = FormatValue.Enumerate,
            PermissibleValues = new List<string>
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
            FormatValue = FormatValue.String,
        };
    }
}
