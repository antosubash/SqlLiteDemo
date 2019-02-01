using System;
using Microsoft.EntityFrameworkCore;
using SqlLiteDemo.DBService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SqlLiteDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var ctx = new DatabaseContext();
            ctx.Database.EnsureCreated();
            ctx.Database.Migrate();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
