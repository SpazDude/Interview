using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (var container = new WindsorContainer())
            {
                container.Install(new AppInstaller());
                do
                {
                    IOutputGenerator myClass;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            myClass = container.Resolve<OddNumberGenerator>();
                            break;
                        case "2":
                            myClass = container.Resolve<Class1>();
                            break;
                        case "3":
                            myClass = container.Resolve<OddNumberGenerator>();
                            break;
                        default:
                            return;
                    }
                    Console.WriteLine(myClass.GenerateOutput());
                } while (true);
            }
        }
    }

    public class AppInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IRange>().UsingFactoryMethod(() => new Range(0, 100)),

                Component.For<IOutputGenerator, ReverseEvenNumberGenerator>().ImplementedBy<ReverseEvenNumberGenerator>(),

                Component.For<IOutputGenerator, Class1>()
                    .ImplementedBy<Class1>()
                    .OnCreate((kernel, instance) => ((Class1)instance).SetRange(0, 100)),

                Component.For<IOutputGenerator, OddNumberGenerator>().ImplementedBy<OddNumberGenerator>()
                );
        }
    }
}
