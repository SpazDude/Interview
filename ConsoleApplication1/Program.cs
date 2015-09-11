using System;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Install(new AppInstaller());

            do
            {
                var option = Console.ReadLine();
                try
                {
                    var myClass = container.Resolve<IGenerateOutput>(option);
                    Console.WriteLine(myClass.GenerateOutput());
                }
                catch (ComponentNotFoundException ex)
                {
                    break;
                }
            } while (true);
        }
    }

    public class AppInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IRange>().UsingFactoryMethod(() => new Range(0, 100)),
                Component.For<IGenerateOutput>().ImplementedBy<ReverseEvenNumberGenerator>().Named("1"),
                Component.For<IGenerateOutput>()
                    .ImplementedBy<Class1>()
                    .Named("2")
                    .OnCreate((kernel, instance) => ((Class1)instance).SetRange(0, 100)),
                Component.For<IGenerateOutput>().ImplementedBy<OddNumberGenerator>().Named("3"),
                Component.For<IGenerateOutput>().ImplementedBy<FizzBuzzGenerator>().Named("4")
                );
        }
    }
}
