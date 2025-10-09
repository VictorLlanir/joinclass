using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class Module : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}