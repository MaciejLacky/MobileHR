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
    public partial class TerminationWaysPage : ContentPage
    {
        TerminationWaysViewModel _viewModel;
        public TerminationWaysPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new TerminationWaysViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}