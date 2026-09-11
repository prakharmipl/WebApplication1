namespace WebApplication1.Model.Ecommerce
{
    public class CartItemModel
    {
        public int Id { get; set; }

        public int CartModelId { get; set; }
        public CartModel Cart { get; set; }

        public int ItemModelId { get; set; }
        public ItemModel Item { get; set; }

        public int Quantity { get; set; }
    }
}
