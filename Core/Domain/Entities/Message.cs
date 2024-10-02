using NChat.Domain.Entities.Common;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Domain.Entities;


public class Message : BaseEntity
{
    public string MessageBody { get; set; }
    public string ReceivedId { get; set; }
    public AppUser Received { get; set; }
}