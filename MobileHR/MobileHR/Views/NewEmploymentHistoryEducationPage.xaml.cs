﻿using MobileHR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEmploymentHistoryEducationPage : ContentPage
    {
        public EmploymentHistoryEducation Item { get; set; }
        public NewEmploymentHistoryEducationPage()
        {
            InitializeComponent();
            BindingContext = new NewEmploymentHistoryEducationViewModel();
        }
    }
}