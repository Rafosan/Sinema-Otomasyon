using SinemaOtomasyon.EntityAndService.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Session
{
	public class Session:BaseEntity
	{
		public DateTime SessionTime { get; set; }
		//public List<Admin> Admins { get; set; }
	}
}
