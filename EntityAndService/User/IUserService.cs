using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.User
{
	public interface IUserService
	{
		Task<List<User>> GetSale();
		Task Add(User  user);
		Task Delete(int Id);
	}
}
