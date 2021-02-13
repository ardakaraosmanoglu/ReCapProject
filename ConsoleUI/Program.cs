using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListTest();
        }

        private static void ListTest()
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
             
            }
        }
    }
}
