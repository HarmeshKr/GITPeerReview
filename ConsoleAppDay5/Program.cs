namespace ConsoleAppDay5
{
    public delegate void TestDelegate(int number);
    internal class Program
    {
        public static void Print(int x)
        {
            Console.WriteLine(x); ;
        }
        public void Display(int x)
        {
            Console.WriteLine( x);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            TestDelegate del = new TestDelegate(obj.Display); //single delegate
            //del.Invoke(1200);

            del += new TestDelegate(Program.Print);   //multicast delegate

            del.Invoke(2000);
            Console.WriteLine("-----------------------------");
            
            del -= new TestDelegate(Program.Print);
            del.Invoke(150);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            TestDelegate newdel = Program.Print;
            newdel += obj.Display;

            newdel(908);
            Console.WriteLine(  "-----------------------");
            newdel -= obj.Display;
            newdel(999);
        }
    }
}