using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Country
    {
        [Key]
        public string CountryCode { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string FlagThumbnailUri { get; set; }

        public DateTime? ActivatedOn { get; set; }

        public DateTime? DeactivatedOn { get; set; }

        public string ActivatedBy { get; set; }

        public string DeactivatedBy { get; set; }

        [NotMapped]
        public virtual ICollection<Currency> Currencies { get; set; }
    }
}
