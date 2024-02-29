namespace FamilyTreeBuilder.Infrastructure.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

public class FamilyTreeBuilderDbContext : IdentityDbContext
{
    public FamilyTreeBuilderDbContext(DbContextOptions<FamilyTreeBuilderDbContext> options)
        : base(options)
    { }

    public DbSet<FamilyTree> FamilyTrees { get; set; } = null!;

    public DbSet<Person> People { get; set; } = null!;

    public DbSet<Gender> Genders { get; set; } = null!;

    public DbSet<Fact> Facts { get; set; } = null!;

    public DbSet<RelationshipType> RelationshipTypes { get; set; } = null!;

    public DbSet<Relationship> Relationships { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Relationship>()
            .HasOne(r => r.Person1)
            .WithMany(p => p.Relationships)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(builder);
    }
}