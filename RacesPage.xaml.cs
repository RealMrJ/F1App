using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace Formula1_App;

public partial class RacesPage : ContentPage
{
        readonly string _baseRacesUri = "https://ergast.com/api/f1/2001.json";


        private readonly HttpClient _httpClientRaces;
        public ObservableCollection<Race> Race { get; set; } = new();

        public RacesPage()
        {
            InitializeComponent();
            collectionRacesView.ItemsSource = Race;
            _httpClientRaces = new HttpClient { BaseAddress = new Uri(_baseRacesUri) };

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadRaces();

        }

        private async Task LoadRaces()
        {
            var raceResponse = await _httpClientRaces.GetFromJsonAsync<RaceRoot>("");

            foreach (var race in raceResponse?.MRData?.RaceTable?.Races)
            {
                Race.Add(race);
            }
        }
}