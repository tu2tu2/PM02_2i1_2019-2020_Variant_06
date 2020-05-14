using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;

namespace ConsoleApplication1 
{
    class Program
    {
        static int test(double a, out double b, out double c)
        {
            int i = (int)a;             
            b = a * a;             
            c = a * a * a;  
            return i;         
        }
        static void Main()
        {             
            int I;
            double c, b, a = 5.5;             
            I = test(a, out b, out c);
            Console.WriteLine("Original value: {0}\n Int  : {1}\n  a ^ 2: {2}\n  a ^ 3: {3}",a,I,b,c);
            Console.ReadLine();
        }
    }
}
