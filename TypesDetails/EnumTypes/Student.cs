using System;
using System.Collections.Generic;
using System.Text;

namespace EnumTypes
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public StudentState State { get; set; } = StudentState.Unknown;



    }
}
