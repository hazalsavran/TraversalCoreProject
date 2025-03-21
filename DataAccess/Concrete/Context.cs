﻿using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAZALSAVRAN\\SQLEXPRESS;database=TraversalDB;integrated security=true;");
        }

        public DbSet<Abouth> Abouths { get; set; }
        public DbSet<Abouth2> Abouth2s { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<SubAbouth> SubAbouths { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Comment> Comments { get; set; }





    }
}
