namespace Arhithmetic
{
    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int num1, num2;

        //Addition
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total added value is:" + math.Add(num1, num2));

        //Subtraction
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total subtracted value is:" +math.Subtract(num1, num2));

        //Multiplication
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total multiplied value is: " + math.Multiply(num1, num2));

            //Division
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The total Quotient is :" + math.Divide(num1, num2));

        }
    }

}
