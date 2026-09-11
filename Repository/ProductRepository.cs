using WebApplication1.DBContext;
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class ProductRepository : IProductRepository
    {
        

        public ProductRepository() { 
        
        
        
        }


        private List<ProductModel> products = new List<ProductModel>();
        public List<ProductModel> GetProducts()
        {
            return products;
        }

        public ProductModel GetProductById(int id)
        {
            return products.Find(x=>x.Id==id);
        }

        public string addProduct(string name)
        {
            products.Add(new ProductModel() { Id = products.Count + 1, Name = name, Description = "Description for " + name });
            return "Product added: " + name;
        }

        public ProductModel updateProduct(ProductModel model)
        {
            var product = GetProductById(model.Id);
            product.Description = model.Description;
            product.Name = model.Name;
            
            return GetProductById(model.Id);

        }


    }
}
