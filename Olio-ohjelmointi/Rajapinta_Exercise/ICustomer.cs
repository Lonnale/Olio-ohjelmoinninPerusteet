using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Rajapinta_Exercise
{
    interface ICustomer
    {
        Customer GetCustomer(string Customername);
        int GetBonus();
    }
}
