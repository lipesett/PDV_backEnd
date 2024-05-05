using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDV_backEnd.Migrations
{
    /// <inheritdoc />
    public partial class TracadoIncluded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tracados",
                columns: table => new
                {
                    TRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TRA_NOME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TRA_DATA_ESTREIA = table.Column<DateOnly>(type: "date", maxLength: 50, nullable: false),
                    PIL_VENCEDOR = table.Column<int>(type: "int", nullable: true),
                    EQI_VENCEDORA = table.Column<int>(type: "int", nullable: true),
                    CLI_CLIMA = table.Column<int>(type: "int", nullable: true),
                    SEN_SENTIDO = table.Column<int>(type: "int", nullable: true),
                    KAR_KARTODROMO = table.Column<int>(type: "int", nullable: true),
                    CAL_NUMERO_ETAPA = table.Column<int>(type: "int", nullable: true),
                    MV_ESTREIA = table.Column<int>(type: "int", nullable: true),
                    MV_RECORD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracados", x => x.TRA_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracados");
        }
    }
}
