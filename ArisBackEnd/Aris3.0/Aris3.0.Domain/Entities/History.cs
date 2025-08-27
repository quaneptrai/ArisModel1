using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Domain.Entities
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
        public Episode CurrentEpisode { get; set; }

        public DateTime LastWatched { get; set; } = DateTime.UtcNow;

        [Required]
        public int WatchDuration { get; set; } 
    }
}
