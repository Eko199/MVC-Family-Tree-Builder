namespace FamilyTreeBuilder.Infrastructure.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class FamilyTreeBuilderDbContext : IdentityDbContext
{
    public FamilyTreeBuilderDbContext(DbContextOptions<FamilyTreeBuilderDbContext> options)
        : base(options)
    { }
}