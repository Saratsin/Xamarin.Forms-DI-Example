using Autofac;
using Xamarin.Forms;

namespace DI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Bootstrapper.Run();
        }
    }
}

