using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public record InvalidatedOrder( string customer, UnvalidatedProducts unvalidatedProducts);
}