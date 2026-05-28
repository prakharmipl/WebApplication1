using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products = new List<ProductModel>();
        public List<ProductModel> GetProducts()
        {
            return products;
        }

        public string GetProductById(int id)
        {
            return "Product" + id;
        }

        public string addProduct(string name)
        {
            products.Add(new ProductModel() { Id = products.Count + 1, Name = name, Description = "Description for " + name });
            return "Product added: " + name;
        }


    }
}
