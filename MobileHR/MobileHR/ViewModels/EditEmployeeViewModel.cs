using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class EditEmployeeViewModel : ANewItemViewModel<Employee>
    {
        #region Fields
        private string itemId;
        
        private string firstName;
        private string lastName;
        private string statusValue;
        private string genderValue;
        private int code;
        private string phoneNumber;
        private Status selectedStatus;
        private Gender selectedGender;
        private DateTime? dateBirth;
        private string pesel;
        private string adresEmail;
        private DateTime isseuDateIdentityCard;
        private DateTime expirationDateIdentityCard;


        #endregion
       
        #region Constructor
        public EditEmployeeViewModel() : base()
        {
            
        }
        #endregion

        #region Properties
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }
        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }
        public string StatusValue
        {
            get => statusValue;
            set => SetProperty(ref statusValue, value);
        }
        public string GenderValue
        {
            get => genderValue;
            set => SetProperty(ref genderValue, value);
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
       

        //public List<Status> Statuses
        //{
        //    get
        //    {
        //        return new StatusesDataStore().items;
        //    }
           
        //}
        public List<Gender> Genders
        {
            get
            {
                return new GendersDataStore().items;
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
        public DateTime? DateBirth
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
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(firstName);
        }

        public override Employee SetItem()
        {

            Employee newItem = new Employee()
            {
                ID = Convert.ToInt32(itemId),
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Code = Code,
                StatusId = 1 ,//SelectedStatus.ID,
                GenderId = SelectedGender.ID,
                AdressEmail = AdresEmail,
                DateBirth = DateBirth,
                Pesel = Pesel,
            };

           
            return newItem;

        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(Convert.ToInt32( itemId));
                FirstName = item.FirstName;
                LastName = item.LastName;
                PhoneNumber = item.PhoneNumber;
                Code = item.Code;
                Pesel = item.Pesel;
                AdresEmail = item.AdressEmail;
                DateBirth = item.DateBirth;
                StatusValue = item.StatusName;
                GenderValue = item.GenderName;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        #endregion



    }
}
