using SinemaOtomasyon.EntityAndService.Film;

namespace SinemaOtomasyon.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private async void btnFilmler_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FilmPage());
	}

	private async void btnSatislar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SalePage());
	}

	private async void btnSalonlar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TheaterPage());
	}

	private async void btnSinemalar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SessionPage());
	}
}