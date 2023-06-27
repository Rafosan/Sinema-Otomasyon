using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Film
{
	public class FilmService : IFilmService
	{
		HttpClient _httpClient;
		JsonSerializerOptions _serializerOptions;
        public FilmService()
		{
			_httpClient = new HttpClient();
			_serializerOptions = new JsonSerializerOptions()
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			};
		}
		public async Task Add(Film film)
		{
			var json = JsonSerializer.Serialize(film);
			JsonContent jsonContent = JsonContent.Create(film);
			var response = await _httpClient.PostAsync("https://localhost:7019/filmler", jsonContent);
			if (response.IsSuccessStatusCode)
			{

			}
		}

		public async Task Delete(int Id)
		{
			var response = await _httpClient.DeleteAsync($"https://localhost:7019/filmler/{Id}");
			if (response.IsSuccessStatusCode)
			{

			}
		}

		public async Task<List<Film>> GetSale()
		{
			var response = await _httpClient.GetAsync("https://localhost:7019/filmler");
			if (response.IsSuccessStatusCode)
			{
				string jsonContent = await response.Content.ReadAsStringAsync();
				var sonuc = JsonSerializer.Deserialize<List<Film>>(jsonContent, _serializerOptions);
				return sonuc;
			}
			return new List<Film>();
		}
	}
}
