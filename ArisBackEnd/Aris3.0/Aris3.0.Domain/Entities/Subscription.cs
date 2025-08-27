using Aris3._0.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Domain.Entities
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int MonthlyPrice { get; set; }
        [Required]
        public string Quality { get; set; } = string.Empty;
        [Required]
        public string Resolution { get; set; } = string.Empty;
        [Required]
        public int MaxScreen { get; set; }
        [Required]
        public int MaxDownload { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        [Required]
        public string Type { get; set; } = string.Empty;
        public ICollection<SubscriptionHistory> SubscriptionHistories { get; set; } = new List<SubscriptionHistory>();

        public List<Account> Accounts { get; set; } = new();
        public List<SupportedDevice> SupportedDevices { get; set; } = new();
    }
}
