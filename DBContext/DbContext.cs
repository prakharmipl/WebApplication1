using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Model.Ecommerce;

namespace WebApplication1.DBContext;





public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }


    public DbSet<ProductModel> Products { get; set; }

    public DbSet<CustomerModel> Customers { get; set; }

    public DbSet<ItemModel> Items { get; set; }

    public DbSet<OrderModel> Orders { get; set; }

    public DbSet<OrderItemModel> OrderItems { get; set; }

    public DbSet<CartItemModel> CartItems { get; set; }

    public DbSet<CartModel> Carts { get; set; }





}
