using Projet_Xamarin_Gestion_Courses.Models;
using Projet_Xamarin_Gestion_Courses.Views;
using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;


namespace Projet_Xamarin_Gestion_Courses.ViewModels
{
    class ListeCourseViewModel : BindableObject
    {
        private List<Course> _courses;

        public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged(); } } //OnPropertyChanged gère automatiquement les maj 

        public Command ActionNavigation { get; set; }

        public Command AjouterCourse { get; set; }

        
        public INavigation Navigation { get; set; }
        public ListeCourseViewModel(INavigation navigation)
        {
        if (Courses == null)
            Courses = new List<Course>();
            Courses = App.ListCourse;
            ActionNavigation = new Command(ActionNavigationCommand);
            AjouterCourse = new Command(AjouterCourseCommand);
            
            Navigation = navigation;
        }

        private void ActionNavigationCommand()
        {
            Navigation.PushModalAsync(new AddCoureur());
        }

        private void AjouterCourseCommand()
        {

        }

       
    }
}
