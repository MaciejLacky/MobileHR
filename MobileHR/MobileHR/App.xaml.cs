using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileHR.Services;
using MobileHR.Views;
using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.ViewModels;

namespace MobileHR
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            DependencyService.Register<ServiceReferenceMobileHR.ServiceMobileHRClient>();
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<TypeRatesDataStore>();
            DependencyService.Register<EmploymentHistDataStore>();
            DependencyService.Register<EmploymentHistEduDataStore>();
            DependencyService.Register<StatusesDataStore>();
            DependencyService.Register<EmployeeDataStore>();
            DependencyService.Register<RaportsDataStore>();
            DependencyService.Register<GendersDataStore>();
            DependencyService.Register<CurrenciesDataStore>();
            DependencyService.Register<DepartmentsDataStore>();
            DependencyService.Register<ContractDataStore>();
            DependencyService.Register<PositionDataStore>();
            DependencyService.Register<TerminationWaysDataStore>();
            DependencyService.Register<TypeContractDataStore>();        
            Messenger.Default.Register<Employee>(this, EmployeeIdAsync);
            Messenger.Default.Register<Contract>(this, ContractIdAsync);
            Messenger.Default.Register<Department>(this, DepartmentIdAsync);
            Messenger.Default.Register<EmploymentHistEdu>(this, EmpHistEduIdAsync);
            Messenger.Default.Register<EmploymentHist>(this, EmpHistIdAsync);
            Messenger.Default.Register<Currency>(this, CurrencyIdAsync);
            Messenger.Default.Register<Gender>(this, GenderIdAsync);
            Messenger.Default.Register<Status>(this, StatusIdAsync);
            Messenger.Default.Register<Position>(this, PositionIdAsync);
            Messenger.Default.Register<TypeContract>(this, TypeContractIdAsync);

        }
        private async void TypeContractIdAsync(TypeContract id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditTypeContractPage)}?{nameof(EditTypeContractViewModel.ItemId)}={x}");
        }
        private async void PositionIdAsync(Position id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditPositionPage)}?{nameof(EditPositionViewModel.ItemId)}={x}");
        }
        private async void StatusIdAsync(Status id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditStatusPage)}?{nameof(EditStatusViewModel.ItemId)}={x}");
        }
        private async void GenderIdAsync(Gender id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditGenderPage)}?{nameof(EditGendersViewModel.ItemId)}={x}");
        }
        private async void CurrencyIdAsync(Currency id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditCurrencyPage)}?{nameof(EditCurrenciesViewModel.ItemId)}={x}");
        }
        private async void EmpHistIdAsync(EmploymentHist id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditEmploymentHistoryPage)}?{nameof(EditEmploymentHistoryViewModel.ItemId)}={x}");
        }
        private async void EmpHistEduIdAsync(EmploymentHistEdu id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditEmploymentHistoryEducationPage)}?{nameof(EditEmploymentHistoryEducationViewModel.ItemId)}={x}");
        }
        private async void DepartmentIdAsync(Department id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditDepartmentsPage)}?{nameof(EditDepartmentsViewModel.ItemId)}={x}");
        }
        private async void EmployeeIdAsync(Employee id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditEmployeePage)}?{nameof(EditEmployeeViewModel.ItemId)}={x}");
        }
        private async void ContractIdAsync(Contract id)
        {
            string x = id.ID.ToString();
            await Shell.Current.GoToAsync($"{nameof(EditContractsPage)}?{nameof(EditContractsViewModel.ItemId)}={x}");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
