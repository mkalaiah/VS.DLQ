using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VS.DLQ.Migrations
{
    public partial class Add_Species_and_Rules_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DLQRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: DLQConsts.MaxDescriptionLength, nullable: false),
                    Name = table.Column<string>(maxLength: DLQConsts.MaxNameLength, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(maxLength: DLQConsts.MaxURLLength, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLQSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: DLQConsts.MaxDescriptionLength , nullable: false),
                    Name = table.Column<string>(maxLength: DLQConsts.MaxNameLength, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(maxLength: DLQConsts.MaxURLLength, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQSpecies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DLQRules");

            migrationBuilder.DropTable(
                name: "DLQSpecies");
        }
    }
}
