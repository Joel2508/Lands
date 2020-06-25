using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Common.Helpers
{
    public static class Settings
    {
        private const string _countries = "countries";
        private const string _land = "land";
        private const string _bordes = "bordes";
        private static readonly string _stringDefault = string.Empty;

        private static ISettings AppSettings => CrossSettings.Current;

        public static string Countries
        {
            get => AppSettings.GetValueOrDefault(_countries, _stringDefault);
            set => AppSettings.AddOrUpdateValue(_countries, value);
        }

        public static string Land
        {
            get => AppSettings.GetValueOrDefault(_land, _stringDefault);
            set => AppSettings.AddOrUpdateValue(_land, value);
        }
        public static string Bordes
        {
            get => AppSettings.GetValueOrDefault(_bordes, _stringDefault);
            set => AppSettings.AddOrUpdateValue(_bordes, value);
        }
    }
}
