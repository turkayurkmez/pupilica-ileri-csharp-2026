using createCustomAttribute.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace createCustomAttribute.Models
{
    public class User
    {

        [MyRequired("Kullanıcı adı boş olamaz")]
        [MyMinLength(3)]
        public string UserName { get; set; }

        [MyRange(16,80)]
        public int Age { get; set; }
         


    }
}
