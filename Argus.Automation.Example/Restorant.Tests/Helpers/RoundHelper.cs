namespace Restorant.Checkout.Helpers
{
    public static class RoundHelper
    {
        public static double DefaultRound(this double value, int roundDigits = 2)
        {
            return Math.Round(value, roundDigits, MidpointRounding.AwayFromZero);
        }
    }
}