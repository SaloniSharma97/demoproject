using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Product2
    {
        public int ProductId; //field or data members
        public string Title;
        public float Price;
        public  Product2() //parameterless instance constructor
        {
            ProductId = 0;
            Title = "";
            Price = 0;

        }
        public Product2(int ProductId, string Title, float Price)//parameterized constructor
        {

           this.ProductId = ProductId;
           this.Title = Title;
           this.Price = Price;

        }
        public void  DisplayDetails()
        {
            Console.WriteLine("{0} {1} {2}", ProductId, Title, Price);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Product2 product = new Product2();
            product.DisplayDetails();

            Product2 newproduct = new Product2(100, "Eraser", 450);
            newproduct.DisplayDetails();
                
         }

    }
}

