using Microsoft.AspNetCore.Identity;

namespace WebStore.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public long ApllicationId { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsFull {  get; set; }
    }
}
