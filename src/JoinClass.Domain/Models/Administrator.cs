using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class Administrator : BaseModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}