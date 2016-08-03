using Autofac;

namespace DI
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MountainWeatherService>().As<IMountainWeatherService>().SingleInstance();
            builder.RegisterType<MountainAreaViewModel>();
            builder.RegisterType<MountainAreasViewModel>().SingleInstance();
            builder.RegisterType<MountainAreasView>().SingleInstance();
        }
    }
}

