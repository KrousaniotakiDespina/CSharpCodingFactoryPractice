namespace VatCalculator
{

    /// <summary>
    /// Reads a product price from the user, validates the input and calculates the VAT and total price based on a given VAT rate.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization of variables
            const double VAT_RATE = 0.24;
            double price = 0D;
            double vat = 0D;
            double total = 0D;

            // Data input and validation
            Console.WriteLine("Παρακαλώ δώστε την τιμή:");
            if(!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός.");
                return;
            }

            // Calculations
            vat = price * VAT_RATE;
            total = price + vat;

            // Output
            Console.WriteLine($"{"Τιμή χωρίς ΦΠΑ:"} {price:N2} €");
            Console.WriteLine($"{"ΦΠΑ 24%:"} {vat:N2} €");
            Console.WriteLine($"{"Τιμή με ΦΠΑ:"} {total:N2} €");
        }
    }
}