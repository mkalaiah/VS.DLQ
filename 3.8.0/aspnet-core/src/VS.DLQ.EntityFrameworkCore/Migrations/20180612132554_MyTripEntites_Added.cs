using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VS.DLQ.Migrations
{
    public partial class MyTripEntites_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DLQMyTrips",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    TripDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQMyTrips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQMyTrips_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLQMyTripImages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<byte[]>(nullable: true),
                    MyTripId = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLQMyTripImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLQMyTripImages_DLQMyTrips_MyTripId",
                        column: x => x.MyTripId,
                        principalTable: "DLQMyTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DLQMyTripImages_MyTripId",
                table: "DLQMyTripImages",
                column: "MyTripId");

            migrationBuilder.CreateIndex(
                name: "IX_DLQMyTrips_UserId",
                table: "DLQMyTrips",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DLQMyTripImages");

            migrationBuilder.DropTable(
                name: "DLQMyTrips");
        }
    }
}
