using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEMOMVC.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<DEMOMVC.Models.Movie> Movie { get; set; }

        public DbSet<DEMOMVC.Models.Student> Student { get; set; }
    }
    