using System.ComponentModel.DataAnnotations;

namespace Aris3._0Fe.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        [Required]
        public string FilmId { get; set; }
        public Film Film { get; set; }

        public int? CurrentEpisodeId { get; set; } 
        public DateTime LastWatched { get; set; } = DateTime.UtcNow;
        [Required]
        public int WatchDuration { get; set; }
    }
}
