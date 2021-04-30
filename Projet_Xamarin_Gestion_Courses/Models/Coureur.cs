using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Projet_Xamarin_Gestion_Courses.Models
{
    public class Coureur : BindableObject
    {
        private int _num;
        private string _nom;
        private string _prenom;
        private string _age;
        private string _sexe;
        private List<Course> _course;

        public int Num { get => _num; set => _num = value; }
        public string Nom { get => _nom; set { _nom = value; OnPropertyChanged(); } }
        public string Prenom { get => _prenom; set { _prenom = value; OnPropertyChanged(); } }
        public string Age { get => _age; set { _age = value; OnPropertyChanged(); } }
        public string Sexe { get => _sexe; set { _sexe = value; OnPropertyChanged(); } }
        public List<Course> Course { get => _course; set { _course = value; OnPropertyChanged(); } }
    }
        
    }

