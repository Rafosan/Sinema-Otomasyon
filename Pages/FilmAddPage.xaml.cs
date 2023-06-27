using SinemaOtomasyon.EntityAndService.Film;

namespace SinemaOtomasyon.Pages;

public partial class FilmAddPage : ContentPage
{
    IFilmService _filmService;
    public FilmAddPage()
    {
        InitializeComponent();
        _filmService = new FilmService();
    }
    private DateTime selectedDate;

    private void MyDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        selectedDate = e.NewDate;
    }
    private async void btnFilmAdd_Clicked(object sender, EventArgs e)
    {
        var nameText = FilmAdiEntry.Text;
        var yonetmenText = YonetmenAdiEntry.Text;
        if (nameText != null)
        {
            var film = new Film()
            {
                Name = nameText,
                CreationTime = DateTime.Now,
                DirectorName = yonetmenText,
                DeleteTime=null,
                UpdateTime=null,
            };

            await _filmService.Add(film);

            await DisplayAlert("Mesaj", "Film Eklendi!", "Tamam");
            nameText = null;
            yonetmenText = null;
        }
        else
        {
            await DisplayAlert("Hata", "Geçersiz ad giriþi!", "Tamam");
        }
    }

   
}