using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace Formula1_App
{
    public partial class DriversPage : ContentPage
    {
        readonly string _baseDriversUri = "https://ergast.com/api/f1/2001/drivers.json";


        private readonly HttpClient _httpClientDrivers;
        public ObservableCollection<Driver> Driver { get; set; } = new();

        public DriversPage()
        {
            InitializeComponent();
            collectionDriversView.ItemsSource = Driver;
            _httpClientDrivers = new HttpClient { BaseAddress = new Uri(_baseDriversUri) };

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadDrivers();

        }

        private async Task LoadDrivers()
        {
            var driverResponse = await _httpClientDrivers.GetFromJsonAsync<DriverRoot>("");

            foreach (var driver in driverResponse?.MRData?.DriverTable?.Drivers)
            {
                Driver.Add(driver);
            }
        }
    }
}
