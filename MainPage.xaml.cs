using Newtonsoft.Json;
using SinemaOtomasyon.Pages;

namespace SinemaOtomasyon;

public partial class MainPage : ContentPage
{
    private HttpClient httpClient;
    public MainPage()
    {
        InitializeComponent();
        httpClient = new HttpClient();
    }
    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());

        //    string kullaniciAdi = UsernameEntry.Text;
        //    string sifre = PasswordEntry.Text;

        //    // API'ye giriş isteği gönderme
        //    string apiEndpoint = "https://localhost:7281/login";
        //    var content = new FormUrlEncodedContent(new[]
        //    {
        //            new KeyValuePair<string, string>("kullaniciAdi", kullaniciAdi),
        //            new KeyValuePair<string, string>("sifre", sifre)
        //        });

        //    HttpResponseMessage response = await httpClient.PostAsync(apiEndpoint, content);
        //    string responseContent = await response.Content.ReadAsStringAsync();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // API yanıtını modele dönüştürme
        //        LoginResponseModel loginResponse = JsonConvert.DeserializeObject<LoginResponseModel>(responseContent);

        //        if (loginResponse.Success)
        //        {
        //            // Giriş başarılıysa ana sayfaya yönlendirme yapabilirsiniz.
        //            // Örneğin: Navigation.PushAsync(new AnaSayfa());
        //        }
        //        else
        //        {
        //            // Giriş başarısız ise hata mesajı gösterilebilir.
        //            DisplayAlert("Hata", loginResponse.Message, "Tamam");
        //        }
        //    }
        //    else
        //    {
        //        // API yanıtında hata varsa hata mesajı gösterilebilir.
        //        DisplayAlert("Hata", "API ile iletişimde bir sorun oluştu.", "Tamam");
        //    }

        //}
        //public class LoginResponseModel
        //{
        //    public bool Success { get; set; }
        //    public string Message { get; set; }
        //}
    }
}

