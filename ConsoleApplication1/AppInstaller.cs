using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ConsoleApplication1
{
    /// <summary>
    /// The registration details of this example are not significant to the solution 
    /// </summary>
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