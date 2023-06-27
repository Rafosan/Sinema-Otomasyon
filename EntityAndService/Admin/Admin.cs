using SinemaOtomasyon.EntityAndService.Base;

namespace SinemaOtomasyon.EntityAndService.Admin
{
	public class Admin:BaseEntity
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		//public Film Film { get; set; }
		//public Session Session { get; set; }
		//public Theater Theater { get; set; }
	}
}
