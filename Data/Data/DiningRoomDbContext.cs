using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Data.Data
{
    public class DiningRoomDbContext : DbContext
    {
        public DiningRoomDbContext(){    }
        public DiningRoomDbContext(DbContextOptions options) : base(options) { }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bread>().HasData(new List<Bread>()
            {
                new Bread() { Id = 1,Name = "Цільнозерновий"    },
                new Bread() { Id = 2,Name = "з висівками"    },


            });
            modelBuilder.Entity<Drinkc>().HasData(new List<Drinkc>() {
            
                new Drinkc() {Id = 1,Name = "Чай"},
                new Drinkc() {Id = 2,Name = "Какао"},

            });
            modelBuilder.Entity<FirstDishes>().HasData(new List<FirstDishes>() {

            new FirstDishes() {Id = 1, Name = "Суп гороховий"},
            
            });
            modelBuilder.Entity<Garnish>().HasData(new List<Garnish>() {

            new Garnish() {Id = 1, Name = "Каша кукурудзяна"},

            });
            modelBuilder.Entity<MeatDishes>().HasData(new List<MeatDishes>() {

            new MeatDishes() {Id = 1, Name = "Нагіци з курки"},

            });
            modelBuilder.Entity<Salad>().HasData(new List<Salad>() {

            new Salad() {Id = 1, Name = "Салат з капусти"},

            });

            modelBuilder.Entity<Menu>().HasData(new List<Menu>() {

            new Menu() {Id = 1, Name = "1-4 Клас", Date = new DateTime(1985,05,01), DayWeek ="Понеділок",
                BreadId =1, SaladId =1, FirstDishesId =1, GarnishId = 1, MeatDishesId = 1, DrinkcId = 2 },

            });

        }

        public DbSet<Bread> Bread { get; set; }
        public DbSet<Drinkc> Drinkc { get; set; }
        public DbSet<FirstDishes> FirstDishes { get; set; }
        public DbSet<Garnish> Garnish { get; set; }
        public DbSet<MeatDishes> MeatDishes { get; set; }
        public DbSet<Salad> Salad { get; set; }
        public DbSet<Menu> Menu { get; set; }



    }


}
