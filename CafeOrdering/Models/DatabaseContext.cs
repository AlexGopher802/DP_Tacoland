using Microsoft.EntityFrameworkCore;

namespace CafeOrdering.Models;

public class DatabaseContext : DbContext
{
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    private static DatabaseContext _databaseContext;

    public DatabaseContext()
        : this(new DbContextOptions<DatabaseContext>())
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public static DatabaseContext GetInstance() => _databaseContext ??= new DatabaseContext();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=localhost,1434;Initial Catalog=CafeOrderingDB;User ID=sa;Password=AMS25051980s34!");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasData(
                new Product(1,
                    "Чикен тако",
                    "Пшеничная тортилья, курица, специи (лук, чеснок, кумин, кориандр, куркума, сахар, яблоко, тамаринд), соус «Тако»",
                    170,
                    387),
                new Product(2,
                    "Карнитас тако",
                    "Пшеничная тортилья, свинина, специи (лук, кумин, чеснок, ростки картофеля, орегано, паприка), помидоры, соус «Чили»",
                    185,
                    397),
                new Product(3,
                    "Двухъярусное кинг тако",
                    "Пшеничная тортилья, кукурузная тортилья, помидоры, мраморная говядина",
                    320,
                    527),
                new Product(4,
                    "Кинг карнитас буррито",
                    "Пшеничная тортилья, свинина, специи (лук, кумин, чеснок, ростки картофеля, орегано, паприка), фасоль, соус «Cальса»",
                    290,
                    487),
                new Product(5,
                    "Кинг чикен буррито",
                    "Пшеничная тортилья, курица, специи (лук, кумин, чеснок, ростки картофеля, орегано, паприка), фасоль, соус «Тако»",
                    285,
                    487),
                new Product(6,
                    "Диабло биф буррито (очень острое)",
                    "Пшеничная тортилья, сырная тортилья, мраморная говядина, специи (лук, кумин, чеснок, ростки картофеля, орегано, паприка)",
                    355,
                    547)
            );
        });

        base.OnModelCreating(modelBuilder);
    }
}