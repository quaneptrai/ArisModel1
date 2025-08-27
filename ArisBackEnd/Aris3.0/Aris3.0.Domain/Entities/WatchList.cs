using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Domain.Entities
{
    public class WatchList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "For Later";
        public Guid AccountId { get; set; }
        public DateTime AddAt { get; set; } = DateTime.UtcNow;
        public Account Account { get; set; }
        public string FilmId { get; set; }
        public Film Film { get; set; }
    }
}
