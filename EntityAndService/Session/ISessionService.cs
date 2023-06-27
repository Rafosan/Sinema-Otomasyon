using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Session
{
	public interface ISessionService
	{
		Task<List<Session>> GetSale();
		Task Add(Session  session);
		Task Delete(int Id);
	}
}
