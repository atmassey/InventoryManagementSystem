using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        public BindingList<Product> Products;
        public BindingList<Part> AllParts;

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
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
            AllParts.Add(part);
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
        public void Preload()
        {
            Product product = new Product
            {
                ProductId = Products.Count+1,
                Name = "Engine",
                Price = 1000.00m,
                InStock = 10,
                Min = 1,
                Max = 100
            };
            AddProduct(product);
            Inhouse inhouse = new Inhouse
            {
                PartId = AllParts.Count+1,
                Name = "Radiator",
                Price = 80.00m,
                InStock = 10,
                Min = 1,
                Max = 100,
                MachineId = 1
            };
            AddPart(inhouse);
            Outsourced outsourced = new Outsourced
            {
                PartId = AllParts.Count+1,
                Name = "Crank Shaft",
                Price = 30.00m,
                InStock = 20,
                Min = 1,
                Max = 200,
                CompanyName = "Crank Shaft Corp"
            };
            AddPart(outsourced);
            product.AddAssociatedPart(inhouse);
        }
    }

}