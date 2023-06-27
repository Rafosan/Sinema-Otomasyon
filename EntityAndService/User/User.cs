using SinemaOtomasyon.EntityAndService.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.User
{
	public class User:BaseEntity
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		//public Sale Sale { get; set; }
	}
}
