using EfNinject.Entities;
using Ninject;
using System;
using System.Diagnostics;
using System.Linq;

namespace EfNinject
{
    class Program
    {
        static int cantidad = 1000;
        static void Main(string[] args)
        {
            ConsultaNinject();


            ConsultaSimple();
        }

        static void ConsultaNinject()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            IKernel kernel = new StandardKernel();
            kernel.Bind<IContext>().To<Context>().InSingletonScope();

            var context = kernel.Get<IContext>();

            for (int i = 0; i < cantidad; i++)
            {
                var persona = context.Personas.FirstOrDefault(c => c.Id == i);

                if (persona != null)
                {
                    Console.WriteLine(persona.Name);
                }
            }
            watch.Stop();
            Console.WriteLine("Tiempo total sin niject: {0}", watch.ElapsedMilliseconds);
        }

        static void ConsultaSimple()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < cantidad; i++)
            {
                var context = new Context();

                var persona = context.Personas.FirstOrDefault(c => c.Id == i);

                if (persona != null)
                {
                    Console.WriteLine(persona.Name);
                }
            }

            watch.Stop();
            Console.WriteLine("Tiempo total sin niject: {0}", watch.ElapsedMilliseconds);
        }
    }
}
