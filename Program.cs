using System.Diagnostics;

namespace Which_number_is_bigger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The program asks user three numbers and stores them in ints
            Console.WriteLine("Give me three numbers, I will tell which number is greatest.");
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //The program calls GetMax method
            Console.WriteLine(GetMax(num1, num2, num3));
        }

        //GetMax method compares all the numbers and gives the greatest and when it was given (firstly, secondly or thirdly)
        static int GetMax(int num1, int num2, int num3)
        {
            
            int result;
            

            if (num1 > num2 && num1 > num3)
            {
                result = num1;              
                Console.WriteLine($"The first number, {result} is greatest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = num2;
                Console.WriteLine($"The second number, {result} is greatest");
            }
            else if (num3 > num1 && num3 > num2)
            {
                result = num3;
                Console.WriteLine($"The third number, {result} is greatest");
            }


            //this tells if all the numbers are equal
            else
            {
                result = num1;
                Console.WriteLine("They are all equal");
            }


            return result;


        }
    }
}
