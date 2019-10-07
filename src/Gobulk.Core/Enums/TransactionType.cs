using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    public enum TransactionType
    {
        NOT_SET = 0,

        /// <summary>
        /// Positive amount
        /// </summary>
        CREDIT = 1,

        /// <summary>
        /// Negative amount
        /// </summary>
        DEBIT = 2
    }
}
