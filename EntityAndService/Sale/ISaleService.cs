using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Sale
{
	public interface ISaleService
	{
		Task<List<Sale>> GetSale();
		Task Add(Sale  sale);
		Task Delete(int Id);
	}
}
