using System;
using Autofac;
using Xamarin.Forms;

namespace DI
{
    public class Bootstrapper
    {
        public static void Run()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DIModule>();
            var container = builder.Build();

            var page = container.Resolve<MountainAreasView>();
            Application.Current.MainPage = new NavigationPage(page);
        }
    }
}