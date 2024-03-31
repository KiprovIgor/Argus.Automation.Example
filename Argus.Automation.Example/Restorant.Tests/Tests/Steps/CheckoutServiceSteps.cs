using FluentAssertions;
using Reqnroll;
using Restorant.Checkout.Application.Models;
using Restorant.Checkout.Helpers;
using Restorant.Checkout.Tests.DataItems;
using Restorant.Tests.Application;

namespace Restorant.Checkout.Tests.Steps
{
    [Binding]
    public class CheckoutServiceSteps(ScenarioContext scenarioContext)
    {
        private const string TableNumberKey = "TableNumberKey";
        private const string TableBillKey = "TableBillKey";

        private readonly Lazy<CheckoutService> _checkoutService = new (() => new CheckoutService());

        [Given("Restaurant opens with menu by set cost")]
        public void RestaurantOpensWithMenuBySetCost(DataTable dataTable)
        {
            // dataTable can be used to set price values and other conditions
            scenarioContext.Add("initialdata", dataTable);
        }

        [StepDefinition("Clients make an order")]
        [StepDefinition("Clients extend an order")]
        public void ClientsMakeAnOrder(DataTable dataTable)
        {
            OrderDataItem orderDataItem = dataTable.CreateSet<OrderDataItem>().First();

            var order = new OrderDto
            {
                TableNumber = orderDataItem.TableNumber,
                OrderTime = new TimeOnly(orderDataItem.OrderTime.TimeOfDay.Ticks),
                StartersCount = orderDataItem.StartersCount,
                MainsCount = orderDataItem.MainsCount,
                DrinksCount = orderDataItem.DrinksCount
            };

            _checkoutService.Value.AddNewOrder(order);

            scenarioContext[TableNumberKey] = order.TableNumber;
        }

        [StepDefinition("Clients partially cancel an order")]
        public void ClientsPartiallyCancelAnOrder(DataTable dataTable)
        {
            OrderDataItem orderDataItem = dataTable.CreateSet<OrderDataItem>().First();

            var order = new OrderDto
            {
                TableNumber = orderDataItem.TableNumber,
                StartersCount = orderDataItem.StartersCount,
                MainsCount = orderDataItem.MainsCount,
                DrinksCount = orderDataItem.DrinksCount
            };

            _checkoutService.Value.PartiallyCanelExistingOrder(order);

            scenarioContext[TableNumberKey] = order.TableNumber;
        }

        [When("Clients requested a bill")]
        public void WhenClientsRequestedABill()
        {
            var tableNumber = scenarioContext.Get<int>(TableNumberKey);

            double bill = _checkoutService.Value.GetTableBill(tableNumber);

            scenarioContext[TableBillKey] = bill;
        }

        [Then("Clients assert bill amount equals to {double} pounds sterling")]
        public void ClientsAssertBillAmountEqualsToPoundsSterling(double expectedBill)
        {
            var actualBill = scenarioContext.Get<double>(TableBillKey);

            actualBill.DefaultRound().Should().Be(expectedBill.DefaultRound());
        }
    }
}