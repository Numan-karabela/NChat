using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Domain.Entities.Identity
{
    public  class AppUser:IdentityUser<String>
    {
        public string MessageId { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
