namespace WebApplication1.Model.Ecommerce
{
    public class OrderModel
    {
        public int Id { get; set; }
        
        public int CustomerModelId { get; set; }

        public CustomerModel Customer { get; set; }

        public int TotalAmount { get; set; }

        public string Status { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrderModel> Orders { get; set; } = new();


    }
}
