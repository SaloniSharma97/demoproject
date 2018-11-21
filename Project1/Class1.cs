using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Product
    {
        public int ProductId;
        public string Title;
        public float Price;
        public void GetProductDetails()
        {
            Console.WriteLine("Enter the ProductId:");
            ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Title:");
            Title = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            Price = Convert.ToSingle(Console.ReadLine());


        }

        public void DisplayProductDetails()
        {

            Console.WriteLine("Id:{0} Title:{1} Price:{2}", ProductId, Title, Price);

        }


    }
    class Class1
    {
        static void Main()

        {
            Product product = new Product();
            product.GetProductDetails();
            product.DisplayProductDetails();
        }
    }
}
