using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ConfCore.Web.Models;

namespace ConfCore.Web.Migrations.ConfCoreDb
{
    [DbContext(typeof(ConfCoreDbContext))]
    partial class ConfCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConfCore.Web.Models.Presenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biography");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("TwitterHandle");

                    b.Property<string>("UserId");

                    b.Property<string>("Website");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ConfCore.Web.Models.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract");

                    b.Property<int?>("PresenterId");

                    b.Property<int>("Status");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<int>("Track");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ConfCore.Web.Models.Talk", b =>
                {
                    b.HasOne("ConfCore.Web.Models.Presenter")
                        .WithMany()
                        .HasForeignKey("PresenterId");
                });
        }
    }
}
