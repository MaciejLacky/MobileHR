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
    public partial class NewTerminationWayPage : ContentPage
    {
        public TerminationWay Item { get; set; }
        public NewTerminationWayPage()
        {
            InitializeComponent();
            BindingContext = new NewTerminationWayViewModel();
        }
    }
}