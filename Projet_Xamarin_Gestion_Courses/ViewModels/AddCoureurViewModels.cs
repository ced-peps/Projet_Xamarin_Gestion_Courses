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

        public Command Retour { get; set; }

       

        public AddCoureurViewModels(INavigation navigation)
        {
            if (Coureur == null)
                Coureur = new Coureur();
            ValiderMonCoureur = new Command(ValiderMonCoureurCommand);
            Navigation = navigation;
            Retour = new Command(RetourCommand);
        }

        private void ValiderMonCoureurCommand()
        {
            if (!string.IsNullOrEmpty(Coureur.Prenom) && !string.IsNullOrEmpty(Coureur.Nom) && !string.IsNullOrEmpty(Coureur.Age) && !string.IsNullOrEmpty(Coureur.Sexe))
            {
                App.ListCoureurs.Add(Coureur);
                Navigation.PopModalAsync();
            }
           
        }

        private void RetourCommand()
        {
            
            Navigation.PopModalAsync();
        }
    }
}
