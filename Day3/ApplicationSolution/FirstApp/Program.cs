using System.Net.Http.Headers;

namespace FirstApp
{
    internal class Program
    {
        static int Add(int num1,int num2)
        {
            checked
            {
                int result = num1 + num2;
                return result;
            }
        }
        static int TakeNumber()
        {
            int num1;
            Console.WriteLine("Please enter the the number");
            while(!int.TryParse(Console.ReadLine(),out num1))
                Console.WriteLine("Invalid entry. Please enter a number");
            return num1;
        }
        static void Calculate()
        {
            int num1, num2;
            num1 = TakeNumber();
            num2 = TakeNumber();
            int sum = Add(num1,num2);
            PrintResult(sum,"Sum");
        }

        static void PrintResult(int sum, string ops)
        {
            Console.WriteLine($"The {ops} is {sum}");
        }

        static void Main(string[] args)
        {
            Calculate();
        }
    }
 
}
