using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class Participant : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
    }
}