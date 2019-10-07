using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    /// <summary>
    /// Monitor User acitivity (Last 10 Activity Records for each user)
    /// </summary>
    public class AuditLog
    {
        public AuditLog()
        {
            CreatedOnUTCDateTime = DateTime.UtcNow;
        }

        [Key]
        public string AuditLogId { get; set; }

        [ForeignKey("AccountId")]
        public string AccountId { get; set; }
        public Account Account { get; set; }

        public string LoginMetaData { get; set; }

        [Required]
        public DateTime CreatedOnUTCDateTime { get; set; }
    }
}
