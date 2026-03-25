using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GenericDetails
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class PointDouble
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class PointObject
    {
        public object X { get; set; }
        public object Y { get; set; }
    }

    public class PointGeneric<T> where T: struct, INumber<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }

        public T GetTotal()
        {
            return X + Y;
        }
    }
}
