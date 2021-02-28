using System.ComponentModel;
using Xamarin.Forms;
using MobileHR.ViewModels;

namespace MobileHR.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}