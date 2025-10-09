using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class Plan : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationInMonths { get; set; }
    }
}