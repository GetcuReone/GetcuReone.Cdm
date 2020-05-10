using System.Collections.Generic;

namespace GetcuReone.Cdm.Communication
{
    /// <summary>
    /// Entity email.
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Message recipients.
        /// </summary>
        public List<string> To { get; set; }

        /// <summary>
        /// Message sender.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Subject message.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Message content.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Does the message contain a HTML code
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// Attachment paths.
        /// </summary>
        public List<string> Attachments { get; set; }
    }
}
