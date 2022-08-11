using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cms");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Content",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Title = table.Column<string>(type: "varchar", maxLength: 75, nullable: false),
                    Summary = table.Column<string>(type: "varchar", maxLength: 300, nullable: false),
                    Body = table.Column<string>(type: "text", nullable: true),
                    ContentType = table.Column<string>(type: "text", nullable: false, defaultValue: "NotDefined"),
                    Status = table.Column<string>(type: "text", nullable: false, defaultValue: "Draft"),
                    MetaTitle = table.Column<string>(type: "varchar", maxLength: 65, nullable: true),
                    MetaDescription = table.Column<string>(type: "varchar", maxLength: 330, nullable: true),
                    MetaViewPort = table.Column<string>(type: "varchar", maxLength: 30, nullable: true),
                    MetaRobots = table.Column<string>(type: "varchar", maxLength: 35, nullable: true),
                    created = table.Column<DateTime>(type: "TimestampTz", nullable: false),
                    modified = table.Column<DateTime>(type: "TimestampTz", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    Permalink = table.Column<string>(type: "varchar", maxLength: 35, nullable: false),
                    SubjectType = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "TimestampTz", nullable: false),
                    modified = table.Column<DateTime>(type: "TimestampTz", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ContentSubjects",
                schema: "cms",
                columns: table => new
                {
                    ContentId = table.Column<Guid>(type: "uuid", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ContentSubjects_Content_ContentId",
                        column: x => x.ContentId,
                        principalSchema: "cms",
                        principalTable: "Content",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentSubjects_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "cms",
                        principalTable: "Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ContentSubject_unique_constraint",
                schema: "cms",
                table: "ContentSubjects",
                columns: new[] { "ContentId", "SubjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentSubjects_SubjectId",
                schema: "cms",
                table: "ContentSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_Name_SubjectType_Permalink",
                schema: "cms",
                table: "Subject",
                columns: new[] { "Name", "SubjectType", "Permalink" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentSubjects",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "Content",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "cms");
        }
    }
}
