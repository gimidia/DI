using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Interfaces;

namespace DI.Services
{
    public class DeliverService : IDeliverService
    {
        public double Fee(string state)
        {
            if ("SP" == (state))
            {
                return 10.0;
            }
            return 20.0;
        }
    }
}
