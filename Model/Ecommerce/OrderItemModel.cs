namespace WebApplication1.Model.Ecommerce
{
    public class OrderItemModel
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public OrderModel Order { get; set; }

        public int ItemId { get; set; }
        public ItemModel Item { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }       // price AT PURCHASE TIME — frozen, doesn't move if the item's price changes later

    }
}
