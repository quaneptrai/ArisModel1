using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0Fe.Models
{
    public class LikedFilms
    {
        public int Id { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public string FilmId { get; set; } = string.Empty;
        public string FilmName { get; set; } = string.Empty;
        public Film Film { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
