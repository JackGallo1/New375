using System.ComponentModel.DataAnnotations.Schema;

namespace New375.Data
{
    [Table("Product")]
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
