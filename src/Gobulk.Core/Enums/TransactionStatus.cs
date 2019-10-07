using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    public enum TransactionStatus
    {
        ENQUEUED = 0,

        /// <summary>
        /// Received transaction
        /// </summary>
        PROCESSING = 1,

        /// <summary>
        /// Transaction failed
        /// </summary>
        REVERSED = 2,

        /// <summary>
        /// Transaction committed
        /// </summary>
        COMMITTED = 3
    }
}
