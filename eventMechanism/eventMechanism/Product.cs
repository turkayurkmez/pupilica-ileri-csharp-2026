using System;
using System.Collections.Generic;
using System.Text;

namespace eventMechanism
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }


    public class ProductCreatedEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class ProductService
    {
        private List<Product> products = new();



        //eski yöntem:
        //public delegate void ProductCreatedEventHandler(object sender, ProductCreatedEventArgs e);
        //public event ProductCreatedEventHandler ProductCreated;

        //artık böyle:
        public event EventHandler<ProductCreatedEventArgs> ProductCreated;

        public void AddNewProduct(Product product)
        {

            products.Add(product);
            if (ProductCreated != null)
            {
                ProductCreatedEventArgs e = new ProductCreatedEventArgs { Product = product, CreatedBy = "Türkay", CreatedDate = DateTime.Now };

                ProductCreated(this, e);
            }
        }


    }
}
