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
    public partial class EditDepartmentsPage : ContentPage
    {
        public Departments Item { get; set; }
        public EditDepartmentsPage()
        {
            InitializeComponent();
            BindingContext = new EditDepartmentsViewModel();
        }
    }
}