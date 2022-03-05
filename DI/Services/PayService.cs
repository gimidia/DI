using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Services
{

    public class PayService
    {
        private readonly TaxService taxService;

        private readonly DeliverService deliverService;

        public PayService(TaxService taxService, DeliverService deliverService)
        {
            this.taxService = taxService;
            this.deliverService = deliverService;

        }

        public double FinalPrice(double cost, String state)
        {
            return cost + deliverService.Fee(state) + taxService.Tax(cost);
        }
    }
}
