using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    [Flags]
    public enum TransactionPlan
    {
        NOT_SET = 0,

        /// <summary>
        /// Transaction limits are set per minute
        /// </summary>
        MINUTELY = 1,

        /// <summary>
        /// Transaction limits are set per hour
        /// </summary>
        HOURLY = 60,

        /// <summary>
        /// Transaction limits are set per day
        /// </summary>
        DAILY = 1440,

        /// <summary>
        /// Transaction limits are set per month.
        /// A month is 30 days
        /// </summary>
        MONTHLY = 43200,

        /// <summary>
        /// Transaction limits are set per year
        /// </summary>
        YEARLY = 518400,

        /// <summary>
        /// No Transaction limits
        /// </summary>
        UNLIMITED = 563102
    }
}
