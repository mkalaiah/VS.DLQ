using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VS.DLQ.Migrations
{
    public partial class EngagementEntites_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DLQQueries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailId = table.Column<string>(nullable: false),
                    IsReplied = table.Column<bool>(nullable: false),
                    Question = table.Column<string>(nullable: false),
                    Response = table.Column<string>(nullable: true),
                    ResponseTimeStamp = table.Column<DateTime>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQQueries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQQueries_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQReportIllegalActivities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    IllegalActivityDate = table.Column<DateTime>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    VesselNo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQReportIllegalActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQReportIllegalActivities_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQReportIssues",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IssueDescription = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQReportIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQReportIssues_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DLQQueries_UserId",
                table: "DLQQueries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQReportIllegalActivities_UserId",
                table: "DLQReportIllegalActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQReportIssues_UserId",
                table: "DLQReportIssues",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DLQQueries");

            migrationBuilder.DropTable(
                name: "DLQReportIllegalActivities");

            migrationBuilder.DropTable(
                name: "DLQReportIssues");
        }
    }
}
