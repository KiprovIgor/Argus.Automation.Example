namespace Restorant.Checkout.Application.Models
{
    public record OrderDto
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();

        public required int TableNumber { get; set; }

        public TimeOnly? OrderTime { get; set; }

        public int StartersCount { get; set; } = default;

        public int MainsCount { get; set; } = default;

        public int DrinksCount{ get; set; } = default;
    }
}