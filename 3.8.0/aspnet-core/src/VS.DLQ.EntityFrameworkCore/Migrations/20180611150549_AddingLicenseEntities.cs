using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VS.DLQ.Migrations
{
    public partial class AddingLicenseEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DLQEntitlements",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    EntitlementName = table.Column<string>(maxLength: 100, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQEntitlements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLQLicenseStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQLicenseStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLQLicenseTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQLicenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLQLicenses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    LicenseNumber = table.Column<string>(nullable: true),
                    LicenseStatusId = table.Column<long>(nullable: false),
                    LicenseTypeId = table.Column<long>(nullable: false),
                    SubVersion = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    ValidTill = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQLicenses_DLQLicenseStatuses_LicenseStatusId",
                        column: x => x.LicenseStatusId,
                        principalTable: "DLQLicenseStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DLQLicenses_DLQLicenseTypes_LicenseTypeId",
                        column: x => x.LicenseTypeId,
                        principalTable: "DLQLicenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQLicenseTypeEntitlements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntitlementId = table.Column<long>(nullable: false),
                    LicenseTypeId = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQLicenseTypeEntitlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQLicenseTypeEntitlements_DLQEntitlements_EntitlementId",
                        column: x => x.EntitlementId,
                        principalTable: "DLQEntitlements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DLQLicenseTypeEntitlements_DLQLicenseTypes_LicenseTypeId",
                        column: x => x.LicenseTypeId,
                        principalTable: "DLQLicenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQLicenseImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    LicenseId = table.Column<long>(nullable: false),
                    Name = table.Column<byte[]>(maxLength: 100, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQLicenseImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQLicenseImages_DLQLicenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "DLQLicenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQUserLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicenseId = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQUserLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQUserLicenses_DLQLicenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "DLQLicenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DLQUserLicenses_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DLQLicenseImages_LicenseId",
                table: "DLQLicenseImages",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQLicenses_LicenseStatusId",
                table: "DLQLicenses",
                column: "LicenseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQLicenses_LicenseTypeId",
                table: "DLQLicenses",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQLicenseTypeEntitlements_EntitlementId",
                table: "DLQLicenseTypeEntitlements",
                column: "EntitlementId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQLicenseTypeEntitlements_LicenseTypeId",
                table: "DLQLicenseTypeEntitlements",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQUserLicenses_LicenseId",
                table: "DLQUserLicenses",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQUserLicenses_UserId",
                table: "DLQUserLicenses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DLQLicenseImages");

            migrationBuilder.DropTable(
                name: "DLQLicenseTypeEntitlements");

            migrationBuilder.DropTable(
                name: "DLQUserLicenses");

            migrationBuilder.DropTable(
                name: "DLQEntitlements");

            migrationBuilder.DropTable(
                name: "DLQLicenses");

            migrationBuilder.DropTable(
                name: "DLQLicenseStatuses");

            migrationBuilder.DropTable(
                name: "DLQLicenseTypes");
        }
    }
}
