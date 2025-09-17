namespace PriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName;
            double productPrice;
            int productQuantity;
            double totalPrice;
            double taxRate;

            Console.WriteLine("Johns metodiska prisberäknare!");
            Console.WriteLine();
            Console.Write("Vad vill du köpa?: ");
            productName = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Vad kostar {productName} per styck?: ");
            productPrice = ValidateDoubleInput(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Hur många {productName} vill du köpa?: ");
            productQuantity = ValidateIntInput(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Ange momssats (valfritt, annars 25%): ");
            taxRate = ValidateTaxInput(Console.ReadLine());
            Console.WriteLine();

            totalPrice = CalculateTotal(productName, productPrice, productQuantity, taxRate);
            totalPrice = Math.Round(totalPrice, 2);
            Console.WriteLine($"Totalt att betala: {totalPrice:F2}");
        }
        // Metod för att validera double input
        static double ValidateDoubleInput(string input)
        {
            double value;
            while (!double.TryParse(input, out value) || value < 0)
            {
                Console.Write("Ogiltig inmatning. Vänligen ange ett giltigt pris: ");
                input = Console.ReadLine();
            }
            return value;
        }
        // Metod för att validera momssats
        static double ValidateTaxInput(string input)
        {
            double value;
            if (string.IsNullOrEmpty(input))
            {
                value = 0.25; // Default momssats på 25%
                return value;
            }
            while (!double.TryParse(input, out value) || value > 1)
            {
                Console.Write("Ogiltig inmatning. Vänligen ange en giltig momssats (0-1): ");
                input = Console.ReadLine();
            }
            return value;
        }
        // Metod för att validera int input
        static int ValidateIntInput(string input)
        {
            int value;
            while (!int.TryParse(input, out value) || value < 0)
            {
                Console.Write("Ogiltig inmatning. Vänligen ange ett giltigt antal: ");
                input = Console.ReadLine();
            }
            return value;
        }
        // Metod för att beräkna totalpriset inklusive moms
        static double CalculateTotal(string product, double price, int quantity, double tax)
        {
            double total = (price * quantity) * (1 + tax);
            return total;
        }
    }
}
