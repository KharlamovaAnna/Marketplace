using System.Data.Entity;

namespace Project.Classes
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Users_answer> User_answers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Hidden_Product> Hidden_Products { get; set; }

    }
}
