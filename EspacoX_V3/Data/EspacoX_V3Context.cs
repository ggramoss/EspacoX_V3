using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EspacoX_V3.Data
{
    public class EspacoX_V3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EspacoX_V3Context() : base("name=EspacoX_V3Context")
        {
        }

        public System.Data.Entity.DbSet<EspacoX_V3.Models.Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<EspacoX_V3.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<EspacoX_V3.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<EspacoX_V3.Models.Building> Buildings { get; set; }
    }
}
