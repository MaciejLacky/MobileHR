﻿using MobileHR.Models;
using MobileHR.ViewModels;
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
    public partial class NewPositionPage : ContentPage
    {
        public Position Item { get; set; }
        public NewPositionPage()
        {
            InitializeComponent();
            BindingContext = new NewPositionViewModel();
        }
    }
}