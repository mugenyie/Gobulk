using System;
using System.Collections.Generic;
using System.Text;

namespace Gobulk.Core.Enums
{
    public enum AccountStatus
    {
        NOT_SET = 0,

        /// <summary>
        /// Valid account created
        /// </summary>
        NOT_VERIFIED = 1,

        /// <summary>
        /// Account verified
        /// </summary>
        VERIFIED = 2,

        /// <summary>
        /// Account deactivated
        /// </summary>
        DEACTIVATED = 3,

        /// <summary>
        /// Account suspended for a while
        /// </summary>
        SUSPENDED = 4,

        /// <summary>
        /// Account active
        /// </summary>
        ACTIVE = 5
    }
}
