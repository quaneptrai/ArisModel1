using System.ComponentModel.DataAnnotations;

namespace Aris3._0Fe.Models
{
    public class SupportedDevice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DeviceName { get; set; } = string.Empty;
        public List<Subscription> Subscriptions { get; set; } = new();
    }
}
