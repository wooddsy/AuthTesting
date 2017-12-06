using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Model
{
    public class Basket
    {
       public string userId { get; set; }
       public int productId { get; set; }
       public int Quantity { get; set; }
    }
}
