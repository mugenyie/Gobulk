using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Currency
    {
        [Key]
        public string CurrencyCode { get; set; }

        public string SymbolThumbnailUri { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string LongDescription { get; set; }

        public string ShortDescription { get; set; }

        public DateTime? ActivatedOn { get; set; }

        public DateTime? DeactivatedOn { get; set; }

        public string ActivatedBy { get; set; }

        public string DeactivatedBy { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
