using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initail10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaves",
                columns: table => new
                {
                    LeaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeaveCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LeaveName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LeaveType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MaxDaysPerYear = table.Column<int>(type: "int", nullable: true),
                    IsCarryForward = table.Column<bool>(type: "bit", nullable: false),
                    IsEncashable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaves", x => x.LeaveId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaves");
        }
    }
}
