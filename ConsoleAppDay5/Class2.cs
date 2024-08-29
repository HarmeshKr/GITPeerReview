using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    internal class Class2
    {
        public class Login
        {
            public event Action<string,string> LoginEvent;
            public void Fire()
            {
                LoginEvent("Ram","123");
            }
        }
    }
}
