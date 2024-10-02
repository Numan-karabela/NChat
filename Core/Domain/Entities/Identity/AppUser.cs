using Microsoft.AspNetCore.Identity;
using NChat.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Domain.Entities.Identity;

public class AppUser : IdentityUser<string>
{
    public string SentMessagesId { get; set; }
    public Message SentMessages { get; set; } 
}
