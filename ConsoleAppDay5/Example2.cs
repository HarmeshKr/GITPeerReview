using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    delegate int MathDel(int x, int y);
    /*  class Example2
      {
          public int Add(int x,int y) { return x + y; }
          public int Product(int x, int y) { return x * y; }

          static void Main(string[] args)
          {
              Example2 obj = new Example2();

              MathDel delobj = obj.Add;
              delobj += obj.Product;

              int result=delobj.Invoke(20, 10);
              Console.WriteLine("The result is:{0}",result  );
          }
      }*/
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    delegate void NewMathDel(int x, int y); 
    class Example2
    {
        int[] Result = new int[2];
        public void Add(int x, int y) { Result[0]= x + y; }
        public void Product(int x, int y) { Result[1]= x * y; }

        public void GetResult()
        {
            foreach(int n  in Result)
            {
                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            Example2 obj = new Example2();

            NewMathDel delobj = obj.Add;
            delobj += obj.Product;

            delobj.Invoke(20, 10);
            obj.GetResult();
        }
    }
}
