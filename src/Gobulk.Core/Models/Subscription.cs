using Gobulk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public AccountSubscription AccountSubscription { get; set; }
        public string SubscriptionName { get; set; }
        [Required]
        [ForeignKey("Setting")]
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
    }
}
