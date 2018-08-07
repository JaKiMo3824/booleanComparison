using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            //While Statement
            
            Console.WriteLine("Pick a whole number and I will count it down to 0.");
            int number = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (-1 < number)
                {
                    Console.WriteLine(number);
                    number--;
                }
            }
            Console.ReadLine();

            
            //Do While Statement

            Console.WriteLine("Pick a whole number and I will tell you if it is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder = num % 2;
            do
            {
                if (remainder == 1)
                {
                    Console.WriteLine("The number " + num + " is Odd.");
                    break;
                }
                else
                {
                    Console.WriteLine("The number " + num + " is Even.");
                    break;
                }
            }
            while (true);

            Console.ReadLine();


            
       
        }
    }
}
