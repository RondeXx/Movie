using System.Data.Entity;

namespace MovieApp.Service.Models
{
    public partial class MovieAppContext : DbContext
    {
        public MovieAppContext(string connectionString) :base(connectionString)
        {

        }
    }
}
