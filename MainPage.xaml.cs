namespace HexStressUI; // Убедись, что эта строка только одна в файле

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		// Это просто визуальная заглушка
		await DisplayAlert("SYSTEM", "Attack sent successfully to server.", "OK");
	}
}