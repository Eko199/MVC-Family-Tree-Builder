namespace FamilyTreeBuilder.Infrastructure.Data;

using Configurations;
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
        builder
            .ApplyConfiguration(new UserConfiguration())
            .ApplyConfiguration(new GenderConfiguration())
            .ApplyConfiguration(new RelationshipTypeConfiguration())
            .ApplyConfiguration(new PersonConfiguration())
            .ApplyConfiguration(new RelationshipConfiguration())
            .ApplyConfiguration(new FactConfiguration())
            .ApplyConfiguration(new FamilyTreeConfiguration());

        base.OnModelCreating(builder);
    }
}