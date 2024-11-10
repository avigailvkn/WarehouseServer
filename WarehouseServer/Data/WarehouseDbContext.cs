using Microsoft.EntityFrameworkCore;
using WarehouseServer.Models;

namespace WarehouseServer.Data
{
    public class WarehouseDbContext : DbContext
    {

        // הגדרת DbSet שמייצג את הטבלה במסד הנתונים
        public DbSet<Warehouse> Warehouse { get; set; } // WarehouseItem הוא המודל שלך

        // קונסטרקטור ל-DbContext
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {
        }
   }
}
