﻿using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
	
    public class AppDBContext : DbContext
    {
		public IConfiguration _config { get; set; }
		public AppDBContext(IConfiguration config)
		{
			_config	= config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
		}
	}
}
