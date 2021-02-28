using MobileHR.ViewModels;
using ServiceReferenceMobileHR;
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
    public partial class NewEmploymentHistoryPage : ContentPage
    {
        public EmploymentHistory Item { get; set; }
        public NewEmploymentHistoryPage()
        {
            InitializeComponent();
            BindingContext = new NewEmploymentHistoryViewModel();
        }
    }
}