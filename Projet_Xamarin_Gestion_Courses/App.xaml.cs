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
           ListCourse.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
           ListCourse.Add(new Course { Nom = "Marathon de Montpellier", Lieu = "Montpellier", Distance = 42.195f });
           ListCourse.Add(new Course { Nom = "Semi-Marathon de Phalempin", Lieu = "Phalempin", Distance = 21.1f });


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
