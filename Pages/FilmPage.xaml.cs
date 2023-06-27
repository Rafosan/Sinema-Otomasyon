using SinemaOtomasyon.EntityAndService.Film;

namespace SinemaOtomasyon.Pages;

public partial class FilmPage : ContentPage
{

    public FilmPage()
    {
        InitializeComponent();
    }

    private async void btnFilmAdd_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new FilmAddPage());
    }

	private void btnFilmList_Clicked(object sender, EventArgs e)
	{

    }

	private void btnFilmDelete_Clicked(object sender, EventArgs e)
	{

    }

	private void btnFilmUpdate_Clicked(object sender, EventArgs e)
	{

    }
}