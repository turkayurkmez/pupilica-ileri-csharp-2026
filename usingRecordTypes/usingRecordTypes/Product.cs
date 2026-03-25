using System;
using System.Collections.Generic;
using System.Text;

namespace usingRecordTypes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
           
            return this.GetHashCode() == obj.GetHashCode();
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return Id;
        }

        public static bool operator ==(Product left, Product right)
        {
            return left.Equals(right);
                 
        }

        public static bool operator !=(Product left, Product right)
        {
            return !left.Equals(right);
        }

    }
}
