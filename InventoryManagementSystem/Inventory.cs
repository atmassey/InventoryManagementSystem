using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        public BindingList<Product>? Products;
        public BindingList<Part>? AllParts;

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void AddProduct(Product product)
        {
            Products!.Add(product);
        }
        public bool RemoveProduct(Product product)  {
           var result =  Products!.Remove(product);
            return result;
        }
        public Product LookupProduct(int productId)
        {
            foreach (var product in Products!)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null!;
        }
        public void UpdateProduct(int productId, Product product)
        {
            for (int i = 0; i < Products!.Count; i++)
            {
                if (Products[i].ProductId == productId)
                {
                    Products[i] = product;
                }
            }
        }
        public void AddPart(Part part)
        {
            AllParts!.Add(part);
        }
        public bool DeletePart(Part part)
        {
            var result = AllParts!.Remove(part);
            return result;
        }
        public Part LookupPart(int partId)
        {
            foreach (var part in AllParts!)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null!;
        }
        public void UpdatePart(int partId, Part part)
        {
            for (int i = 0; i < AllParts!.Count; i++)
            {
                if (AllParts[i].PartId == partId)
                {
                    AllParts[i] = part;
                }
            }
        }
    }

}