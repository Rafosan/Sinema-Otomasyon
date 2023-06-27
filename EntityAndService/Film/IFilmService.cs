using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Film
{
	public interface IFilmService
	{
		Task<List<Film>> GetSale();
		Task Add(Film  film);
		Task Delete(int Id);
	}
}
