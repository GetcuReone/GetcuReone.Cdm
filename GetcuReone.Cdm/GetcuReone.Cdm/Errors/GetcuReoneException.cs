using System;
using System.Collections.Generic;
using System.Linq;

namespace GetcuReone.Cdm.Errors
{
    /// <summary>
    /// Common exception for GR systems
    /// </summary>
    public class GetcuReoneException : Exception
    {
        /// <summary>
        /// Additional error information.
        /// </summary>
        public IReadOnlyCollection<ErrorDetail> ErrorDetails { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="errorDetails"></param>
        public GetcuReoneException(IReadOnlyCollection<ErrorDetail> errorDetails)
            : base(errorDetails == null || errorDetails.Count == 0 ? "Unknown error" : errorDetails.First().Reason)
        {
            ErrorDetails = errorDetails;
        }
    }
}
