using NChat.Domain.Entities.Common;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Domain.Entities
{
    public class User:BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser{ get; set; }
        public string SentMessagesId { get; set; }
        public ICollection<Message> SentMessages { get; set; }
    }
}
