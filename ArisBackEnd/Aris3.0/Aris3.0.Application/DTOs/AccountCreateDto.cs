using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Application.DTOs
{
    public class AccountCreateDto
    {
        public string Email { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; }
        public int SubscriptionId { get; set; } = 1;
    }
}
