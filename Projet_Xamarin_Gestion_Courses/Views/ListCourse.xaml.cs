using Projet_Xamarin_Gestion_Courses.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_Gestion_Courses.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCourse : ContentPage
    {    
        public ListCourse()
        {
            InitializeComponent();
            BindingContext = new ListeCourseViewModel();
        }
    }
}
