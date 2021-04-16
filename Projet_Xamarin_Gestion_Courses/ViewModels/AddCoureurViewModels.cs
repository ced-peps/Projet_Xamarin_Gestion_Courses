using Projet_Xamarin_Gestion_Courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Projet_Xamarin_Gestion_Courses.ViewModels
{
    public class AddCoureurViewModels : BindableObject
    {
        private Coureur _coureur;
        public Coureur Coureur { get => _coureur; set { _coureur = value; OnPropertyChanged();} }

        public INavigation Navigation { get; set; }
        public Command ValiderMonCoureur { get; set; }

        public AddCoureurViewModels(INavigation navigation)
        {
            if (Coureur == null)
                Coureur = new Coureur();
            ValiderMonCoureur = new Command(ValiderMonCoureurCommand);

        }

        private void ValiderMonCoureurCommand()
        {
            Navigation.PopModalAsync();

            //Coureur.Prenom = null;
            //if(!string.IsNullOrEmpty(Coureur.Prenom))
            //{
                
            //}
        }
    }
}
