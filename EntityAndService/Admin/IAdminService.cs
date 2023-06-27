using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Admin
{
	public interface IAdminService
	{
		Task<List<Admin>> GetSale();
		Task Add(Admin  admin);
		Task Delete(int Id);
	}
}
