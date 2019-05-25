using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCsharp
{
    public class Book:Product
    {
        
        public Book(int ProductID, string name, double price, string producer):base(ProductID, name, price, producer)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        
        public override double computeTax()
        {
           return this.price * 8 / 100;
        }
    }
}
