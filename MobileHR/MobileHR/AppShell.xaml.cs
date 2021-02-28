using System;
using System.Collections.Generic;
using MobileHR.ViewModels;
using MobileHR.Views;
using Xamarin.Forms;

namespace MobileHR
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NewEmployeePage), typeof(NewEmployeePage));
            Routing.RegisterRoute(nameof(EditStatusPage), typeof(EditStatusPage));
            Routing.RegisterRoute(nameof(EditGenderPage), typeof(EditGenderPage));          
            Routing.RegisterRoute(nameof(EditCurrencyPage), typeof(EditCurrencyPage));
            Routing.RegisterRoute(nameof(EditPositionPage), typeof(EditPositionPage));
            Routing.RegisterRoute(nameof(EditTypeContractPage), typeof(EditTypeContractPage));
            Routing.RegisterRoute(nameof(EditEmployeePage), typeof(EditEmployeePage));
            Routing.RegisterRoute(nameof(EditContractsPage), typeof(EditContractsPage));
            Routing.RegisterRoute(nameof(EditDepartmentsPage), typeof(EditDepartmentsPage));
            Routing.RegisterRoute(nameof(EditEmploymentHistoryEducationPage), typeof(EditEmploymentHistoryEducationPage));
            Routing.RegisterRoute(nameof(EditEmploymentHistoryPage), typeof(EditEmploymentHistoryPage));
            Routing.RegisterRoute(nameof(EmployeeRaportEndPage), typeof(EmployeeRaportEndPage));
            Routing.RegisterRoute(nameof(EmployeeIsActiveRaportPage), typeof(EmployeeIsActiveRaportPage));
            Routing.RegisterRoute(nameof(EmployeeReportSalaryPage), typeof(EmployeeReportSalaryPage));
            Routing.RegisterRoute(nameof(NewGenderPage), typeof(NewGenderPage));
            Routing.RegisterRoute(nameof(OptionsPage), typeof(OptionsPage));
            Routing.RegisterRoute(nameof(NewCurrencyPage), typeof(NewCurrencyPage));
            Routing.RegisterRoute(nameof(NewDepartmentPage), typeof(NewDepartmentPage));
            Routing.RegisterRoute(nameof(NewContractPage), typeof(NewContractPage));
            Routing.RegisterRoute(nameof(NewPositionPage), typeof(NewPositionPage));
            Routing.RegisterRoute(nameof(NewStatusPage), typeof(NewStatusPage));
            Routing.RegisterRoute(nameof(NewTerminationWayPage), typeof(NewTerminationWayPage));
            Routing.RegisterRoute(nameof(NewTypeContractPage), typeof(NewTypeContractPage));
            Routing.RegisterRoute(nameof(NewTypeRatePage), typeof(NewTypeRatePage));
            Routing.RegisterRoute(nameof(NewEmploymentHistoryPage), typeof(NewEmploymentHistoryPage));
            Routing.RegisterRoute(nameof(NewEmploymentHistoryEducationPage), typeof(NewEmploymentHistoryEducationPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
