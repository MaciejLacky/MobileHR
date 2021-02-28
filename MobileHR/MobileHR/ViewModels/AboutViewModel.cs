using MobileHR.Services;
using MobileHR.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "MobileHR";
            Routing.RegisterRoute(nameof(EmployeesPage), typeof(EmployeesPage));
            Routing.RegisterRoute(nameof(ContractsPage), typeof(ContractsPage));
            OptionCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(OptionsPage)));
            EmployeesCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(EmployeesPage)));
            AddEmployeeCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(NewEmployeePage)));
            AddContractCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(NewContractPage)));
            ContractsCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(ContractsPage)));
        }
        public ICommand OptionCommand { get; }
        public ICommand OpenWebCommand { get; }
        public ICommand EmployeesCommand { get; }
        public ICommand AddEmployeeCommand { get; }
        public ICommand AddContractCommand { get; }
        public ICommand ContractsCommand { get; }
    }
}
