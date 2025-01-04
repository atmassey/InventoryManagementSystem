using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Product
    {
        public BindingList<Part>? AssociatedParts { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }
    }
}