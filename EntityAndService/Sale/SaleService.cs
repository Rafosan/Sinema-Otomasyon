using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Sale
{
	public class SaleService : ISaleService
	{
		HttpClient _httpClient;
		JsonSerializerOptions _serializerOptions;
		public SaleService(HttpClient httpClient, JsonSerializerOptions serializerOptions)
		{
			_httpClient = new HttpClient();
			_serializerOptions = new JsonSerializerOptions()
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			};
		}
		public async Task Add(Sale sale)
		{
			var json = JsonSerializer.Serialize(sale);
			JsonContent jsonContent = JsonContent.Create(sale);
			var response = await _httpClient.PostAsync("https://localhost:7281/biletler", jsonContent);
			if (response.IsSuccessStatusCode)
			{

			}
		}

		public async Task Delete(int Id)
		{
			var response = await _httpClient.DeleteAsync($"https://localhost:7281/biletler/{Id}");
			if (response.IsSuccessStatusCode)
			{

			}
		}

		public async Task<List<Sale>> GetSale()
		{
			var response = await _httpClient.GetAsync("https://localhost:7281/biletler");
			if (response.IsSuccessStatusCode)
			{
				string jsonContent = await response.Content.ReadAsStringAsync();
				var sonuc = JsonSerializer.Deserialize<List<Sale>>(jsonContent, _serializerOptions);
				return sonuc;
			}
			return new List<Sale>();
		}
	}
}
