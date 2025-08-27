using System;
using System.ComponentModel.DataAnnotations;

namespace Aris3._0Fe.Models
{
    public class SubscriptionHistory
    {
        [Key]
        public int Id { get; set; }

        // Foreign key to Account
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        // Foreign key to Subscription
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }

        // Subscription info
        public string SubscriptionMethod { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; }
    }

}
