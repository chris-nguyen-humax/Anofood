using OrderFood.Common.ApplicationSettings;
using OrderFood.Common.Helpers;
using System.Data.Entity;

namespace OrderFood.Data.Context
{
    public partial class OrderFoodDbContext : DbContext
    {
        private readonly IAppSettings _appSettings;
        public OrderFoodDbContext(IAppSettings appSettings): base($"name={Constants.ConnectStringName}")
        {
            Database.SetInitializer<OrderFoodDbContext>(null);
            _appSettings = appSettings;
        }

        public OrderFoodDbContext() :base("name=OrderFoodDbContext")
        {

        }
    }
}
