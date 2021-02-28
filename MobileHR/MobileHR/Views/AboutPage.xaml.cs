using MobileHR.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHR.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            DependencyService.Register<EmployeeDataStore>();
            DependencyService.Register<ContractDataStore>();
        }
    }
}