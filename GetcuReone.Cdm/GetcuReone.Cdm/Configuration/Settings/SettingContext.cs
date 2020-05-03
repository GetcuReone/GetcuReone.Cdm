using System;
using System.Collections.Generic;

namespace GetcuReone.Cdm.Configuration.Settings
{
    /// <summary>
    /// Setting context.
    /// </summary>
    [Serializable]
    public sealed class SettingContext
    {
        /// <summary>
        /// Setting context name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Setting context description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Setting namespaces.
        /// </summary>
        public List<SettingNameSpace> NameSpaces { get; set; }
    }
}
