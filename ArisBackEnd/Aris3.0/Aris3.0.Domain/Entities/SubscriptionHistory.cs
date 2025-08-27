using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Domain.Entities
{
    public class SubscriptionHistory
    {
        [Key]
        public int Id { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public string SubsctionMethood { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; }
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}
