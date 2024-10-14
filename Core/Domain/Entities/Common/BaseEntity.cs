namespace NChat.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; } = new DateTime();

    }
}
