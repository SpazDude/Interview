using System;
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
                            myClass = container.Resolve<ReverseEvenNumberGenerator>();
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
}
