namespace Restorant.Checkout.Tests.DataItems
{
    public class OrderDataItem
    {
        public int TableNumber { get; set; }

        public required DateTime OrderTime { get; set; }

        public int StartersCount { get; set; } = default;

        public int MainsCount { get; set; } = default;

        public int DrinksCount { get; set; } = default;
    }
}