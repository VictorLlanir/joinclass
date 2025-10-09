using JoinClass.Domain.Models.Shared;

namespace JoinClass.Domain.Models
{
    public sealed class Subscription : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PlanId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Plan Plan { get; set; }
    }
}