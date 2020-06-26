
using Common.Interfaces;
using Lands.Resources;
using System.Globalization;
using Xamarin.Forms;

namespace Lands.Helpers
{   
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Culture { get; set; }

        public static string Translations => Resource.Translations;
        public static string Timezones => Resource.Timezones;
        public static string Accept
        {
            get { return Resource.Accept; }
        }
        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }
        public static string EmailLabel
        {
            get { return Resource.EmailLabel; }
        }
        public static string EmailPlaceholder
        {
            get { return Resource.EmailPlaceholder; }
        }
        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string PasswordLabel
        {
            get { return Resource.PasswordLabel; }
        }
        public static string PassworValidation
        {
            get { return Resource.PassworValidation; }
        }
        public static string PasswordPlaceholder
        {
            get { return Resource.PasswordPlaceholder; }
        }
        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }
        public static string ForgotPassword
        {
            get { return Resource.ForgotPassword; }
        }
        public static string Menu
        {
            get { return Resource.Menu; }
        }
        public static string MyProfile
        {
            get { return Resource.MyProfile; }
        }

        public static string Statistics
        {
            get { return Resource.Statistics; }
        }
        public static string LogOut
        {
            get { return Resource.LogOut; }
        }

        public static string RegisterTitle
        {
            get { return Resource.RegisterTitle; }
        }


        public static string Register
        {
            get { return Resource.Register; }
        }

        public static string Countries
        {
            get { return Resource.Countries; }
        }

        public static string Search
        {
            get { return Resource.Search; }
        }

        public static string Country
        {
            get { return Resource.Country; }
        }

        public static string Information
        {
            get { return Resource.Information; }
        }

        public static string Capital
        {
            get { return Resource.Capital; }
        }

        public static string Population
        {
            get { return Resource.Population; }
        }

        public static string Area
        {
            get { return Resource.Area; }
        }

        public static string AlphaCode2
        {
            get { return Resource.AlphaCode2; }
        }

        public static string AlphaCode3
        {
            get { return Resource.AlphaCode3; }
        }

        public static string Region
        {
            get { return Resource.Region; }
        }

        public static string Subregion
        {
            get { return Resource.Subregion; }
        }

        public static string Demonym
        {
            get { return Resource.Demonym; }
        }

        public static string GINI
        {
            get { return Resource.GINI; }
        }

        public static string NativeName
        {
            get { return Resource.NativeName; }
        }

        public static string NumericCode
        {
            get { return Resource.NumericCode; }
        }

        public static string CIOC
        {
            get { return Resource.CIOC; }
        }

        public static string Borders
        {
            get { return Resource.Borders; }
        }

        public static string Currencies
        {
            get { return Resource.Currencies; }
        }

        public static string MyLanguages
        {
            get { return Resource.MyLanguages; }
        }

        public static string FirstNameLabel
        {
            get { return Resource.FirstNameLabel; }
        }

        public static string FirstNamePlaceholder
        {
            get { return Resource.FirstNamePlaceholder; }
        }
        public static string LastNameLabel
        {
            get { return Resource.LastNameLabel; }
        }

        public static string LastNamePlaceholder
        {
            get { return Resource.LastNamePlaceholder; }
        }

        public static string PasswordConfirmLabel
        {
            get { return Resource.PasswordConfirmLabel; }
        }
        public static string PasswordConfirmPlaceholder
        {
            get { return Resource.PasswordConfirmPlaceholder; }
        }

        public static string TelephoneLabel
        {
            get { return Resource.TelephoneLabel; }
        }
        public static string TelephonePlaceholder
        {
            get { return Resource.TelephonePlaceholder; }
        }

        public static string ConnectionMessage
        {
            get { return Resource.ConnectionMessage; }
        }

        public static string FistNameMessage
        {
            get { return Resource.FistNameMessage; }
        }
        public static string LastNameMessage
        {
            get { return Resource.LastNameMessage; }
        }
        public static string PasswordConfirmMessage
        {
            get { return Resource.PasswordConfirmMessage; }
        }
        public static string TelephoneMessage
        {
            get { return Resource.TelephoneMessage; }
        }
        public static string PasswordConfirmPasswordMessage
        {
            get { return Resource.PasswordConfirmPasswordMessage; }
        }
        public static string PasswordLengthMessage
        {
            get { return Resource.PasswordLengthMessage; }
        }
        public static string PasswordConfirmLengthMessage
        {
            get { return Resource.PasswordConfirmLengthMessage; }
        }
        public static string ConfirmationRegisterMessage
        {
            get { return Resource.ConfirmationRegisterMessage; }
        }
        public static string RegisterNewUserMessage
        {
            get { return Resource.RegisterNewUserMessage; }
        }
        public static string RegisterNewUserEmailMessage
        {
            get { return Resource.RegisterNewUserEmailMessage; }
        }
        public static string SourceImageUserQuestions
        {
            get { return Resource.SourceImageUserQuestions; }
        }
        public static string ImageCamara
        {
            get { return Resource.ImageCamara; }
        }
        public static string ImageGalary
        {
            get { return Resource.ImageGalary; }
        }
        public static string Cancel
        {
            get { return Resource.Cancel; }
        }

        public static string EmailValidation2
        {
            get { return Resource.EmailValidation2; }
        }
        public static string SearchPlaceholder
        {
            get { return Resource.SearchPlaceholder; }
        }
        public static string Groups
        {
            get { return Resource.Groups; }
        }

        public static string Save
        {
            get { return Resource.Save; }
        }

        public static string ChangePassword
        {
            get { return Resource.ChangePassword; }
        }

        public static string CurrentPassword
        {
            get { return Resource.CurrentPassword; }
        }

        public static string CurrentPasswordPlaceHolder
        {
            get { return Resource.CurrentPasswordPlaceHolder; }
        }

        public static string NewPassword
        {
            get { return Resource.NewPassword; }
        }

        public static string NewPasswordPlaceHolder
        {
            get { return Resource.NewPasswordPlaceHolder; }
        }

        public static string ConnectionError1
        {
            get { return Resource.ConnectionError1; }
        }

        public static string ConnectionError2
        {
            get { return Resource.ConnectionError2; }
        }

        public static string LoginError
        {
            get { return Resource.LoginError; }
        }

        public static string ChagePasswordConfirm
        {
            get { return Resource.ChagePasswordConfirm; }
        }

        public static string PasswordError
        {
            get { return Resource.PasswordError; }
        }

        public static string ErrorChangingPassword
        {
            get { return Resource.ErrorChangingPassword; }
        }
        public static string ChageButton
        {
            get { return Resource.ChageButton; }
        }
        public static string ForgotPasswordLabel
        {
            get { return Resource.ForgotPasswordLabel; }
        }
        public static string Send
        {
            get { return Resource.Send; }
        }
        public static string PasswordNewAndCofirnPasswordMessage
        {
            get { return Resource.PasswordNewAndCofirnPasswordMessage; }
        }
        public static string NewPasswordMessage
        {
            get { return Resource.NewPasswordMessage; }
        }
        public static string ConfirmLabel
        {
            get { return Resource.ConfirmLabel; }
        }
    }
}
