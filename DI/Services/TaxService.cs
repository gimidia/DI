using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Interfaces;

namespace DI.Services
{
    public class TaxService : ITaxService
    {
        public double Tax(double value)
        {
            return value * 0.1;
        }
    }
}
