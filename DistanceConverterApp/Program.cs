namespace DistanceConverterApp
{

    /// <summary>
    /// Reads a distance in kilometers from the user, validates the input and converts it to meters, centimeters and miles.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization of variables
            double kilometers = 0D;
            double meters = 0D;
            double centimeters = 0D;
            double miles = 0D;

            // Data input and validation
            Console.WriteLine("Παρακαλώ δώστε χιλιόμετρα:");
            if(!double.TryParse(Console.ReadLine(), out kilometers) || kilometers < 0)
            {
                Console.WriteLine("Μη έγκυρος αριθμός.");
                return;
            }

            // Calculations
            meters = kilometers * 1000;
            centimeters = kilometers * 1000000;
            miles = kilometers * 0.621371;

            // Output
            Console.WriteLine($"{"Χιλιόμετρα:"} {kilometers:N2} km");
            Console.WriteLine($"{"Μέτρα"} {meters:N2} m");
            Console.WriteLine($"{"Εκατοστά"} {centimeters:N2} cm");
            Console.WriteLine($"{"Μίλια"} {miles:N2} mi");
        }
    }
}
