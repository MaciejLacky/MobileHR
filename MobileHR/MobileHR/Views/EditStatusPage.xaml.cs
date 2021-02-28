using MobileHR.Models;
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
    public partial class EditStatusPage : ContentPage
    {
        public Status Item { get; set; }
        public EditStatusPage()
        {
            InitializeComponent();
            BindingContext = new EditStatusViewModel();
        }
    }
}