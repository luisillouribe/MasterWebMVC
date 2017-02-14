using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MasterWebMVC.Models
{
	public class OurDBContext : DbContext
	{
#pragma warning disable IDE1006 // Estilos de nombres
		public DbSet<UserAccount> userAccount { get; set; }
#pragma warning restore IDE1006 // Estilos de nombres
	}
}