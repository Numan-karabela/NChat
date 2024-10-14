using Microsoft.AspNetCore.Identity;

namespace NChat.Domain.Entities.Identity;

public class AppUser : IdentityUser<string>
{

    public ICollection<Message>? Messages{ get; set; }
}
