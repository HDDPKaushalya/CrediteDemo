namespace CrediteCardAPI.Helpers
{
    public class CreditCardValidator
    {
        public static bool IsValidCardNumber(string cardNumber)
        {
            // Luhn Algorithm Implementation
            int sum = 0;
            bool alternate = false;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());
                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                        n -= 9;
                }
                sum += n;
                alternate = !alternate;
            }

            return sum % 10 == 0;
        }

        public static string GetCardType(string cardNumber)
        {
            if (cardNumber.StartsWith("4") && cardNumber.Length == 16)
                return "Visa";
            if ((cardNumber.StartsWith("34") || cardNumber.StartsWith("37")) && cardNumber.Length == 15)
                return "AmEx";
            if ((cardNumber.StartsWith("51") || cardNumber.StartsWith("52") ||
                cardNumber.StartsWith("53") || cardNumber.StartsWith("54") ||
                cardNumber.StartsWith("55") || cardNumber.StartsWith("22")) && cardNumber.Length == 16)
                return "Mastercard";
            if (cardNumber.StartsWith("6011") && cardNumber.Length == 16)
                return "Discover";

            return "Unknown";
        }
    }
}

