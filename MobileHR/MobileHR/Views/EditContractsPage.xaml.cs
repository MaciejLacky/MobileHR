using MobileHR.ViewModels;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContractsPage : ContentPage
    {
        public Contracts Item { get; set; }
        public EditContractsPage()
        {
            InitializeComponent();
            BindingContext = new EditContractsViewModel();
        }
    }
}