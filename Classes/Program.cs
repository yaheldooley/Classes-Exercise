namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Chevy";
            car.Model = "Bolt";
            car.Year = 2022;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }

        public class Car
        {
            public string Make;
            public string Model;
            public int Year;
        }
    }
}
