using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoList.Entities;
using Microsoft.EntityFrameworkCore;


namespace todoList.Context
{
    public class ToDoContext: DbContext
    {
         public ToDoContext(DbContextOptions<ToDoContext> options) : base(options){

        }

        public DbSet<User> Users{ get; set; }
    }
}