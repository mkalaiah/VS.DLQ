using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VS.DLQ.Migrations
{
    public partial class UserRelatedEntites_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DLQSocialStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQSocialStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLQUserAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsCorrespondence = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    PostCode = table.Column<long>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StreetNumberAndName = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UnitNumber = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQUserAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQUserAddresses_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQUserEmails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQUserEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQUserEmails_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQUserProfiles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    SocialStatus = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQUserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQUserProfiles_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DLQUserAddresses_UserId",
                table: "DLQUserAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQUserEmails_UserId",
                table: "DLQUserEmails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQUserProfiles_UserId",
                table: "DLQUserProfiles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DLQSocialStatuses");

            migrationBuilder.DropTable(
                name: "DLQUserAddresses");

            migrationBuilder.DropTable(
                name: "DLQUserEmails");

            migrationBuilder.DropTable(
                name: "DLQUserProfiles");
        }
    }
}
