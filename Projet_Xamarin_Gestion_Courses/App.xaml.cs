using Projet_Xamarin_Gestion_Courses.Models;
using Projet_Xamarin_Gestion_Courses.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_Gestion_Courses
{
    public partial class App : Application
    {
        public static List<Course> ListCourse { get; set; }
        public App()
        {
            InitializeComponent();

            if (ListCourse == null)
                ListCourse = new List<Course>();
            Initialisationlistecourse();

            MainPage = new ListCourse();
        }

        private void Initialisationlistecourse()
        {
           ListCourse.Add(new Course { Nom = "Marathon de New-York", Lieu = "New-York", Distance = 42.195f });
           ListCourse.Add(new Course { Nom = "Marathon de Toulouse", Lieu = "Toulouse", Distance = 42.195f });
           ListCourse.Add(new Course { Nom = "Semi-Marathon de Seine-St-Denis", Lieu = "Seine-St-Denis", Distance = 21.1f });


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
