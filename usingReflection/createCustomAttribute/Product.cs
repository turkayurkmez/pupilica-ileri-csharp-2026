using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace createCustomAttribute
{

    [Serializable]
    public class Product
    {
        [NotMapped]
        public string NotMappedSample { get; set; }
    }
}
