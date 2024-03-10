namespace FamilyTreeBuilder.Infrastructure.Data.Configurations;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
{
    public static IdentityUser TestUser1 = GetUser("test@gmail.com", "Aaaaa1");

    public static IdentityUser TestUser2 = GetUser("test2@gmail.com", "Aaaaa2");

    public void Configure(EntityTypeBuilder<IdentityUser> builder)
        => builder.HasData(TestUser1, TestUser2);

    private static IdentityUser GetUser(string email, string password)
    {
        var user = new IdentityUser
        {
            UserName = email,
            Email = email,
            NormalizedUserName = email.ToUpper(),
            NormalizedEmail = email.ToUpper()
        };

        user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, password);
        return user;
    }
}