using System;

namespace Exe{
    internal class Program
    {
        static void Main(string[] args)
        {
          
         int x, y, z;
            Console.WriteLine("Enter number 1 ?");
            x  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 ?");
            y = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (y % 2 > 0)
                {
                  
                    throw new OddNumberException();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch (OddNumberException one)
            {
                Console.WriteLine(one.Message);
            }
            Console.WriteLine("End of the program");
         
          
        }
    }
    public class OddNumberException : Exception
    {
      
        public override string Message
        {
            get
            {
                return "divisor cannot be odd number";
            }
        }
    }

}
       
 