using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        private string name;
        public string Name { get; set; }
        private string cipher;
        public string Cipher { get; set; }
        private int amount;
        public int Amount { get; set; }


        public void Print()
        {
            Console.WriteLine("Название: " + Name + "Шифр: " + Cipher + "Количество: " + Amount);
        }

        public void Release()
        {
            Console.WriteLine("Введите название изделия: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите шифр изделия: ");
            cipher = Console.ReadLine();
            Console.WriteLine("Введите количество единиц изделия: ");
            amount = int.Parse(Console.ReadLine());
        }

        public Product()
        {
            Name = "Шестеренка Z7 ";
            Cipher = "282fdk4sz ";
            Amount = 7;
        }       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Product name = new Product();
            name.Print();
            Console.ReadLine();
        }
    }
}
