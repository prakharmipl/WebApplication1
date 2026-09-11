using WebApplication1.Repository;

namespace WebApplication1.DBContext
{

    public static class RegisterServices {


        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;

        }



    }








}
