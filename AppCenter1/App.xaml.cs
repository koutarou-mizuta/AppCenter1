using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCenter1.Services;
using AppCenter1.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenter1
{
    public partial class App : Application
    {
        const string iosKey = "28c8ef2f-0d99-4e9c-9fd8-f4aa0ecd00e9";
        const string androidKey = "beb6bef2-7da4-48eb-8511-b4dae69ef890";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start($"android={androidKey};ios={iosKey};",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
