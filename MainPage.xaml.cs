namespace Weterynarz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onWybrane(object sender, SelectionChangedEventArgs e)
        {
            string gatunek = gatunki.SelectedItem as string;
            if (gatunek == "Pies")
                suwak.Maximum = 18;
            else if (gatunek == "Kot")
                suwak.Maximum = 20;
            else if (gatunek == "Świnka Morska")
                suwak.Maximum = 9;
        }

        private void onZmianaSuwaka(object sender, ValueChangedEventArgs e)
        {
            int wiekWlatach = (int)Math.Round(e.NewValue);
            wiek.Text = wiekWlatach.ToString();
        }

        private async void onClicked(object sender, EventArgs e)
        {
            string wlasciciel = imieNazwisko.Text;
            string gatunek = gatunki.SelectedItem as string;
            string lata = wiek.Text;
            string cel = celWizyty.Text;
            string czasWizyty = DateTime.Today.Add(czas.Time).ToString("HH:mm");

            string podsumowanie = $"{wlasciciel}, {gatunek}, {lata}, {cel}, {czasWizyty}";
            wynik.Text = podsumowanie;
            await DisplayAlert("Podsumowanie wizyty ", podsumowanie, "OK");
        }
    }
}
