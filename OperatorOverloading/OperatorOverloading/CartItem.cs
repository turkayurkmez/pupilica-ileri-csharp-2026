using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public static decimal operator +(CartItem left,  CartItem right)
        {
            return (left.Price * left.Quantity) + (right.Price * right.Quantity);
        }

        public static decimal operator -(CartItem left, CartItem right)
        {
            return (left.Price * left.Quantity) - (right.Price * right.Quantity);
        }

        public static decimal operator +(decimal left, CartItem right)
        {
            return left + (right.Price * right.Quantity);
        }
        //3 + 5

    }
}
