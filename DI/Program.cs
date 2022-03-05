using DI.Interfaces;
using DI.Services;
using Ninject;
using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninject.IKernel inject = new StandardKernel();
            inject.Bind<IDeliverService>().To<DeliverService>();
            inject.Bind<ITaxService>().To<TaxService>();

            var obj = inject.Get<PayService>();            
            Console.WriteLine("Resultado: " + obj.FinalPrice(300.0, "RS"));
        }
    }
}
