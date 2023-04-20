using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите значение парметра x:");
            Console.WriteLine("введите значение парметра x:");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Sin(x);
            Console.WriteLine($"Значение F  = {F}.");
            Console.ReadKey();

        }
    }
}
