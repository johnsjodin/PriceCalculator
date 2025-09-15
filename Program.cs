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
            totalPrice
            Console.WriteLine($"Totalt att betala:");
        }
    }
}
