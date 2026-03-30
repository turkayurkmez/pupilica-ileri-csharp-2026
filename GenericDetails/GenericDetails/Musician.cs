using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDetails
{

    public class Guitar
    {
        public void PlaySolo()
        {

        }
    }

    public class ElectricGuitar : Guitar 
    { 
    
    }
    public class Musician
    {
        public void Play(Guitar guitar)
        {
            guitar.PlaySolo();
        }
    }
}
