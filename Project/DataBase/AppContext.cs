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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Конфигурация таблицы Users
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<User>()
                .Property(u => u.Password_Hash)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<User>()
                .Property(u => u.Created_At)
                .IsRequired();

            // Конфигурация таблицы Surveys
            modelBuilder.Entity<Survey>().ToTable("surveys");
            modelBuilder.Entity<Survey>().HasKey(s => s.ID);
            modelBuilder.Entity<Survey>()
                .Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Survey>()
                .Property(s => s.Description)
                .IsRequired();
            modelBuilder.Entity<Survey>()
                .Property(s => s.Is_Active)
                .IsRequired();

            // Конфигурация таблицы Questions
            modelBuilder.Entity<Question>().ToTable("questions");
            modelBuilder.Entity<Question>().HasKey(q => q.ID);
            modelBuilder.Entity<Question>()
                .Property(q => q.Text)
                .IsRequired()
                .HasMaxLength(500);
            modelBuilder.Entity<Question>()
                .Property(q => q.Question_Type)
                .IsRequired()
                .HasMaxLength(50);

            // Связь с Survey
            modelBuilder.Entity<Question>()
                .HasRequired(q => q.Survey)
                .WithMany(s => s.Questions)
                .HasForeignKey(q => q.Survey_ID)
                .WillCascadeOnDelete(true);

            // Конфигурация таблицы Options
            modelBuilder.Entity<Option>().ToTable("options");
            modelBuilder.Entity<Option>().HasKey(o => o.ID);
            modelBuilder.Entity<Option>()
                .Property(o => o.Text)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Option>()
                .Property(o => o.Weight)
                .IsRequired();

            // Связь с Question
            modelBuilder.Entity<Option>()
                .HasRequired(o => o.Question)
                .WithMany(q => q.Options)
                .HasForeignKey(o => o.Question_Id)
                .WillCascadeOnDelete(true);

            // Конфигурация таблицы User_answers
            modelBuilder.Entity<Users_answer>().ToTable("user_answers");
            modelBuilder.Entity<Users_answer>().HasKey(a => a.ID);

            // Связь с User
            modelBuilder.Entity<Users_answer>()
                .HasRequired(a => a.User)
                .WithMany(u => u.User_answers)
                .HasForeignKey(a => a.User_ID)
                .WillCascadeOnDelete(true);
            // Связь с Option
            modelBuilder.Entity<Users_answer>()
                .HasRequired(a => a.Option)
                .WithMany(o => o.User_answers)
                .HasForeignKey(a => a.Option_ID)
                .WillCascadeOnDelete(true);

            // Конфигурация таблицы Products
            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().HasKey(p => p.ID);
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Product>()
                .Property(p => p.Desctiption)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(p => p.Category)
                .IsRequired()
                .HasMaxLength(100);

            // Конфигурация таблицы Favourites
            modelBuilder.Entity<Favourite>().ToTable("favorites");
            modelBuilder.Entity<Favourite>().HasKey(f => f.ID);

            // Связь с User
            modelBuilder.Entity<Favourite>()
                .HasRequired(f => f.User)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.User_ID)
                .WillCascadeOnDelete(true);

            // Связь с Product
            modelBuilder.Entity<Favourite>()
                .HasRequired(f => f.Product)
                .WithMany(p => p.Favourites)
                .HasForeignKey(f => f.Product_ID)
                .WillCascadeOnDelete(true);

            // Конфигурация таблицы Hidden_Products
            modelBuilder.Entity<Hidden_Product>().ToTable("hidden_products");
            modelBuilder.Entity<Hidden_Product>().HasKey(h => h.ID);

            // Связь с User
            modelBuilder.Entity<Hidden_Product>()
                .HasRequired(h => h.User)
                .WithMany(u => u.Hidden_Products)
                .HasForeignKey(h => h.User_ID)
                .WillCascadeOnDelete(true);

            // Связь с Product
            modelBuilder.Entity<Hidden_Product>()
                .HasRequired(h => h.Product)
                .WithMany(p => p.Hidden_Products)
                .HasForeignKey(h => h.Product_ID)
                .WillCascadeOnDelete(true);
        }
    }
}
        

