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
        public int Min { get; set; }
        public int Max { get; set; }
        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts!.Add(part);
        }
        public int RemoveAssociatedPart(int partId)
        {
            for (int i = 0; i < AssociatedParts!.Count; i++)
            {
                if (AssociatedParts[i].PartId == partId)
                {
                    AssociatedParts.RemoveAt(i);
                    return i;
                }
            }
            return -1;
        }
        public Part LookupAssociatedPart(int partId)
        {
            foreach (var part in AssociatedParts!)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null!;
        }
    }
}