using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDetails
{
    public class Product : IComparable<Product>
    {
        //IComparable<Product> tanımındaki in keyword'ü ko-varyans:

        public decimal Price { get; set; }
        public int CompareTo(Product? other)
        {
            if (this.Price > other.Price)
            {
                return 1;
            }
            else if (this.Price < other.Price) { return -1; }
            
            return 0;   
        }
    }

    public interface ICoVariance<out T> where T: class, new()
    {

        //public void CoVarianceFunction(T instance);

        public T GetInstance();
       

       
    }

    public interface IContraVariance<in T> where T : class, new()
    {

        public void CoVarianceFunction(T instance);

        //public T GetInstance();



    }

    public class GuitarImplementation<T> : ICoVariance<T> where T : class, new()
 
    {

        private T genericType;
        public T GetInstance()
        {
            return genericType;
        }

        
    }
}
