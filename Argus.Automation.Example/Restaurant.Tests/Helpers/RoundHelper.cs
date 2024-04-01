namespace Restorant.Checkout.Helpers
{
    public static class RoundHelper
    {
        public static decimal DefaultRound(this decimal value, int roundDigits = 2)
        {
            return Math.Round(value, roundDigits, MidpointRounding.AwayFromZero);
        }
    }
}