using Autofac;
using System;
using u_bluedos.Interfaces;
using u_bluedos.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace u_bluedos
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            var container = AutofacInit();
            IScannerService ScannerService = container.Resolve<IScannerService>();


            MainPage = new MainPage(ScannerService);

            
        }

        private IContainer AutofacInit()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ScannerService>().As<IScannerService>();

            return builder.Build();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
