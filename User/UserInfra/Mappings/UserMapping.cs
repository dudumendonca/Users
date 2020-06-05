using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDomain.Models;

namespace UserInfra.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.UserGender).HasColumnType("char(1)").IsRequired();
            builder.Property(x => x.UserMainEmail).HasColumnType("varchar(254)").IsRequired().IsUnicode(true);
            builder.Property(x => x.UserPassword).HasColumnType("varchar(20)");
            builder.Property(x => x.UserBirthDate).HasColumnType("Date").IsRequired();
            builder.Property(x => x.UserCpf).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.UserFirstLoginDate).HasColumnType("Date");
            builder.Property(x => x.UserDeletedDate).HasColumnType("Date");
            builder.Property(x => x.CustomerId).HasColumnType("int");
            builder.Property(x => x.DepartmentId).HasColumnType("int");
            builder.Property(x => x.CargoId).HasColumnType("int");
            builder.Property(x => x.ProfileId).HasColumnType("int");
            //builder.HasOne(f => f.UserStatus).WithOne(e => e.User);
            builder.Property(x => x.Role).HasColumnType("varchar(50)");
        }
    }
}