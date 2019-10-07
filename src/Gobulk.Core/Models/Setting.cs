using Gobulk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettingId { get; set; }

        [Required]
        public string Name { get; set; }

        // min transact-able amount per transaction
        public decimal MinimumTransactionAmount { get; set; }

        // max transact-able amount per transaction
        public decimal MaximumTransactionAmount { get; set; }

        [Required]
        public TransactionPlan TransactionPlan { get; set; }

        // total amount transact-able as per transaction plan,
        // if user's transactions reach this value then he has
        // to wait until new transaction plan period
        [Required]
        public decimal TransactionPlanTotalAmount { get; set; }

        [Required]
        public decimal MinimumBalance { get; set; }

        [Required]
        public AccountType AccountType { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public bool IsDeleted { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
