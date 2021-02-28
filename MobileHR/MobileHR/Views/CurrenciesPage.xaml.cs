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
    public partial class CurrenciesPage : ContentPage
    {
        CurrenciesViewModel _viewModel;
        public CurrenciesPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CurrenciesViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}