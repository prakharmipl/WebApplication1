using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model.Ecommerce
{
  
    [Index(nameof(customerId), IsUnique = true)]
    public class CartModel
    {   
        public int Id { get; set; }

        public int customerId { get; set; }

        public CustomerModel customer { get; set; }

        public List<CartItemModel> CartItems { get; set; } = new();
        
    }
}
