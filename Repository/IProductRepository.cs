
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public interface IProductRepository
    {
        string GetProductById(int id);
        List<ProductModel> GetProducts();

        string addProduct(string name);
            
    }
        
}