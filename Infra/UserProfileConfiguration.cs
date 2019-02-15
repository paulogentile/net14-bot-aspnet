using SimpleBot.Model;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBot.Infra
{
    public class UserProfileConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration()
        {
            ToTable("UserProfile");

            Property(x => x.Id).HasColumnName("ID").HasColumnType("varchar").IsRequired();
            Property(x => x.Visitas).HasColumnName("VISITAS").HasColumnType("int").IsRequired();

            HasKey(x => x.Id);
        }
    }
}