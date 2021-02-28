using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class OptionViewModel : BaseViewModel
    {
        public OptionViewModel()
        {
            Title = "Opcje";
            Routing.RegisterRoute(nameof(CurrenciesPage), typeof(CurrenciesPage));
            Routing.RegisterRoute(nameof(DepartmentsPage), typeof(DepartmentsPage));
            Routing.RegisterRoute(nameof(GendersPage), typeof(GendersPage));
            Routing.RegisterRoute(nameof(PositionsPage), typeof(PositionsPage));
            Routing.RegisterRoute(nameof(StatusesPage), typeof(StatusesPage));
            Routing.RegisterRoute(nameof(TerminationWaysPage), typeof(TerminationWaysPage));
            Routing.RegisterRoute(nameof(TypeContractsPage), typeof(TypeContractsPage));
            Routing.RegisterRoute(nameof(TypeRatesPage), typeof(TypeRatesPage));

            CurrenciesCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(CurrenciesPage)));
            DepartmentsCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(DepartmentsPage)));
            GendersCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(GendersPage)));
            PositionsCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(PositionsPage)));
            StatusesCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(StatusesPage)));
            TerminationWaysCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TerminationWaysPage)));
            TypeContractsCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TypeContractsPage)));
            TypeRatesCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TypeRatesPage)));
        }
        public ICommand CurrenciesCommand { get; }
        public ICommand DepartmentsCommand { get; }
        public ICommand GendersCommand { get; }
        public ICommand PositionsCommand { get; }
        public ICommand StatusesCommand { get; }
        public ICommand TerminationWaysCommand { get; }
        public ICommand TypeContractsCommand { get; }
        public ICommand TypeRatesCommand { get; }
    }
}
