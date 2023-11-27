namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            Console.WriteLine($" {myCar.Make} {myCar.Model} {myCar.Year}");
        }
    }
}
