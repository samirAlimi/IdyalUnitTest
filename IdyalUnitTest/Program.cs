using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdyalUnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloMessage());
        }
        public static String HelloMessage()
        {
            return "Hello, we will do some tests";
        }
        public bool IsPrime(int candidate)
        {
            if (candidate == 2)
            {
                return true;
            }
            else return false;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Prod(int a, int b)
        {
            return a * b;
        }
        public int Diviser(int a, int b)
        {
            return a / b;
        }
    }
}
