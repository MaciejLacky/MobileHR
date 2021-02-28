using MobileHR.Models;
using MobileHR.Services;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewEmployeeViewModel : ANewItemViewModel<Employee>
    {
        #region Fields
        private string firstName;
        private string lastName;
        private int code;
        private string phoneNumber;
        private Status selectedStatus;
        private Gender selectedGender;
        private DateTime dateBirth;
        private string pesel;
        private string adresEmail;
        private DateTime isseuDateIdentityCard;
        private DateTime expirationDateIdentityCard;
        private PickersDataStore picker = new PickersDataStore();
                     
        #endregion

        #region Constructor
        public NewEmployeeViewModel() : base()
        {
            selectedStatus = new Status();
            selectedGender = new Gender();
            dateBirth = DateTime.Now;
            isseuDateIdentityCard = DateTime.Now;
            expirationDateIdentityCard = DateTime.Now;
           
        }
        #endregion
        #region Fields
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(firstName);

        }

        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetProperty(ref phoneNumber, value);
        }
        public int Code
        {
            get => code;
            set => SetProperty(ref code, value);
        }

        public List<Status> Statuses
        {
            get
            {
                return picker.itemStatuses;
            }
        }
        public List<Gender> Genders
        {
            get
            {
                return picker.itemGender;
            }
        }
        public Status SelectedStatus
        {
            get => selectedStatus;
            set => SetProperty(ref selectedStatus, value);
        }
        public Gender SelectedGender
        {
            get => selectedGender;
            set => SetProperty(ref selectedGender, value);
        }
        public string Pesel
        {
            get => pesel;
            set => SetProperty(ref pesel, value);
        }
        public string AdresEmail
        {
            get => adresEmail;
            set => SetProperty(ref adresEmail, value);
        }
        public DateTime DateBirth
        {
            get => dateBirth;
            set => SetProperty(ref dateBirth, value);
        }
        public DateTime IsseuDateIdentityCard
        {
            get => isseuDateIdentityCard;
            set => SetProperty(ref isseuDateIdentityCard, value);
        }
        public DateTime ExpirationDateIdentityCard
        {
            get => expirationDateIdentityCard;
            set => SetProperty(ref expirationDateIdentityCard, value);
        }
        #endregion

        #region Helpers
        public override Employee SetItem()
        {
            Employee newItem = new Employee()
            {
                ID = 1,
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Code = Code,
                StatusId = 1,//SelectedStatus.ID,
                GenderId = SelectedGender.ID,
                AdressEmail = AdresEmail,
                DateBirth = DateBirth,
                Pesel = Pesel,


            };
            return newItem;
        }
        
        #endregion


    }
}
