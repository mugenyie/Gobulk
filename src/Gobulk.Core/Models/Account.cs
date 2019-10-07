using Gobulk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Account
    {
        public Account()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        [Key]
        public string AccountId { get; set; }

        [Required]
        public AccountType Type { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        [Required]
        [ForeignKey("Country")]
        public string CountryCode { get; set; }
        public Country Country { get; set; }

        [Required]
        public AccountStatus Status { get; set; }

        [StringLength(512)]
        public string ApiKey { get; set; }

        [StringLength(512)]
        public string ApiPasswordHash { get; set; }

        [Required]
        [StringLength(512)]
        public string IpnUri { get; set; }

        public string AlertEmailAddress { get; set; }

        public string AlertPhoneNumber { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        [Required]
        [ForeignKey("SubscriptionId")]
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }

        public AccountSubscription AccountSubscription { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public DateTime ApiPasswordExpiresOn { get; set; }

        public bool IsDeleted { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
