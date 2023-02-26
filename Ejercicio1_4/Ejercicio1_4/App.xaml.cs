using Ejercicio1_4.Controllers;
using Ejercicio1_4.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_4
{
    public partial class App : Application
    {
        static EmpleadosDB basedatos;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarEmpleados());
        }
        public static EmpleadosDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new EmpleadosDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleadosDB.db3"));
                }
                return basedatos;
            }
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
