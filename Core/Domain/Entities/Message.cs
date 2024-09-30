using NChat.Domain.Entities.Common;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Domain.Entities;

public class Message:BaseEntity
{ 
    public string Messagee { get; set; }
    public string ToUsersId { get; set; }
    public ICollection<AppUser> ToUsers { get; set; }
}
