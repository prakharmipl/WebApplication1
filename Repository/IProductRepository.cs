
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public interface IProductRepository
    {
        ProductModel GetProductById(int id);
        List<ProductModel> GetProducts();

        string addProduct(string name);

        public ProductModel updateProduct(ProductModel model);



    }

}