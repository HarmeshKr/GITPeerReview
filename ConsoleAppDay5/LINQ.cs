using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    internal class LINQ
    {
        static void Main(string[] args)
        {
            //LINQ to object
            int[] list = { 20,100,150,12,34,27,98,95,120,100,320,450,890,1000,10,4,71,93};

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~Query based syntax ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //IEnumerable<int> result = from n in list where n % 2 == 0 select n;

            // IEnumerable<int> result = (from n in list select n).Skip(3).Take(4);
            //IEnumerable<int> result = from n in list orderby n select n;

            /*
             int sum = (from n in list select n).Sum();
             double avg = (from n in list select n).Average();
             int min = (from n in list select n).Min();
             int max = (from n in list select n).Max();
             int count = (from n in list select n).Count();
            */

            //IEnumerable<int> result = from n in list orderby n descending select n;
            //IEnumerable<int> result = from n in list where n % 2 == 0 && n > 50 select n;

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~Extension method syntax ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //IEnumerable<int> result = list.OrderBy(p => p);
            //IEnumerable<int> result = list.OrderByDescending(p => p);

            IEnumerable<int> result = list.Where(p=> p > 100);

            foreach (int r in result)
            {
                Console.WriteLine( r);
            }
            Console.WriteLine("_----------------------------------");

            string[] colors = {"red","green","gray","blue","black","orange","olive" };

            // IEnumerable<string> output=from c in colors where c.StartsWith("b") select c;
            //IEnumerable<string> output = from c in colors where c.EndsWith("e") select c;
            IEnumerable<string> output = from c in colors where c.Length==5 select c;
            foreach (string color in output)
            {
                Console.WriteLine(color);
            }
        }
        
    }
}
