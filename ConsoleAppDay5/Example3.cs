using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    delegate bool CompareDel(int x,int y);
    internal class Example
    {
        public bool Compare(int x,int y)
        {
            return x > y;
        }
        static void Main(string[] args)
        {
            Example example = new Example();
            //CompareDel del = example.Compare;
            // CompareDel del = delegate (int x, int y) { return x > y; };
            // CompareDel del = (int x, int y) => { return x > y; };
            // CompareDel del = (x, y) => { return x > y; };
            // CompareDel del = (x, y) =>  x > y; 

            //Function delegate holds the reference of method/methods that return a value;
            Func<int, int, bool> del = (x, y) => x > y; 

            bool result = del(20,10);
            Console.WriteLine( result );
             
            Console.WriteLine(  "----------------------------------");

            //Action delegate holds the reference of method/methods that do not return a value;
            
            //no input and no return
            Action act = () => Console.WriteLine(DateTime.Now.ToLongDateString());
            act(); //invoke delegate

            Action<string, string> length = (s1, s2) =>
            {
                string result = s1 + s2;
                Console.WriteLine(result.Length);
            };
            length("A", "B");

            Console.WriteLine(  "--------------------------------");

            //Func<int> fn = () => { return 12000; };
            Func<int> fn = () =>  12000;

            int n = fn.Invoke();
            Console.WriteLine(  n);

            n = fn();
            Console.WriteLine( n );
        }
    }
}
