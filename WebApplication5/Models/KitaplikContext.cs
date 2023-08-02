using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
	public class KitaplikContext: DbContext
	{
		public DbSet<Kitap> Kitaplar { get; set; }
		public DbSet<Yazar> Yazarkar { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
            Database=KitaplikYazOkulu;Trusted_Connection=True;");
		}
	}
}
