using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    public enum CommitStatus
    {
        NOT_SET = 0,

        /// <summary>
        /// Started commit
        /// </summary>
        PROCESSING = 1,

        /// <summary>
        /// Commit status unknown
        /// </summary>
        INDETERMINATE = 2,

        /// <summary>
        /// Commit failed
        /// </summary>
        REVERSED = 3,

        /// <summary>
        /// Transaction committed
        /// </summary>
        COMMITTED = 4,
    }
}
