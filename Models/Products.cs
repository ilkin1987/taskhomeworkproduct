using System;
using System.Collections.Generic;
using System.Text;
using TaskHomework.Enums;

namespace TaskHomework.Models
{
    class Products
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public double DiscountedPrice { get; set; }
        static int TotalCount;
        private string barcode;
        static int Count = 1000;
        
        public ProductType ProductType;
        public Products(string name, double price, ProductType productType)
        {
            TotalCount++;
            Count++;

            Name = name;
            Price = price;
            ProductType = productType;

            switch ((int)ProductType)
            {
                
                case (int)ProductType.meat:
                barcode= "et mehsullari" + Count;

                break;

                case (int)ProductType.drink:
                barcode = "ickiler" + Count;

                break;

                case (int)ProductType.fish:
                barcode = "baliq mehsullari" + Count;

                break;

                case (int)ProductType.bakery:
                barcode = "un mehsullari" + Count;
                DiscountedPrice = price - (price * 0.1);

                 break;

                default:

                break;
            }

        }
             public override string ToString()
             {
            return $"{Name} {Price} {ProductType} {TotalCount} {DiscountedPrice} {barcode}";
             }
    }
}
