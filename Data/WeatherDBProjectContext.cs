using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherDBProject.Models;

namespace WeatherDBProject.Data
{
    public class WeatherDBProjectContext : DbContext
    {
        public WeatherDBProjectContext (DbContextOptions<WeatherDBProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherDBProject.Models.Weather> Weather { get; set; } = default!;
    }
}
