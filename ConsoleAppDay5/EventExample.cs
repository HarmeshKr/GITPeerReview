using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    internal class Publisher
    {
        public event Action<string, DateTime> NewsEvent;
        public void StartBrodcastingNews()
        {
            NewsEvent("Weather is good today", DateTime.Now);
        }
    }
    class Subscriber
    {
        public void NewsReciever(string news,DateTime newstime)
        {
            Console.WriteLine($"{news}   {newstime}");
        }
    }
    class A
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            publisher.NewsEvent += subscriber.NewsReciever;            
            publisher.StartBrodcastingNews();

           // publisher.NewsEvent.Invoke("aaa",DateTime.Now);
        }
    }
}