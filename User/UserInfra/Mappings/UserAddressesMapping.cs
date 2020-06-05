using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDomain.Models;

namespace UserInfra.Mappings
{
    public class UserAddressesMapping : IEntityTypeConfiguration<UserAddress>
    {

        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasKey(x => x.UserAddressId);
            builder.Property(x => x.UserStreetName).HasColumnType("varchar(150)");
            builder.Property(x => x.UserStreetNumber).HasColumnType("int(4)");
            builder.Property(x => x.UserComplement).HasColumnType("varchar(30)");
            builder.Property(x => x.UserNeighborhood).HasColumnType("varchar(50)");
            builder.Property(x => x.UserCity).HasColumnType("varchar(50)");
            builder.Property(x => x.UserState).HasColumnType("char(2)");
            builder.Property(x => x.UserCountry).HasColumnType("varchar(50)");
            builder.Property(x => x.UserZipCode).HasColumnType("int(11)");
        }
    }
}