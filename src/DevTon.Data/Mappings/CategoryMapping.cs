using DevTon.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DevTon.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");


            builder.Property(x => x.Image)
                .IsRequired()
                .HasColumnType("varchar(100)");


            builder.HasMany(x => x.Transactions)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);


            builder.ToTable("Category");
        }
    }
}
