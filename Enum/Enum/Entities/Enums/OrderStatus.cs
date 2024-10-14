using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PedingPayment = 0,
        Processing =1 ,
        Shipped = 2 ,
        Delivered = 3
    }
}
