using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    public enum OrderStatus
    {
        NOT_SET = 0,

        /// <summary>
        /// Received transaction
        /// </summary>
        PROCESSING = 1,

        /// <summary>
        /// Unknown. This is included in balance 
        /// </summary>
        INDETERMINATE = 2,

        /// <summary>
        /// Transaction failed
        /// </summary>
        REVERSED = 3,

        /// <summary>
        /// Transaction committed
        /// </summary>
        COMMITTED = 4
    }
}
