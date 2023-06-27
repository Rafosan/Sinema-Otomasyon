using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Theater
{
	public interface ITheaterService
	{
		Task<List<Theater>> GetSale();
		Task Add(Theater  theater);
		Task Delete(int Id);
	}
}
