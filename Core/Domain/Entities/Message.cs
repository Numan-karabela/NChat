using NChat.Domain.Entities.Common;
using NChat.Domain.Entities.Identity;

namespace NChat.Domain.Entities;


public class Message : BaseEntity
{
    public string SenderId { get; set; }
    public AppUser Sender { get; set; }
    public string MessageBody { get; set; } 
    public string ReceivedId { get; set; }
}