using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); 
            Book book = new Book(1, "HomeComing", 10, "English");
            Book book1 = new Book(2, "FarFromHome", 20, "SpiderMan");
            Book book2 = new Book(3, "EndGame", 200, "Avenger4");
            Mobile mobile =new Mobile(1, "iPhone", 100, "Apple");
            Mobile mobile1 = new Mobile(2, "iPhoneX", 10, "Apple");
            Mobile mobile2 = new Mobile(3, "iPhoneXS", 1000, "Apple");
            list.Add(book);
            list.Add(book1);
            list.Add(book2);
            list.Add(mobile);
            list.Add(mobile1);
            list.Add(mobile2);
            double sum = 0;
            foreach (Product product in list)
            {
                sum += product.computeTax();
            }
            System.Console.WriteLine("Total: " + sum);
            Console.ReadKey();
            
        }
    }
}
