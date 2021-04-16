﻿using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;


namespace Projet_Xamarin_Gestion_Courses.Models
{
    public class Course : BindableObject
    {
        private int _num;
        private string _nom;
        private float _distance;
        private string _lieu;
        private List<Course> _course;

        public int Num { get => _num; set => _num = value; }
        public string Nom { get => _nom; set {_nom = value; OnPropertyChanged(); } }
        public string Lieu { get => _lieu; set { _lieu = value; OnPropertyChanged(); } }
        public float Distance { get => _distance; set { _distance = value; OnPropertyChanged(); } }
        
    }
}
