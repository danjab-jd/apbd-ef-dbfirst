using Microsoft.EntityFrameworkCore;

namespace DbFirst.Entities;

public partial class ApbdDbContext : DbContext
{
    public ApbdDbContext()
    {
    }

    public ApbdDbContext(DbContextOptions<ApbdDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.IdAuthor).HasName("Author_pk");

            entity.ToTable("Author");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(30);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.IdBook).HasName("Book_pk");

            entity.ToTable("Book");

            entity.Property(e => e.PublishYear)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.IdAuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Book_Author");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
