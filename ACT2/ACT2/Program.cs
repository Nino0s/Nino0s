using System.ComponentModel.DataAnnotations;

class Program

{
    class Car { 
    public String Brand;
    public String Color;
    public int Price;
        static void Main(string[] args)
        {
            //initialize object
            //array and/or list
            ////////////////

            List<Car> list = new List<Car>();

            while (true)
            {
                Console.WriteLine("Input new data? [Y/N]");

                if (Console.ReadLine() == "N") ;
                {
                    break;
                }
                Car car1 = new Car();

                Console.WriteLine("Input car brand =");
                car1.Brand = Console.ReadLine();
                Console.WriteLine("Input car color =");
                car1.Color = Console.ReadLine();
                Console.WriteLine("Input car price =");
                car1.Price = int.Parse(Console.ReadLine());

                list.Add(car1);
            }
            list.ForEach(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("==============");
            });
        }
    }


}
