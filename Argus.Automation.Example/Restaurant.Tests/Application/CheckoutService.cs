using Restorant.Checkout.Application.Constants;
using Restorant.Checkout.Application.Models;

namespace Restorant.Tests.Application
{
    public class CheckoutService
    {
        private static readonly TimeOnly DrinksDiscountEndTime = new (19, 0, 0, 0);

        private readonly Lazy<List<OrderDto>> _orders;

        public CheckoutService()
        {
            _orders = new Lazy<List<OrderDto>>(() => []);
        }

        public void AddNewOrder(OrderDto order)
        {
            if (order.StartersCount == 0 && order.MainsCount == 0 && order.DrinksCount == 0)
            {
                throw new Exception($"New order doesn't contain any items");
            }

            _orders.Value.Add(order);
        }

        public void PartiallyCanelExistingOrder(OrderDto order)
        {
            OrderDto? existingOrder = _orders.Value.LastOrDefault(x => x.TableNumber == order.TableNumber)
                ?? throw new Exception($"Table {order.TableNumber} order is NOT found. Please, check table number or create new order");

            if (order.StartersCount == 0 && order.MainsCount == 0 && order.DrinksCount == 0)
            {
                throw new Exception($"Updated order doesn't contain any items to update");
            }

            existingOrder.StartersCount -= order.StartersCount;
            existingOrder.MainsCount -= order.MainsCount;
            existingOrder.DrinksCount -= order.DrinksCount;
        }

        public decimal GetTableBill(int tableNumber)
        {
            IEnumerable<OrderDto> tableOrders = _orders.Value.Where(x => x.TableNumber == tableNumber);

            if (!tableOrders.Any())
            {
                throw new Exception($"Table {tableNumber} orders are NOT found. Please, check table number or create new order");
            }

            decimal bill = 0.00m;

            foreach (OrderDto order in tableOrders)
            {
                bill += order.StartersCount * Price.StartersCost;
                bill += order.MainsCount * Price.MainsCost;

                if (order.OrderTime >= DrinksDiscountEndTime)
                {
                    bill += order.DrinksCount * Price.DrinksCost;
                }
                else
                {
                    bill += order.DrinksCount * Price.DrinksCost * (1 - Price.DrinksDiscount);
                }
            }

            bill += bill * Price.ServiceCharge;

            if (bill <= 0)
            {
                throw new Exception($"The order for table {tableNumber} has negative or zero value: {bill}. please, check the order");
            }

            return bill;
        }
    }
}