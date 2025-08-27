using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0Fe.Models
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

        // Navigation properties
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<SubscriptionHistory> SubscriptionHistories { get; set; } = new List<SubscriptionHistory>();
        public ICollection<SupportedDevice> SupportedDevices { get; set; } = new List<SupportedDevice>();
    }

}
