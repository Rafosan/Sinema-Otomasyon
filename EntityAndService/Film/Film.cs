using SinemaOtomasyon.EntityAndService.Base;
using SinemaOtomasyon.EntityAndService.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.EntityAndService.Film
{
	public class Film:BaseEntity
	{
		public string DirectorName { get; set; }
		//public List<Admin> Admins { get; set; }
	}
}
