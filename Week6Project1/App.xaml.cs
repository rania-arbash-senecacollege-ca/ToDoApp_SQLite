using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week6Project1
{
    public partial class App : Application
    {
        public static DatabaseManger dbManger;
        public App()
        {
            InitializeComponent();
             dbManger = new DatabaseManger();

            MainPage = new MainPage();
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
