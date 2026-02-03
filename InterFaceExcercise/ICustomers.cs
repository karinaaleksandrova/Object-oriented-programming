  using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExcercise
{
    internal interface ICustomers
    {
        void AddCustomers(Customer customer);

        void PrintCustomers();
    }
}
