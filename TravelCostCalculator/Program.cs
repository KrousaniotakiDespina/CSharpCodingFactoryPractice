namespace TravelCostCalculator
{
    /// <summary>
    /// Reads fuel consumption (liters per 100km) and distance (km) from the user, calculates the liters and the total cost the vehicle will need.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization of variables
            const double FUEL_PRICE = 1.98;

            double consumption = 0D;
            double distance = 0D;
            double litersNeeded = 0D;
            double totalCost = 0D;

            // Data input and validation
            Console.WriteLine("Δώστε κατανάλωση (λίτρα/100χλμ):");
            if(!double.TryParse(Console.ReadLine(), out consumption) || consumption < 0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός.");
                return;
            }

            Console.WriteLine("Δώστε απόσταση (χλμ):");
            if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός.");
                return;
            }

            // Calculations
            litersNeeded = consumption * distance / 100;
            totalCost = litersNeeded * FUEL_PRICE;

            // Output
            Console.WriteLine($"{"Κατανάλωση:"} {consumption:N2} L/100km");
            Console.WriteLine($"{"Απόσταση:"} {distance:N2} km");
            Console.WriteLine($"{"Λίτρα που απαιτούνται:"} {litersNeeded:N2} L");
            Console.WriteLine($"{"Συνολικό κόστος:"} {totalCost:N2} €");
        }
    }
}
