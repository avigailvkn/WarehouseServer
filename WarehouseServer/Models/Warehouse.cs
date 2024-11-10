using System.ComponentModel.DataAnnotations;

namespace WarehouseServer.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }  // מק"ט (שדה זה יהיה Primary Key)
        public int SKU { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string Units { get; set; }
        public string WarehouseName { get; set; }
        public DateTime Date { get; set; }
    }
}
