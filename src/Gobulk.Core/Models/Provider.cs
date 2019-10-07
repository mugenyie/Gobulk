using Gobulk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Provider
    {
        [Key]
        public string ProviderId { get; set; }

        public string RequestJsonSchema { get; set; }

        public string Name { get; set; }

        [Required]
        public decimal FlatFee { get; set; }

        [Required]
        public decimal PercentageFee { get; set; }

        public string ShortDescription { get; set; }

        [Required]
        public string LongDescription { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        [Required]
        [ForeignKey("Country")]
        public string CountryCode { get; set; }
        public Country Country { get; set; }

        [Required]
        [StringLength(512)]
        public string ProviderApiKey { get; set; }

        [Required]
        [StringLength(512)]
        public string ProviderUri { get; set; }

        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string ImageUri { get; set; }

        public string ThumbnailUri { get; set; }

        [Required]
        public ProviderType Type { get; set; }

        [Required]
        public bool IsExternal { get; set; }

        public bool IsDeleted { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ActivatedOn { get; set; }

        public DateTime? DeactivatedOn { get; set; }

        public string ActivatedBy { get; set; }

        public string DeactivatedBy { get; set; }
    }
}
