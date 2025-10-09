using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Customer Customer { get; set; }
    }
}