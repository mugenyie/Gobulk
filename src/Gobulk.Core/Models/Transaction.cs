using Gobulk.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gobulk.Core.Models
{
    public class Transaction
    {
        // *** ids ****

        [Key]
        public string TransactionId { get; set; }

        public string BatchId { get; set; }

        [Required]
        [ForeignKey("Account")]
        public string AccountId { get; set; }
        public virtual Account Account { get; set; }

        [Required]
        public string RequestId { get; set; }

        [StringLength(255)]
        public string CustomerId { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public string CurrencyCode { get; set; }
        public virtual Currency Currency { get; set; }

        [Required]
        [ForeignKey("Country")]
        public string CountryCode { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey("Provider")]
        public string ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        [Required]
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [ForeignKey("Channel")]
        public string ChannelId { get; set; }
        public virtual Channel Channel { get; set; }

        /*** amount ***/

        /// <summary>
        /// Request Amount 
        /// </summary>
        [Required]
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction amount
        /// Amount + Account Fees + Customer Fees
        /// </summary>
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// Transaction amount
        /// Amount + Customer Fees
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        // *** transaction info ***

        public DateTime TransactionStartTime { get; set; }

        /// <summary>
        /// String message from subscription client 
        /// e.g. you have paid for Internet
        /// </summary>
        [Required]
        [StringLength(512)]
        public string Memo { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public TransactionStatus Status { get; set; }

        [Required] // TODO: put max size to 512
        public string StatusMessage { get; set; }

        public DateTime? TransactionEndTime { get; set; }

        // *** reference JSON ***

        [Required]
        public string OrderReference { get; set; }

        [Required]
        public string PaymentReference { get; set; }

        [Required]
        public string RequestReference { get; set; }

        public string Metadata { get; set; }

        public string ChannelReference { get; set; }

        //  ***payments***

        public DateTime? PaymentStartTime { get; set; }

        [StringLength(255)]
        public string PaymentId { get; set; }

        [Required]
        public PaymentStatus PaymentStatus { get; set; }

        [Required]
        public int PaymentStatusCode { get; set; }

        public string PaymentStatusMessage { get; set; }

        public DateTime? PaymentEndTime { get; set; }

        //  ***orders***

        public DateTime? OrderStartTime { get; set; }

        [StringLength(255)]
        public string OrderId { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        [Required]
        public int OrderStatusCode { get; set; }

        public string OrderStatusMessage { get; set; }

        public DateTime? OrderEndTime { get; set; }

        // ***commits***

        public DateTime? CommitStartTime { get; set; }

        [StringLength(255)]
        public string CommitId { get; set; }

        [Required]
        public CommitStatus CommitStatus { get; set; }

        [Required]
        public int CommitStatusCode { get; set; }

        public string CommitStatusMessage { get; set; }

        public DateTime? CommitEndTime { get; set; }

        // *** fees and commissions***

        [Required]
        public decimal AccountFee { get; set; }

        [Required]
        public decimal CustomerFee { get; set; }

        [Required]
        public decimal ProviderFee { get; set; }

        [Required]
        public decimal AccountCommission { get; set; }

        [Required]
        public decimal ReferralCommission { get; set; }

        [Required]
        public decimal ProductCommission { get; set; }

        public bool RebateStatus { get; set; }

        public string RebateStatusMessage { get; set; }

        public int RebateStatusCode { get; set; }
    }
}
