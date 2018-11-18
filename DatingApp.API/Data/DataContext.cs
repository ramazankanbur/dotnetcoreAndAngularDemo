using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        private IConfiguration _config;
        public DataContext(IConfiguration config, DbContextOptions<DataContext> options) : base(options)
        {
            this._config = config;
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //_config.GetConnectionString("DefaultConnection"); buda kullanılabilir
            //dev db için appsettings.development.json içine aynı key ile db eklenirse o çalışır
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
        }


    }
}